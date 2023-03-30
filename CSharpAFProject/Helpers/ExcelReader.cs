using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using CSharpAFProject.Helpers;
using ExcelDataReader;

namespace CSharpAFProject.ExcelReader
{
    /// <summary>
    /// Helper methods for Email.
    /// </summary>
    public class ExcelReaderHelper
    {
        private static ConcurrentDictionary<string, IExcelDataReader> _cache;
        //private static IDictionary<string, IExcelDataReader> _cache;
        private static FileStream stream;
        private static MemoryStream ms;
        private static IExcelDataReader reader;

        private static DataSet result;

        static ExcelReaderHelper()
        {
            _cache = new ConcurrentDictionary<string, IExcelDataReader>();
            //  _cache = new Dictionary<string, IExcelDataReader>();
        }

        /// <summary>
        /// Opens the excel
        /// </summary>
        /// <param name="filepath">excelfile path</param>
        /// <param name="sheetname">sheetname</param>
        /// <example>How to use it: <code>
        /// ExcelReaderHelper.GetExcelReader(fielpath,sheetname);
        /// </code></example>
        private static IExcelDataReader GetExcelReader(string xlPath, string sheetName)
        {
            if (_cache.ContainsKey(sheetName))
            {
                reader = _cache[sheetName];

                Log4NetHelper.Log("File already in cache " + sheetName);
            }
            else
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                stream = new FileStream(xlPath, FileMode.Open, FileAccess.Read);
                if (Path.GetExtension(xlPath).ToUpper() == ".xls")
                {
                    //1.1 Reading from a binary Excel file ('97-2003 format; *.xls)
                    reader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                else
                {
                    //1.2 Reading from a OpenXml Excel file (2007 format; *.xlsx)
                    reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }
                _cache.TryAdd(sheetName, reader);
                Log4NetHelper.Log("Reader file created " + reader.ToString());

            }
            return reader;
        }

        /// <summary>
        /// returns the total number of rows in the excelsheet
        /// </summary>
        /// <param name="filepath">excelfile path</param>
        /// <param name="sheetname">sheetname</param>
        /// <example>How to use it: <code>
        /// ExcelReaderHelper.GetTotalRows(fielpath,sheetname);
        /// </code></example>
        /// <Return>Return integer of total rows</Return>
        public static int GetTotalRows(string xlPath, string sheetName)
        {
            IExcelDataReader _reader = GetExcelReader(xlPath, sheetName);
            return _reader.AsDataSet().Tables[sheetName].Rows.Count;
        }

        /// <summary>
        /// returns the celldata from the excelsheet
        /// </summary>
        /// <param name="filepath">excelfile path</param>
        /// <param name="sheetname">sheetname</param>
        /// <param name="row">row number</param>
        /// <param name="column">cloumn number</param>
        /// <example>How to use it: <code>
        /// ExcelReaderHelper.GetCellData(fielpath,sheetname,row,column);
        /// </code></example>
        /// <Return>Return cell data</Return>
        public static object GetCellData(string xlPath, string sheetName, int row, int column)
        {

            IExcelDataReader _reader = GetExcelReader(xlPath, sheetName);
            DataTable table = _reader.AsDataSet().Tables[sheetName];
            return table.Rows[row][column];
        }

        /// <summary>
        /// returns the cell data from the excelsheet
        /// </summary>
        /// <param name="filepath">excelfile path</param>
        /// <param name="sheetname">sheetname</param>
        /// <param name="key">row name</param>
        /// <param name="column">cloumn number</param>
        /// <example>How to use it: <code>
        /// ExcelReaderHelper.GetCellDataKey(fielpath,sheetname,key,column);
        /// </code></example>
        /// <Return>Return cell data of obeject type</Return>

        public static object GetCellDataKey(string xlPath,
                                            string sheetName,
                                            string keyName,
                                            string columnName)
        {
            string cellData = null;

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(xlPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = false
                        }
                    });
                    DataTableCollection table = result.Tables;
                    //Store it in DataTable
                    DataTable resultTable = table[sheetName];

                    Log4NetHelper.Log("DataTable as " + resultTable, Log4Type.Info);

                    for (int i = 0; i <= resultTable.Rows.Count; i++)
                    {
                        String keyValue = resultTable.Rows[i][0].ToString();
                        if (keyValue.Equals(keyName))
                        {
                            Console.WriteLine("RowName " + keyValue);
                            for (int j = 0; j < resultTable.Columns.Count; j++)
                            {
                                String colName = resultTable.Rows[0][j].ToString();
                                if (colName.Equals(columnName))
                                {
                                    cellData = resultTable.Rows[i][j].ToString();
                                    if (cellData == null)
                                        throw new Exception("Value your trying to enter is empty for " + colName);
                                    break;
                                }
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    Log4NetHelper.Log("CellData as " + cellData);
                }
            }
            return cellData;
        }


        /// <summary>
        /// returns the cell data from the excelsheet
        /// </summary>
        /// <param name="type">data type</param>
        /// <param name="data">cell data</param>
        /// <example>How to use it: <code>
        /// ExcelReaderHelper.GetData(type,data);
        /// </code></example>
        /// <Return>Return cell data of obeject type</Return>
        private static object GetData(Type type, object data)
        {
            switch (type.Name)
            {
                case "String":
                    return data.ToString();
                case "Double":
                    return Convert.ToDouble(data);
                case "DateTime":
                    return Convert.ToDateTime(data);
                default:
                    return data.ToString();
            }
        }




        public static DataTable GetDataTable(string xlPath, string sheetName)
        {
            DataTable resultTable;

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(xlPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = false
                        }
                    });
                    DataTableCollection table = result.Tables;
                    //Store it in DataTable
                    resultTable = table[sheetName];
                }
            }

            return resultTable;
        }
    }
}

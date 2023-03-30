using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CSharpAFProject.Helpers
{
    public class Excel
    {
        public static IExcelDataReader getExcelReader(string xlPath)
        {
            return ExcelReaderFactory.CreateReader(System.IO.File.OpenRead(xlPath));
        }

        public static IEnumerable<string> getWorksheetNames(string xlPath)
        {
            var reader = getExcelReader(xlPath);
            var workbook = reader.AsDataSet();
            var sheets = from DataTable sheet in workbook.Tables.Cast<DataTable>() select sheet.TableName;
            return sheets;
        }

        public static IEnumerable<DataRow> getData(string xlPath, string sheet, int row, int column, bool firstRowIsColumnNames = false)
        {
            var reader = getExcelReader(xlPath);
            reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = firstRowIsColumnNames
                }
            });
            var workSheet = reader.AsDataSet().Tables[sheet];
            var rows = from DataRow a in workSheet.Rows select a;
            return rows;
        }

      /*  public static IEnumerable<DataRow> GetFirstSheetData(string xlPath, bool firstRowIsColumnNames = false)
        {
            var reader = getExcelReader(xlPath);
            reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = firstRowIsColumnNames
                }
            });
            return getData(xlPath, getWorksheetNames(xlPath).First());
        }
       */

    }
}

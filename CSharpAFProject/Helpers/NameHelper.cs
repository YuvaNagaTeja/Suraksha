using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Helper methods for generating name
    /// </summary>
    public static class NameHelper
    {

        /// <summary>
        /// Create random name.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns>Random name.</returns>
        public static string RandomName(int length)
        {
            const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var randomString = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < length; i++)
            {
                randomString.Append(Chars[random.Next(Chars.Length)]);
            }
            Log4NetHelper.Log("random name generated " + randomString, Log4Type.Debug);

            return randomString.ToString();
        }

        /// <summary>
        /// Remove all special characters except digit and letters.
        /// </summary>
        /// <param name="name">The string to remove special chracters.</param>
        /// <returns>String with removed all special chracters.</returns>
        /// <example>How to use it: <code>
        /// var name = NameHelper.RemoveSpecialCharacters("country/region");
        /// </code></example>
        public static string RemoveSpecialCharacters(string name)
        {
            Log4NetHelper.Log("Removing all special characters except digit and letters from '{0}' "+name, Log4Type.Debug);
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            name = rgx.Replace(name, string.Empty);
            Log4NetHelper.Log("name without special characters: '{0}' " +name, Log4Type.Debug);

            return name;
        }

    }
}

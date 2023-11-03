using System;
using System.Text.RegularExpressions;

namespace Application.Services
{
    public static class StringExtension
    {
        public static string NullOrEmpty(this String str)
        {
            return String.IsNullOrEmpty(str) ? null : str;
        }

        public static bool IsNullOrEmpty(this String str)
        {
            return String.IsNullOrEmpty(str);
        }
        public static string RemoveWhitespaces(this String str)
        {
            Regex sWhitespace = new Regex(@"\s+");
            return sWhitespace.Replace(str, "");
        }
    }
}

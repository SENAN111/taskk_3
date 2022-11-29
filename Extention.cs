using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public static class Extention
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 == 0;
        }
        public static bool IsEven(this int number)
        {
            return number % 2 == 1;
        }
        public static bool HasDigit(this string text)
        {
            for (int i = 0; text.Length > i; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static string Capitalize(this string text_2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(text_2[0]));
            sb.Append(text_2.Substring(1).ToLower());
            return sb.ToString();
        }

    }
}

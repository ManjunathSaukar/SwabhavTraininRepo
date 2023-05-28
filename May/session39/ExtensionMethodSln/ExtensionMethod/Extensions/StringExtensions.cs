using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.Extensions
{
    public static class StringExtensions
    {
        public static string Foo(this string input)
        {
            return input + "Foo";
        }
        public static bool IsPalindrome(this string str)
        {
            string reversedStr = new string(str.Reverse().ToArray());
            return str.Equals(reversedStr);
        }
    }
}

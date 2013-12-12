using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenCSharpCodingSamples
{
    // Extensions to the string class
    public static class StringExtensions
    {
        public static string Left(this string s, int nCount)
        {
            return s.Substring(0, nCount);
        }
        public static string Right(this string s, int nCount)
        {
            return s.Substring(s.Length - nCount, nCount);
        }
        public static string Slice(this string s, int nStart, int nEnd)
        {
            return s.Substring(nStart, nEnd-nStart+1);
        }
    }


    class ExtensionMethods
    {

        public static void ExtensionMethodsFunc()
        {
            string Test = "Hello World";
            string left = Test.Left(5);
            string right = Test.Right(4);
            string mid = Test.Slice(5,6);

            System.Console.WriteLine(left + mid + right);
        }
    
    }
}

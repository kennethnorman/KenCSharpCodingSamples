using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenCSharpCodingSamples
{
    public class ArrayExamples
    {
        private static void DisplayArray<T>(T[] array)
        {
            foreach (T element in array)
            {
                Console.Write(element);
            }
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i < array.GetLength(0)-1)
                {
                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        public static void ArrayFunc()
        {
            // Declare an array
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 6, 7, 8 };

            // Declare an array
            short nLen = 10;
            int[] aNumbers = new int[nLen];

            // Copy one array to another
            aNumbers = array1;
            // Add stuff from another
            int[] aNumbers2 = aNumbers.Concat(array2).ToArray();
            aNumbers = aNumbers.Concat(array2).ToArray();
            // Add em up
            int nSum= aNumbers.Sum();
            string s= aNumbers.ToString();
            
            DisplayArray<int>(aNumbers);


            // Declare an array
            decimal[] aDecimals = { 1.2M, 2.3M, 3.4M, 4.5M, 5.6M };
            DisplayArray<decimal>(aDecimals);

        }

    }
}


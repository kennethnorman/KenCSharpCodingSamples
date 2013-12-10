using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenCSharpCodingSamples
{
    public class DateTimeExamples
    {
        public static void OutputCurrentTime()
        {
            Console.WriteLine("Current Date and Time is " + DateTime.Now);

            DateTime now = DateTime.Now;

            // Dates only
            Console.WriteLine("Current Long Date is " + now.ToLongDateString());
            Console.WriteLine("Current Short Date is " + now.ToShortDateString());
            Console.WriteLine("Current Year is " + now.Year);
            // Times only
            Console.WriteLine("Current Long Date is " + now.ToLongTimeString());
            Console.WriteLine("Current Short Date is " + now.ToShortTimeString());
            Console.WriteLine("Current Hour is " + now.Hour);

            DateTime yesterday = now.AddDays(-1);
            Console.WriteLine("Yesterdays Date is " + yesterday.ToLongDateString());

            TimeSpan Span = now - yesterday;
            Console.WriteLine("Time elapsed is " + Span.TotalHours);

            if (now.CompareTo(yesterday) > 0)
            {
                Console.WriteLine("now is greater than yesterday!");
            }

            if (now.IsDaylightSavingTime())
            {
                Console.WriteLine("DaylightSaving ON!");
            }
            else
            {
                Console.WriteLine("DaylightSaving OFF!");
            }

            TypeCode tc= now.GetTypeCode();
            Console.WriteLine("TypeCode " + tc.ToString());
        }
    }
}
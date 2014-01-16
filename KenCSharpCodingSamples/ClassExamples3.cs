using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenCSharpCodingSamples
{
    public class ClassExamples3
    {
        abstract public class ABC
        {
            abstract public void DoWork();
        }

        sealed public class Worker : ABC
        {
            override public void DoWork()
            {
                Console.WriteLine("DoWork");
            }
        }

        /* Can't derive from sealed class.
        public class Slacker : Worker
        {
            override public void DoWork()
            {
                Console.WriteLine("DoNoWork");
            }
        }
         */


        public static void ClassExamples3Func()
        {
            Worker w= new Worker();

            w.DoWork();
        }
    }
}
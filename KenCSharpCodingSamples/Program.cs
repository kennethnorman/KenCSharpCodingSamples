using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenCSharpCodingSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Date and Time handling
            DateTimeExamples DTE = new DateTimeExamples();
            //DateTimeExamples.OutputCurrentTime();

            // Array handling
            ArrayExamples AE = new ArrayExamples();
            ArrayExamples.ArrayFunc();

            // Collections handling
            CollectionExamples CE = new CollectionExamples();
            CollectionExamples.CollectionFunc();

            // Collections handling
            ClassExamples1 CE1 = new ClassExamples1();
            ClassExamples1.ClassExamples1Func();

            Environment.ExitCode = 1;
        }
    }
}

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

            // Classes 101
            ClassExamples1 CE1 = new ClassExamples1();
            ClassExamples1.ClassExamples1Func();

            // Extension Methods
            ExtensionMethods EM1 = new ExtensionMethods();
            ExtensionMethods.ExtensionMethodsFunc();

            Environment.ExitCode = 1;
        }
    }
}

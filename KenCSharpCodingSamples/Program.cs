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

            // Classes 102
            ClassExamples2 CE2 = new ClassExamples2();
            ClassExamples2.ClassExamples2Func();

            // Classes 103
            ClassExamples3 CE3 = new ClassExamples3();
            ClassExamples3.ClassExamples3Func();

            // Extension Methods
            ExtensionMethods EM1 = new ExtensionMethods();
            ExtensionMethods.ExtensionMethodsFunc();

            Environment.ExitCode = 1;
        }
    }
}

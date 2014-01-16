using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenCSharpCodingSamples
{
    public class ClassExamples2
    {
        public class BaseClass
        {
            public BaseClass()
            {
                Console.WriteLine("BaseClass()");
            }

            public BaseClass(int i)
            {
                Console.WriteLine("BaseClass(i)");
            }

            public void MyFunc()
            {
                Console.WriteLine("BaseClass::MyFunc()");
            }

            public virtual void MyVirtualFunc()
            {
                Console.WriteLine("BaseClass::MyVirtualFunc()");
            }
        }

        public class SubClass : BaseClass
        {
            public SubClass()
            {
                Console.WriteLine("SubClass()");
            }

            public SubClass(int i)
                // Ensure the correct form of the base class constructor is called
                : base(i)
            {
                Console.WriteLine("SubClass(i)");
            }

            public SubClass(string s)
            {
                Console.WriteLine("SubClass(s)");
            }

            // Force function to override base version with "new".
            public new void MyFunc()
            {
                Console.WriteLine("SubClass::MyFunc()");

                // And call the base version too.
                base.MyFunc();
            }

            public override void MyVirtualFunc()
            {
                Console.WriteLine("SubClass::MyVirtualFunc()");
            }
        }



        public class SubSubClass : SubClass
        {
            public SubSubClass()
            {
                Console.WriteLine("SubSubClass()");
            }

            public SubSubClass(int i)
                // Ensure the correct form of the base class constructor is called
                : base(i)
            {
                Console.WriteLine("SubSubClass(i)");
            }

            public SubSubClass(string s)
            {
                Console.WriteLine("SubSubClass(s)");
            }

            // Force function to override base version with "new".
            public new void MyFunc()
            {
                Console.WriteLine("SubSubClass::MyFunc()");

                // And call the base version too.
                base.MyFunc();
            }

            public override void MyVirtualFunc()
            {
                Console.WriteLine("SubSubClass::MyVirtualFunc()");
            }
        }


        public static void ClassExamples2Func()
        {
            // Getting specific with base constructor
            SubClass sci = new SubClass(1);
            SubClass scs = new SubClass("test");

            scs.MyFunc();

            // Getting specific with base constructor
            SubSubClass ssci = new SubSubClass(1);
            SubSubClass sscs = new SubSubClass("test");

            sscs.MyVirtualFunc();
        }
    }
}
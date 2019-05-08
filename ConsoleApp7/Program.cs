using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleApp7;

namespace ConsoleApp7
{
    class Program
    {
        private static bool bString;

        static void Main(string[] args)
        {
            someMethod();
            someMethod("Hello");
            String aString = someMethod(1);
            Console.WriteLine(aString);
            Test.someThing();
           
            Console.ReadLine();
        }
        private static void someMethod()
        {
            Console.WriteLine("someMethod");
        }
        public static void someMethod(string aString)
        {
            Console.Write("someMethod aString:");
            Console.WriteLine(aString);
        }
        private static String someMethod(int intNum)
        {
            return "Done";
        }
    }

    class Test
    {
        public static void someThing()
        {
            Console.WriteLine("someThing");
        }
    }

}

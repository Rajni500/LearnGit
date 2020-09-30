using System;

namespace BasicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test.MyProperty);
            Console.ReadKey();
        }
    }

    public class Test
    {
        public static int MyProperty { get; set; }

        public Test()
        {
           
        }
    }
}

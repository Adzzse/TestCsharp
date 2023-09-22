using System;
using System.Data;

namespace Test
{
    public delegate int MyDelegate(int a, int b);

    internal class Program
    {
        static void DemoMethodDelegateParameter(MyDelegate my, int x, int y, string msg)
        {
            var result = my(x, y);
            Console.WriteLine(msg + result);
        }
        static void Main(string[] args)
        {
            DemoMethodDelegateParameter(Demo.Sum, 5, 6, "Hello ");
        }

    }
    class Demo
    {
        public static int Sum(int a, int b) => (a + b);
        public static int Sub(int a, int b) => (a - b);
    }
}

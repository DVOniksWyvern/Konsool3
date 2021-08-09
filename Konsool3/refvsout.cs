using System;

namespace RefVsOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 2;

            Method1(out first, out second); // passing both arguments to methods as referency types
            Method2(first, ref second); // passing second argument by a reference
            Method3(ref first, second); // the other way, passing first argument by a reference

            Console.WriteLine($"first: {first}, second: {second}"); // the result is 10 and 10 because effectively these both are 2*5, just with a different ways of passing the information
            Console.ReadLine();

        }

        static void Method1(out int a, out int b)
        {
            a = 2;
            b = 1;
        }

        static void Method2(int a, ref int b)
        {
            a *= 5;
            b *= a;
        }

        static void Method3(ref int a, int b)
        {
            a *= 5;
            b *= b;
        }
    }
}
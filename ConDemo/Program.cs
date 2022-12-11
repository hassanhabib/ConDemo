#define UniverseFeature

using System;
using System.Diagnostics;

namespace ConDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Foo();
            Console.WriteLine("Hello, World!");
        }

        [Conditional("UniverseFeature")]
        static void Foo() =>
            Console.WriteLine("Hello, Universe!");
    }
}
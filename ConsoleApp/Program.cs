using Domain;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            Console.WriteLine(p.SayHello());
        }
    }
}
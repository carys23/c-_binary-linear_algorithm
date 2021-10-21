// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace c

{
    class Program
    {
    static void Main(string[] args)
    {
        Random random = new Random();
        for (int i = 0; i < 1; i ++)
        {
            Console.WriteLine(random.Next(101));
        }
        Console.ReadLine();
    }
}
}


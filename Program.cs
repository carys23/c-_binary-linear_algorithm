// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace c

{
    class Program
    {
    static void Main(string[] args)
    {
        const int number = 10;
        Random random = new Random();

        for (int i = 0; i < 1; i ++)
        {
            MyRandomNumber(random);
        }

        Console.ReadLine();
        Console.WriteLine("Number is " + number);

    }

    private static void MyRandomNumber(Random random)
    {
        Console.WriteLine("Random number is " + random.Next(101));

    }

    }
}


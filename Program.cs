// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace Algorithm

{
    class Program
    {
    static void Main(string[] args)
    {
        Algorithm.Program.MyRandomNumber();

    }



    static void MyRandomNumber()
    {
        const int number = 10;
        Console.ReadLine();
        Console.WriteLine("Number is " + number);
        Random random = new Random();

        for (int i = 0; i < 1; i ++)
        {
            Console.WriteLine("Random number is " + random.Next(101));
        }

    }

    }
}


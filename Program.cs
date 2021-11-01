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



    // static void Number()
    // {
    //     for (int numbers = 1; numbers <= 20; numbers++)
    //     Console.WriteLine("Number is " + numbers);
    // }


    static void MyRandomNumber()

    {

        Random random = new Random();
        int random_number = random.Next(10);
        int numbers = 0;
        int count = 0;

        for (int num = 1; num <= random_number; num++)

        {
            numbers = num;
            // Console.WriteLine("Random number is " + random_number + " and number is "  + numbers);


            if ( random_number == numbers)
        {
            Console.WriteLine("Found number " + random_number );
            count += 1;
            Console.WriteLine("It was found in " + count +  " counts.");
        }

        else
        {
            count += 1;

        }

        }

    }

    }

}


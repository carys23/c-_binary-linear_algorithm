// See https://aka.ms/new-console-template for more information
using System;

namespace SerachingAlgorithm

{
    class BinaryAndLinear
    {
    const int maxValue = 1000000;
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(maxValue);
        LinearSearch(randomNumber);
    }



    static void Binary()
    {

    }





    static void LinearSearch(int valueToFind)

    {

        int valueChecked = -1;

        for (int currentValue = 0; currentValue <= maxValue; currentValue++)

        {
            valueChecked += 1;

            if (currentValue == valueToFind)
            {
                Console.WriteLine("Found number " + valueToFind);
                Console.WriteLine("It was found in " + valueChecked + " counts.");
                return;

            }
        }

        Console.WriteLine(valueToFind + "Was not in list");
    }

    }

}
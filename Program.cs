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
        BinarySearch(randomNumber);
    }



    static void BinarySearch(int randomNumber)

    /// The binary search will split the number in the middle to find the random number
    /// and will continue to do this until it finds the number. The valueChecked is a counter
    /// to count how many times to took to find the random number.
    {
        // int valueChecked = -1;
        int currentValue = 0;
        int mid = (currentValue + maxValue) / 2;

        Console.WriteLine("Mid is " + mid );

        if (mid == randomNumber)
            {
                Console.WriteLine("Found number " + randomNumber + " is was " + mid);
                return;

            }

        else
            if (mid > randomNumber)
            {
                int NewValue = mid;
                Console.WriteLine("Max value is now " + NewValue);
                return;
            }

    }



    static void LinearSearch(int randomNumber)
    /// The linear search will search for the random numbder created search from 1 and incrementing each time
    /// until it finds the random number. The valueChecked is a counter to see how times to took to find the number.

    {

        int valueChecked = -1;

        for (int currentValue = 0; currentValue <= maxValue; currentValue++)

        {
            valueChecked += 1;

            if (currentValue == randomNumber)
            {
                Console.WriteLine("Found number " + randomNumber);
                Console.WriteLine("It was found in " + valueChecked + " counts.");
                return;

            }
        }

        Console.WriteLine(randomNumber + "Was not in list");
    }

    }

}
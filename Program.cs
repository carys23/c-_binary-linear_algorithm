// See https://aka.ms/new-console-template for more information
using System;

namespace SerachingAlgorithm

{
    class BinaryAndLinear
    {
    const int ArraySize = 1000000;
    const int maxValue = 10000000;
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(maxValue);
        int [] ListOfValues = GenerateList(ArraySize, maxValue);
        LinearSearch(randomNumber, ListOfValues);
        BinarySearch(randomNumber, ListOfValues);

    }

    static int[] GenerateList(int NumberValues, int maxValue)
    {
        int[] List = new int[NumberValues];
        Random random = new Random();
        for (int i = 0; i < NumberValues; i++)
        {
            List[i] = random.Next(maxValue);
        }
        Array.Sort(List);
        return List;
    }

    static void BinarySearch(int ValueToFind, int[] ValuesToCheck)
    /// The binary search will split the number in the middle to find the random number
    /// and will continue to do this until it finds the number. The valueChecked is a counter
    /// to count how many times to took to find the random number.
    {
        int low = 0;
        int high = ArraySize;
        int count = 0;

        while (low < high)
        {
            count++;
            int mid = (low + high) / 2;  /// Find the middle number

            if (ValueToFind == ValuesToCheck[mid])
            {
                Console.WriteLine("Found number " + ValueToFind + " after " + count + " counts");
                return;
            }

            if ( ValueToFind < ValuesToCheck[mid])
            {
                high = mid -1;
            }
            else
            {
                low = mid +1;
            }
        }
        Console.WriteLine("Couldn't find value " + ValueToFind + " it took " + count + " counts to try to find.");
    }



    static void LinearSearch(int ValueToFind, int[] ValuesToCheck)
    /// The linear search will search for the random numbder created search from 1 and incrementing each time
    /// until it finds the random number. The valueChecked is a counter to see how times to took to find the number.

    {
        for (int i = 0; i < ArraySize; i++)

        {
            if (ValuesToCheck[i] == ValueToFind)

            {
                Console.WriteLine("It was found in " + (i +1) + " counts.");
                return;
            }

        }

        Console.WriteLine(ValueToFind + " was not in list");
    }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the size of the list: ");
            int listSize = int.Parse(Console.ReadLine());

            if (listSize <= 0)
            {
                Console.WriteLine("List size should be a positive integer.");
                return;
            }

            List<int> arr = GenerateList(listSize);
            (int dominantValue, int count) = FindDominantValue(arr);

            Console.WriteLine("The generated list is: " + string.Join(", ", arr));
            Console.WriteLine($"The dominant value is: {dominantValue} (appears {count} times)");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer for the list size.");
        }
    }

    static List<int> GenerateList(int size)
    {
        Random random = new Random();
        List<int> list = new List<int>();
        for (int i = 0; i < size; i++)
        {
            list.Add(random.Next(1, 101));
        }
        return list;
    }

    static (int, int) FindDominantValue(List<int> arr)
    {
        int maxCount = 0;
        int dominantValue = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            int currentValue = arr[i];
            int count = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                if (arr[j] == currentValue)
                {
                    count += 1;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                dominantValue = currentValue;
            }
        }

        return (dominantValue, maxCount);
    }
}

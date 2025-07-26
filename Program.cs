using System;
using System.Linq;

public class MissedNumberFinder
{
    static void Main()
    {
         //Get count and the numbers
        Console.Write("Enter the count ");
        int count = int.Parse(Console.ReadLine()!);

        int[] numbers = new int[count];
        Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < count; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine()!);
        }
        //sort
        Array.Sort(numbers);
        Console.WriteLine("\nMissing numbers:");
        for (int i = numbers[0]+1; i <= numbers[count-1]; i++)
        {
            if (!numbers.Contains(i))
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the start of the range:");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end of the range:");
        int end = int.Parse(Console.ReadLine());

        // Все числа диапазона
        Console.WriteLine("All the numbers of range:");
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Все числа диапазона в нисходящем порядке
        Console.WriteLine("All numbers in the range in descending order:");
        for (int i = end; i >= start; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Все числа, кратные 7
        Console.WriteLine("Range numbers, multiples of 7:");
        for (int i = start; i <= end; i++)
        {
            if (i % 7 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        // Количество чисел, кратных 5
        int countMultiplesOf5 = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                countMultiplesOf5++;
            }
        }
        Console.WriteLine($"Number of numbers that are multiples of 5: {countMultiplesOf5}");
    }
}
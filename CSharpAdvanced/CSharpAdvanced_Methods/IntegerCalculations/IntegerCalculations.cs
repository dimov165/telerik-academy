﻿using System;
using System.Linq;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(CalculateMinimum(numbers));
            Console.WriteLine(CalculateMaximum(numbers));
            Console.WriteLine("{0:F2}", CalculateAverage(numbers));
            Console.WriteLine(CalculateSum(numbers));
            Console.WriteLine(CalculateProduct(numbers));
        }

        static int CalculateMinimum(int[] numbers)
        {
            int Minimum = 1000;
            foreach (int num in numbers)
            {
                if (Minimum > num)
                {
                    Minimum = num;
                }
            }

            return Minimum;
        }

        static int CalculateMaximum(int[] numbers)
        {
            int Maximum = -1000;
            foreach (int num in numbers)
            {
                if (Maximum < num)
                {
                    Maximum = num;
                }
            }

            return Maximum;
        }

        static decimal CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            decimal Average = (decimal)(sum) / (decimal)numbers.Length;
            return Average;

        }

        static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum;
        }

        static long CalculateProduct(int[] numbers)
        {
            long product = 1;
            foreach (int num in numbers)
            {
                product *= num;
            }

            return product;
        }
    }
}
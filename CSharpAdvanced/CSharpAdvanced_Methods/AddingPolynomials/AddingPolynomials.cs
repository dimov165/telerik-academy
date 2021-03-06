﻿using System;
using System.Linq;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] poly1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] poly2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            AddPolynominals(poly1, poly2);
        }

        static void AddPolynominals(int[] arr0, int[] arr1)
        {
            int[] arrResult = new int[arr0.Length];
            for (int i = 0; i < arr0.Length; i++)
            {
                arrResult[i] = arr0[i] + arr1[i];
            }

            for (int i = 0; i < arrResult.Length; i++)
            {
                Console.Write(arrResult[i] + " ");
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21Generics
{
    class Solution
    {

        static void PrintArray<T>(T[] arr)
        {
            foreach (T t in arr)
            {
                Console.WriteLine(t);
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
            
            PrintArray<Int32>(intArray);
            PrintArray<String>(stringArray);

        }
    }
}

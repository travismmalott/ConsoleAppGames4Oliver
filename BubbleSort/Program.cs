﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //insert ANY ints you want into the array and it will sort them for you
            int[] arr = { 1,65434,5,344,432432,111,32,6,0,-1,420,69, -69, };
            int t;

            //writing out the array in its original order
            Console.WriteLine("The Array is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //put the array in ascending format
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }
            }
            //display the ascending array
            Console.WriteLine();
            Console.WriteLine("The Ascending Sorted Array is : ");
            foreach (int value in arr)
            {
                Console.WriteLine(value + " ");
            }
            //descending sort by reversing array
            Console.WriteLine();
            Console.WriteLine("The Descending Sorted Array : ");
            //Array.Reverse() to reverse the ascending sort and display it in descending form
            Array.Reverse(arr);
            foreach (int value in arr)
            {
                Console.WriteLine(value + " ");
            }
            Console.ReadLine();
        }
    }
}

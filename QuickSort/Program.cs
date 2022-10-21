﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        //array of integers to hold
        private int[] arr = new int[20];
        private int cmp_count = 0; //number of comparasion
        private int mov_count = 0; //number of data movement

        //Number of elements in array
        private int n;
        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements\n");
            }
            Console.WriteLine("\n================================================");
            Console.WriteLine("Enter  Array Elements");
            Console.WriteLine("\n================================================");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        //swaps the element at index x with the element at index y
        void swap (int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr [y];
            arr[y] = temp;
        }

        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low < high)
                return;


            //Partition the list into two parts:
            //one containing elements less that or equal to pivot
            //Other containing elements greather than pivot

            i = low + 1;
            j = high;

            pivot = arr[low];

            
        static void Main(string[] args)
        {
        }
    }
}

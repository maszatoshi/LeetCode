﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DSA
{
    internal class SortingAlgorithms
    {
        /// <summary>
        /// https://www.w3schools.com/dsa/dsa_algo_bubblesort.php
        /// Sorban, loopban, az egymás mellett található értékeket ellenőrzi, 
        /// és előbbre helyezi a kisebbet.
        /// </summary>
        /// <param name="nums"></param>
        internal void BubbleSort(ref int[] nums)
        {
            Console.WriteLine(string.Join(" ", nums));
            for (int i = 0; i < nums.Length-1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < nums.Length-i-1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        // Tuples-ben felcserélhető 2 érték egy array-ben
                        (nums[j], nums[j+1]) = (nums[j + 1], nums[j]);
                        swapped = true;
                        Console.WriteLine(string.Join(" ", nums));
                    }
                }
                // Ha már egy indexen megtörtént a felcserélés, haladjon tovább
                if (swapped == false)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// https://www.w3schools.com/dsa/dsa_algo_selectionsort.php
        /// </summary>
        /// <param name="nums"></param>
        internal void SelectionSort(ref int[] nums)
        {
            Console.WriteLine(string.Join(" ", nums));
            for (int i = 0;i < nums.Length-1;i++)
            {
                int min_index = i;
                for (int j = i + 1;j < nums.Length;j++)
                {
                    if (nums[j] < nums[min_index])
                    {
                        min_index = j;
                    }
                }
                (nums[min_index], nums[i]) = (nums[i], nums[min_index]);
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}
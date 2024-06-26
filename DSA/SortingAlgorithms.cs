using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        internal void BubbleSort(int[] nums)
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
        /// https://code-maze.com/csharp-selection-sort/
        /// </summary>
        /// <param name="nums"></param>
        internal void SelectionSort(int[] nums)
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

        /// <summary>
        /// https://www.w3schools.com/dsa/dsa_algo_insertionsort.php
        /// https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-6.php
        /// </summary>
        /// <param name="nums"></param>
        internal void InsertionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i + 1;j > 0; j--)
                {
                    if (nums[j-1] > nums[j])
                    {
                        (nums[j-1], nums[j]) = (nums[j], nums[j-1]);
                    }
                    Console.WriteLine(string.Join(" ", nums));
                }
            }
        }

        #region QuickSort
        /// <summary>
        /// https://www.w3schools.com/dsa/dsa_algo_quicksort.php
        /// </summary>
        /// <param name="nums"></param>
        internal void QuickSort(int[] nums, int low = 0, int? high = null)
        {
            high = high ?? nums.Length - 1;

            if (low < high)
            {
                int pivot_index = QuickSort_Partition(nums, low, high.Value);
                QuickSort(nums, low, pivot_index - 1);
                QuickSort(nums, pivot_index + 1, high.Value);
            }
        }

        private int QuickSort_Partition(int[] nums, int low, int high)
        {
            int pivot = nums[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (nums[j] <= pivot)
                {
                    i++;
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                    WriteOut(nums, i, j, high, "\tF");
                }
            }
            (nums[i + 1], nums[high]) = (nums[high], nums[i + 1]);
            WriteOut(nums, i + 1, high, null, "\tOUT");


            return i + 1;
        }

        private void WriteOut(int[] nums, int index1, int index2, int? pivot = null, string text = "")
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == index1 || i == index2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (pivot == i)
                    Console.ForegroundColor = ConsoleColor.Blue;
                else Console.ForegroundColor = ConsoleColor.White;

                Console.Write(nums[i] + " ");
            }
            Console.WriteLine(text);
        }
        #endregion

        /// <summary>
        /// The counting sort algorithm sorts an array by counting the number of times
        /// each value occurs.
        /// https://www.w3schools.com/dsa/dsa_algo_countingsort.php
        /// https://code-maze.com/counting-sort-in-c/
        /// </summary>
        /// <param name="nums"></param>
        internal void CountingSort(int[] nums)
        {
            int max_val = nums.Max();
            var occurrences = new int[max_val + 1];

            for (int i = 0; i < max_val + 1; i++)
            {
                occurrences[i] = 0;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                occurrences[nums[i]]++;
            }

            for (int i = 0, j = 0; i <= max_val; i++)
            {
                while (occurrences[i] > 0)
                {
                    nums[j] = i;
                    j++;
                    occurrences[i]--;
                    Console.WriteLine(string.Join(" ", nums));
                }
            }
        }


        /// <summary>
        /// Radix Sort algorithm sorts an array by individual digits,
        /// starting with the least significant digit (the rightmost one).
        /// https://www.w3schools.com/dsa/dsa_algo_radixsort.php
        /// https://code-maze.com/csharp-radix-sort/
        /// </summary>
        /// <param name="nums"></param>
        internal void RadixSort(int[] nums)
        {
            int maxVal = nums.Max();
            Console.WriteLine(string.Join(" ", nums));

            for (int exponent = 1; maxVal / exponent > 0; exponent *= 10)
            {
                var outputArr = new int[nums.Length];
                var occurences = new int[10];

                for (int i = 0; i < 10; i++)
                    occurences[i] = 0;

                for (int i = 0; i < nums.Length; i++)
                    occurences[(nums[i] / exponent) % 10]++;

                for (int i = 1; i < 10; i++)
                    occurences[i] += occurences[i - 1];

                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    outputArr[occurences[(nums[i] / exponent) % 10] - 1] = nums[i];
                    occurences[(nums[i] / exponent) % 10]--;
                }
                for (int i = 0; i < nums.Length; i++)
                    nums[i] = outputArr[i];
                Console.WriteLine(string.Join(" ", nums));
            }
        }

        #region Merge Sort
        /// <summary>
        /// The Merge Sort algorithm is a devide-and-conquer algirthm that sorts an array by
        /// first breaking it down into smaller arrays, and then building the array back
        /// together the correct way so that it is sorted.
        /// https://www.w3schools.com/dsa/dsa_algo_mergesort.php
        /// </summary>
        /// <param name="nums"></param>
        internal int[] MergeSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergeSort(nums, left, middle);
                MergeSort(nums, middle + 1, right);

                Merge(nums, left, middle, right);
            }

            Console.WriteLine(string.Join(" ", nums));
            return nums;
        }

        private void Merge(int[] nums, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;

            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];

            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = nums[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = nums[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    nums[k++] = leftTempArray[i++];
                }
                else
                {
                    nums[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                nums[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                nums[k++] = rightTempArray[j++];
            }
        }
        #endregion

        /// <summary>
        /// The Linear Search algorith searches through an array and returns the index 
        /// of the value it searches for.
        /// https://www.w3schools.com/dsa/dsa_algo_linearsearch.php
        /// </summary>
        /// <param name="nums"></param>
        public int LinearSearch(int[] nums, int searchedValue)
        {
            int i = -1;

            while (i < nums.Length) 
            {
                i++;
                if (nums[i] == searchedValue)
                    return i;
            }
            return i;
        }

        /// <summary>
        /// The Binary Search algorithm searches through an array
        /// and returns the index of the value it searches for.
        /// Requies a sorted array to work.
        /// https://www.w3schools.com/dsa/dsa_algo_binarysearch.php
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="searchedValue"></param>
        public int BinarySearch(int[] nums, int searchedValue)
        {
            int left = 0, right = nums.Length-1;

            while (left <= right) 
            {
                int mid = (left+right)/2;

                if (nums[mid] == searchedValue)
                    return mid;
                if (nums[mid] < searchedValue)
                    left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
    }
}

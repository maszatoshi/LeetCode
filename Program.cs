﻿using LeetCode;
using LeetCode.DSA;

#region Fibonacchi
Console.WriteLine("Fibonacchi FOR");
Fibonacchi.FibonachiFor();

Console.WriteLine("\nFibonacchi RECURSION");
Fibonacchi.FibonacchiRecursion();
Console.WriteLine();

Console.WriteLine("\nFibonacchi nth RECURSION");
Console.WriteLine(Fibonacchi.F(19));
#endregion


#region Sort Algoritms



int[] nums = [64, 34, 25, 12, 22, 11, 90, 5];
void SetNums()
{
    nums = [64, 34, 25, 12, 22, 11, 90, 5];
}

SortingAlgorithms sortingAlgorithms = new();

Console.WriteLine("\nBubble Sort");
sortingAlgorithms.BubbleSort(nums);

Console.WriteLine("\nSelection Sort");
SetNums();
sortingAlgorithms.SelectionSort(nums);

Console.WriteLine("\nInsertion Sort");
SetNums();
sortingAlgorithms.InsertionSort(nums);

Console.WriteLine("\nQuick Sort");
SetNums();
Console.WriteLine(string.Join(" ", nums));
sortingAlgorithms.QuickSort(nums);

Console.WriteLine("\nCounting Sort");
nums = [0, 2, 1, 0, 1, 2, 0, 1, 1, 2];
sortingAlgorithms.CountingSort(nums);

Console.WriteLine("\nRadix Sort");
nums = [170, 45, 75, 90, 802, 24, 2, 66];
sortingAlgorithms.RadixSort(nums);

Console.WriteLine("\nMerge Sort");
SetNums();
sortingAlgorithms.MergeSort(nums, 0, nums.Length-1);

Console.WriteLine("\nLinear Search");
SetNums();
Console.WriteLine(string.Join(" ", nums));
Console.WriteLine($"searchedValue: 22");
int linearIndex = sortingAlgorithms.LinearSearch(nums, 22);
Console.WriteLine(linearIndex);

Console.WriteLine("\nBinary Search");
nums = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19];
Console.WriteLine(string.Join(" ", nums));
Console.WriteLine($"searchedValue: 13");
int binaryIndex = sortingAlgorithms.BinarySearch(nums, 13);
Console.WriteLine(binaryIndex);
#endregion

#region Linked List
Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine("\nSingly Linked List");
LinkedLists linkedLists = new ();
linkedLists.SinglyLinkedList();

Console.WriteLine("\nDoubly Linked List");
linkedLists.DoublyLinkedList();

Console.WriteLine("\nCircular Singly Linked List");
linkedLists.CircularSinglyLinkedList();

Console.WriteLine("\nCircular Doubly Linked List");
linkedLists.CircularDoublyLinkedList();

Console.ForegroundColor = ConsoleColor.White;
#endregion


Console.WriteLine("\n88. MergeSortedArray");
MergeSortedArray_88.MergeSortedArray();




#region 26. Remove Duplicates from sorted array
// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/?envType=study-plan-v2&envId=top-interview-150
nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
Console.WriteLine("\n26. Remove Duplicates from sorted array");
int k = RemoveDuplicatesFromSortedArray_26.RemoveDuplicate3(ref nums);
Console.WriteLine($"{k} / [{string.Join(", ", nums)}]");
#endregion





#region 80. Remove Duplicates from sorted array II
// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/description/?envType=study-plan-v2&envId=top-interview-150
nums = [0, 0, 1, 1, 1, 1, 2, 3, 3];
nums = [1, 1, 1, 2, 2, 3];
Console.WriteLine("\n80. Remove Duplicates from sorted array II");
k = RemoveDuplicatesFromSortedArrayII_80.RemoveDuplicates(ref nums);
Console.WriteLine($"{k} / [{string.Join(", ", nums)}]");
#endregion



#region 169. Majority Element
// https://leetcode.com/problems/majority-element/description/?envType=study-plan-v2&envId=top-interview-150
nums = [2, 2, 1, 1, 1, 2, 2];
Console.WriteLine("\n 169. Majority Element");
k = MajorityElement_169.MajorityElement(ref nums);
Console.WriteLine(k);
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class MergeSortedArray_88
    {
        private static int[] nums1 = [1, 2, 3, 0, 0, 0];
        private static int[] nums2 = [2, 5, 6];
        private static int m = 3;
        private static int n = 3;

        internal static void MergeSortedArray()
        {
            Array.Copy(nums2, 0, nums1, m, n);
            Array.Sort(nums1);
            foreach (int i in nums1) Console.WriteLine(i);
        }

        
    }
}

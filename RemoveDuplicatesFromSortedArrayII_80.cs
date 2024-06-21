using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class RemoveDuplicatesFromSortedArrayII_80
    {
        internal static int RemoveDuplicates(ref int[] nums)
        {
            int k = 0;

            for (int n = 0; n < nums.Length-1; n++)
            {
                if (n != 0 && nums[n] == nums[n-1]) continue;

                int occurence = 0;
                for (int i = 0; i < nums.Length; i++) 
                {
                    if (nums[i] == nums[n]) occurence++;
                }
                if (occurence > 2)
                {
                    for (int i = n+2;  i < nums.Length-occurence+2; i++)
                    {
                        nums[i] = nums[i+occurence-2];
                    }
                    k += 2;
                }
                else k+= occurence;
            }


            return k;
        }
    }
}

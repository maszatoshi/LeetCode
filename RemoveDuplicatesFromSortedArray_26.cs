using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class RemoveDuplicatesFromSortedArray_26
    {

        internal static int RemoveDuplicate(ref int[] nums)
        {
            int k = 0;

            if (nums.Length > 0) 
            {
                k = 1;
                for (int i = 0, j = 1; i <= nums.Length && j <= nums.Length - 1; i++, j++)
                {
                    if (nums[i] != nums[j])
                    {
                        k++;
                    }  
                }
                nums = nums.Distinct().ToArray();
            }
            

            return k;
        }

        internal static int RemoveDuplicate2(ref int[] nums)
        {
            int k = 0;

            if (nums.Length > 0)
            {
                k = 1;
                for (int i = 0, j = 1; i <= nums.Length && j <= nums.Length - 1; i++, j++)
                {
                    if (nums[i] != nums[j])
                    {
                        k++;
                    }
                }
                nums = new HashSet<int>(nums).ToArray();
            }


            return k;
        }

        internal static int RemoveDuplicate3(ref int[] nums)
        {
            int k = 0;

            if (nums.Length > 0)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[k] != nums[i])
                    {
                        nums[++k] = nums[i];
                    }
                }
            }


            return k + 1;
        }
    }
}

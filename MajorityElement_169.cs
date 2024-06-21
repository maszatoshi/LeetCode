using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class MajorityElement_169
    {
        internal static int MajorityElement(ref int[] num)
        {
            int result = 0;
            int currentNumber = 0;
            int mostOccurence = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == currentNumber) continue;
                else currentNumber = num[i];
                int occurence = 0;
                for (int j = 0; j < num.Length; j++) 
                { 
                    if (num[i] == num[j]) occurence++;
                }
                if (occurence > mostOccurence)
                {
                    mostOccurence = occurence;
                    result = currentNumber;
                }
                    
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DSA
{
    internal static class Fibonacchi
    {
        internal static void FibonachiFor()
        {
            List<int> list = new List<int>() { 0, 1 };
            for (int i = 1; i <= 18; i++)
            {
                list.Add(list[i] + list[i - 1]);
            }
            Console.WriteLine(string.Join(" ", list));
        }

        private static int recusrion = 2;

        internal static void FibonacchiRecursion(int? a = null, int? b = null)
        {
            if (a == null && b == null)
            {
                a = 0; b = 1;
                Console.Write($"{a} ");
                Console.Write($"{b} ");
            }

            if (recusrion <= 19)
            {
                recusrion++;
                int c = a.Value + b.Value;
                Console.Write($"{c} ");
                FibonacchiRecursion(b, c);
            }
        }

        internal static int F(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return F(n - 1) + F(n - 2);
            }
        }
    }
}

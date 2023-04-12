using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddArrayApp.Model
{
    internal class OddEven
    {
        public int[] GetEven(int n)
        {
            int[] evenNumbers = new int[n / 2];
            int j = 0;
            for (int i = 2; i <= n; i += 2)
            {
                evenNumbers[j] = i;
                j++;
            }
            return evenNumbers;
        }

        public int[] GetOdd(int n)
        {
            int[] oddNumbers = new int[(n + 1) / 2];
            int j = 0;
            for (int i = 1; i <= n; i += 2)
            {
                oddNumbers[j] = i;
                j++;
            }
            return oddNumbers;
        }

        public int[] GetEven(int start, int end)
        {
            int range = end - start + 1;
            int[] evenNumbers = new int[range / 2];
            int j = 0;
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[j] = i;
                    j++;
                }
            }
            return evenNumbers;
        }
        public int[] GetOdd(int start, int end)
        {
            int range = end - start + 1;
            int[] oddNumbers = new int[(range + 1) / 2];
            int j = 0;
            for (int i = start; i <= end && j < oddNumbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers[j] = i;
                    j++;
                }
            }
            return oddNumbers;
        }
    }
}

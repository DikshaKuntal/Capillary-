using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleApplication
{
    public class SumCloseToZero
    {
        public static void GetSumCloseToZero()
        {
            SumCloseToZero obj = new SumCloseToZero();
            int[] Arr = new int[] { 1, 50, -15, 71, -80, 81 };
            Console.WriteLine("\nInput Array : ");
            for (int i = 0;i < Arr.Length; i++)
            {
                Console.Write((i == 0 ? "" : ",") + Arr[i]);
            }

            if (Arr.Length < 2)
                Console.WriteLine("\nInvalid data");
            else
                obj.GetLeastSumNumbers(Arr);
        }

        private void GetLeastSumNumbers(int[] A)
        {
            //SumCloseToZero
            int lIndex, rIndex, minLeft, minRight;
            Array.Sort(A);
            lIndex = minLeft = 0; rIndex = minRight = A.Length - 1;
            int leastSum = A[lIndex] + A[rIndex];
            while (lIndex < rIndex)
            {
                if (Math.Abs(A[lIndex] + A[rIndex]) < Math.Abs(leastSum))
                {
                    leastSum = A[lIndex] + A[rIndex];
                    minLeft = lIndex;
                    minRight = rIndex;
                }
                if (leastSum < 0)
                    lIndex++;
                else
                    rIndex--;
            }
            Console.WriteLine("\nOutput : " + A[minLeft] + " & " + A[minRight]);
            Console.WriteLine("Time Complexity - O(nlogn), Space Complexity - O(1)\n");
        }
    }
}

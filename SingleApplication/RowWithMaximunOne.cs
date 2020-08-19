using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleApplication
{
    public class RowWithMaximunOne
    {
        public static void GetRowWithMaxOne()
        {
            RowWithMaximunOne obj = new RowWithMaximunOne();
            int[][] rows = new int[4][];
            rows[0] = new int[] { 0, 1, 1, 0, 1 };
            rows[1] = new int[] { 1, 1, 1, 1, 0 };
            rows[2] = new int[] { 0, 0, 1, 0, 0 };
            rows[3] = new int[] { 1, 1, 1, 1, 1 };
            Console.WriteLine("\nInput : ");
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[i].Length; j++)
                {
                    Console.Write((j == 0 ? "\n" : " ") + rows[i][j]);
                }
            }
            obj.GetRow(rows);

        }

        private void GetRow(int[][] rows)
        {
            int noOfOne = 0, maxOneRowIndex = 0;
            for(int i=0;i<rows.Length;i++)
            {
                int noOfOneInRow = 0;
                noOfOneInRow = rows[i].Where(x => x == 1).Count();                                    
                if (noOfOne < noOfOneInRow)
                {
                    noOfOne = noOfOneInRow;
                    maxOneRowIndex = i+1;
                }
            }

            Console.WriteLine("\nOutput : " + maxOneRowIndex);
            Console.WriteLine("Time Complexity - O(n)\n");
        }
    }
}

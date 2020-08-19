using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Select \n1. Sum close to zero in an array\n2. Get row with maximum number of 1 \n3. Reverse linked list \n4. Length of longest valid substring ");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        SumCloseToZero.GetSumCloseToZero();
                        break;
                    case 2:
                        RowWithMaximunOne.GetRowWithMaxOne();
                        break;
                    case 3:
                        ReverseList.ReverseLinkList();
                        break;
                    case 4:
                        LongestSubstring.GetLongestSubstring();
                        break;
                    default:
                        Console.WriteLine("Wrong Input.");
                        break;
                }
                Console.WriteLine("\n\nDo you want to continue?(Y/N)");
            }
            while (Console.ReadLine().ToUpper() == "Y");
        }
    }
}

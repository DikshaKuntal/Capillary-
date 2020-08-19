using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleApplication
{
    public class LongestSubstring
    {
        public static void GetLongestSubstring()
        {
            string str = "()(()))))";           
            Console.WriteLine("\nInput : {0}",str);

            int count = 0, longestCount = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                    count++;
                if(count > 0 && str[i] == ')')
                {
                    count--;
                    longestCount += 2;
                }
            }

            Console.WriteLine("\nOutput : {0}", longestCount);
            Console.WriteLine("\nTime Complexity - O(n)\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleApplication
{
    public class ReverseList
    {
        public static void ReverseLinkList()
        {
            //2->3->1->5 > 4
            LinkedList<int> lst = new LinkedList<int>();
            LinkedList<int> finalLst = new LinkedList<int>();

            lst.AddLast(2);
            lst.AddLast(3);
            lst.AddLast(1);
            lst.AddLast(5);
            lst.AddLast(4);            
            Console.WriteLine("\nInput : ");
            foreach (int n in lst)
            {
                Console.Write((Convert.ToInt32(lst.First()) == n ? "" : " -> ") + n);
            }

            for (int i = lst.Count-1; i >= 0; i--)
            {
                finalLst.AddLast(lst.ElementAt(i));
            }
            
            Console.WriteLine("\nOutput : ");
            foreach (int n in finalLst)
            {
                Console.Write((Convert.ToInt32(finalLst.First()) == n ? "" : " -> ") + n);
            }
            Console.WriteLine("\nTime Complexity - O(n), Space Complexity - O(n)\n");
        }
    }
}

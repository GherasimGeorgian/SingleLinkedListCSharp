using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class Program
    {
        public static bool relatie1(int a, int b)
        {
            //ordine crescatoare
            if (a <= b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool delRel(int a, int b)
        {

            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
        static void Main(string[] args)
        {

            Relation<int>.Rel rel = relatie1;
            Relation<int>.DelRel delrel = delRel;
            SingleLinkedList<int> sll = new SingleLinkedList<int>(rel,delrel);
           

            Iterator<int> it = new Iterator<int>(sll);
            Console.WriteLine("Valid: " + it.valid());
            sll.Insert(1);
            sll.Insert(2);
            sll.Insert(3);
            sll.Insert(4);
            sll.Insert(5);
            sll.Insert(6);
            sll.Insert(7);
            
            sll.DeleteNodebyElemnt(4);
            sll.show();
            // Console.WriteLine(sll.size());
        }
       
    }
}

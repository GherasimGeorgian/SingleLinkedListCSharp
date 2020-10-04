using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class Relation<T>
    {
        public delegate bool Rel(T e1, T e2);

        public delegate bool DelRel(T e1, T e2);
    }
}

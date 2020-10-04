using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{

    internal class Node<T>
    {

        public T data;
        
        internal Node<T> next;
        public Node(T d)
        {
            data = d;
            next = null;
        }

       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    internal class Iterator<T>
    {
        SingleLinkedList<T> _singleLinkedList;
        int position = 0;
        public Iterator(SingleLinkedList<T> singleLinkedList)
        {
            _singleLinkedList = singleLinkedList;
        }

        internal void prim()
        {
            this.position = 0;
        }
        internal void urmator()
        {
            this.position++;
        }
        internal bool valid()
        {
            if (this.position == this._singleLinkedList.size())
            {
                return false;
            }
            else return true;
        }
        internal T element()
        {
            return this._singleLinkedList.element(position);
        }
    }
}

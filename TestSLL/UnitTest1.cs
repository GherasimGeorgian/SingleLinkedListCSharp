using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingleLinkedList;

namespace TestSLL
{
    [TestClass]
    public class UnitTest1
    {

        public static bool relatie1(TElement a, TElement b)
        {
            //ordine crescatoare
            if (a.id <= b.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool delRel(TElement a, TElement b)
        {
          
            if (a.id == b.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [TestMethod]
        public void TestMethod1()
        {

            Relation<TElement>.Rel rel = relatie1;
            Relation<TElement>.DelRel delrel = delRel;
            SingleLinkedList<TElement> sll = new SingleLinkedList<TElement>(rel, delrel);
            Assert.AreEqual(sll.size(),0);
            Assert.IsTrue(sll.vida());
            TElement elem1 = new TElement(1, "maria");
            sll.Insert(elem1);
            TElement elem2 = new TElement(3, "ion");
            sll.Insert(elem2);
            TElement elem3 = new TElement(2, "geo");
            sll.Insert(elem3);
            TElement elem4 = new TElement(4, "tata");
            sll.Insert(elem4);
            TElement elem5 = new TElement(5, "mama");
            sll.Insert(elem5);
            Assert.AreEqual(sll.size(),5);
            Assert.IsFalse(sll.vida());


            Iterator<TElement> it = new Iterator<TElement>(sll);
            Assert.IsTrue(it.valid());
            it.prim();
            Assert.AreEqual(it.element().name,"maria");
            Assert.AreEqual(it.element().id, 1);
            it.urmator();
            Assert.AreEqual(it.element().name, "geo");
            Assert.AreEqual(it.element().id, 2);

            sll.DeleteNodebyElemnt(elem3);

            Assert.AreEqual(sll.size(), 4);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestSLL")]
namespace SingleLinkedList
{
    public class SingleLinkedList<T>
    {
       
        public Relation<T>.Rel rel;
        public Relation<T>.DelRel delrel;

        internal Node<T> head;

        public SingleLinkedList(Relation<T>.Rel r, Relation<T>.DelRel dl){
            rel = r;
            delrel = dl;
        }


        /// <summary>
        /// Se adauga elementul in capul listei
        /// </summary>
        /// <param name="new_data">elementul ce trebuie adaugat</param>
        internal void InsertFront(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            new_node.next = this.head;
            this.head = new_node;
        }


        /// <summary>
        /// adauga element in lista ordonata, se pastreaza ordinea intre elemente
        /// </summary>
        /// <param name="e">elementul ce trebuie adaugat</param>
        internal void Insert(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            Node<T> current;
            // daca capul listei este gol sau relatie(functie) nu se satisface atunci capul listei devine new_node
            if (this.head == null || !rel(this.head.data, new_node.data))
            {
                new_node.next = this.head;
                this.head = new_node;
            }
            else
            {
                //  daca relatia se satisface trecem la urmatorul element si tot asa pana cand nu se mai satisface sau ajungem la sfarsit
                // verificam daca elementele repsecta relatia de ordine
                current = head;
                while (current.next != null && rel(current.next.data, new_node.data)) {
                    current = current.next;
                }
                new_node.next = current.next;
                current.next = new_node;
            }
        }
        internal void show()
        {
           
            Node<T> currentNode = this.head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
           
        }

        /// <summary>
        /// Functia returneaza dimensiune listei
        /// </summary>
        /// <returns>dimensiunea listei</returns>
        internal int size()
        {
            int s = 0;
            Node<T> currentNode = this.head;
            while (currentNode != null) {
                s += 1;
                currentNode = currentNode.next;
            }
            return s;
        }
        /// <summary>
        /// Functia returneaza al i-lea element
        /// </summary>
        /// <param name="i">Pozitia elementului pe care dorim sa-l extragem</param>
        /// <returns>Elementul i din lista</returns>
        internal T element(int i)
        {
            if (i < 0 || i >= this.size() || vida() == true)
            {
                throw new Exception("Elementul nu este valid!");
            }
            Node<T> current = this.head;
            while (i != 0)
            {
                current = current.next;
                --i;
            }
            return current.data;

        }
        internal bool vida()
        {
            return this.head == null;
        }

        internal void DeleteNodebyElemnt(T elem)
        {
            Node<T> temp = this.head;
            Node<T> prev = null;
            //cazul in care elementul pe care dorim sa-l stergem este capul listei
            if (temp != null && (delrel(temp.data,elem)))
            {
                this.head = temp.next;
                return;
            }
          
            while (temp != null && !(delrel(temp.data, elem)))//&& rel(temp.data,elem.data)
            {
                
                prev = temp;
                temp = temp.next;
            }
            
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }
    }


}

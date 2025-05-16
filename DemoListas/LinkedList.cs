using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListas
{
     class LinkedList
    {
        private Node first;
        private Node last;

        public LinkedList() { 
            this.first = this.last= null;
            
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        //Devuelve el nodo que se encuentra en un determinado indice
        public Node FindAt(int index)
        {
            int currentIndex = 0;
            Node current = first;
            while (current != null)
            {
                if (currentIndex == index) return current;
                currentIndex++;
                current = current.Next;
            }
            return null; 

        }

        //Agrega un nuevo nodo al final de la lista
        public void Add(int value)
        {
            Node aux=new Node(value);
            if (IsEmpty()) 
            {
                first = last = aux;
                    return;
            }
            //Si la lista no esta vacia
            last.Next = aux;
            last = aux;
        }

        public void AddToStart(int value)
        {
            Node aux = new Node(value);
            if (IsEmpty())
            {
                first = last = aux;
                return;
            }
            //Si la lista no esta vacia
            aux.Next=first;
            first = aux;
            
        }

        public void InsertAt(int value, int pos)
        {
            Node aux = new Node(value);
            if (IsEmpty())
            {
                first = last = aux;
                return;
            }
            if (pos <= 0)
            {
                AddToStart(value);
                return;
            }

            //Si la lista no esta vacia
            Node n1 = FindAt(pos - 1);
            if (n1 == null)
            {
                Add(value);// Insertando al final de la lista
                return;
            }
            Node n2 = n1.Next;
            aux.Next = n2;
            n1.Next = aux;

        }
        // devuelve el indice de la primera ocurrencia de value en la lista
        public int Find(int value)
        {
            if (IsEmpty())
            {
                return -1;
            }
            Node current = first;
            int index = 0;
            while (true)
            {
                if (current.Data == value) return index;
                current = current.Next;
                index++;
                if (current == null) break;//Cuando ya no hayan mas nodos
            }
            return -1;
        }

        public int Length()
        {
            if (IsEmpty()) return 0;
            int counter = 0;
            Node current = first;
            while (true)
            {
                counter++;
                current = current.Next;
                if (current == null) break;
            }
            return counter;
        }

        public void DeleteFirst()
        {
            if (IsEmpty()) return;
            Node aux = first;
            first=first.Next;
            aux.Next = null;
            
        }

        public void DeleteLast()
        {
            if (IsEmpty()) return;
            if (Length() == 1)
            {
                DeleteFirst();
                return;
            }
            Node aux = last;
            last = FindAt(Length() - 2);
            last.Next = null;
        }

        public void DeleteAt(int pos)
        {
            if (IsEmpty()) return;
            if (pos < 0 || pos >= Length()) return;
            if (pos == 0)
            {
                DeleteFirst();
                return;
            }

            Node aux = FindAt(pos);
            Node nxt = aux.Next;
            Node prev = FindAt(pos - 1);
            prev.Next = nxt;
            aux.Next = null;

        }


        public void Show()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }
            Node current = first;
            while (true)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
                if(current==null) break;//Cuando ya no hayan mas nodos
            }
        }
    }
}

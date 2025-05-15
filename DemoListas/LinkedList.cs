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
            //Si la lista no esta vacia
            Node n1 = FindAt(pos - 1);
            Node n2 = n1.Next;
            aux.Next = n2;
            n1.Next = aux;

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

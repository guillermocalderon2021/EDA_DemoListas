using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.AddToStart(1);
            myList.InsertAt(2, 0);
            myList.InsertAt(100, 100);
            myList.DeleteFirst();
            myList.Show();
            Console.WriteLine("---------------");
            Console.WriteLine(myList.Find(20));
            Console.WriteLine(myList.Find(100));
            Console.WriteLine(myList.Find(55));

            Console.ReadKey();
        }
    }
}

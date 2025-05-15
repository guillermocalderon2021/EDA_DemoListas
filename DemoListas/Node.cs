using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoListas
{
     class Node
    {

		private int data;
		public int Data
		{
			get { return data; }
			set { data = value; }
		}

		private Node next;
		public Node Next
		{
			get { return next; }
			set { next = value; }
		}

		public Node(int data)
		{
			this.data = data;
			this.next = null;
		}

	}
}

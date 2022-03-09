using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SinglyLinkedList
{
    public class Node<T>
    {
        private T data;
        private Node<T> next;

        public Node(T value)
        {
            this.data = value;
            this.next = null;
        }

        public T Value
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}

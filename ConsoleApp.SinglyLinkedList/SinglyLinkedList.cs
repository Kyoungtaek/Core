using System;

namespace ConsoleApp.SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        private Node<T> head;
        public SinglyLinkedList()
        {
            head = null;

        }
        public void Add(Node<T> node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = node;
            }
        }

        public void Remove(Node<T> node)
        {
            if (head.Equals(node))
            {
                head = head.Next;
            }

            Node<T> temp = head;
            Node<T> preNode = null;
            while (temp != null)
            {
                if (temp.Equals(node))
                {
                    preNode.Next = temp.Next;
                    return;
                }

                preNode = temp;
                temp = temp.Next;
            }
        }

        public void AddAfter(Node<T> targetNode, Node<T> newNode)
        {
            Node<T> temp = head;

            while (temp != null)
            {
                if (temp.Equals(targetNode))
                {
                    newNode.Next = temp.Next;
                    temp.Next = newNode;

                    return;
                }

                temp = temp.Next;
            }
        }

        public T GetNode(int nodeNumber)
        {
            Node<T> temp = head;
            int count = 1;
            while (temp!=null)
            {
                if (count == nodeNumber)
                {
                    return temp.Value;
                }
                count++;
            }

            throw new IndexOutOfRangeException();
        }

        public int Count()
        {
            Node<T> temp = head;
            int count = 0;

            while (temp != null)
            {
                temp = temp.Next;
                count++;
            }

            return count;
        }

        public Node<T> FindFirst(T input)
        {
            Node<T> temp = head;

            while (temp != null)
            {
                if (temp.Value.Equals(input))
                {
                    return temp;
                }

                temp = temp.Next;
            }

            return null;
        }
    }
}

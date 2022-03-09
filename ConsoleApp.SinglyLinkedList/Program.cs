using System;

namespace ConsoleApp.SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SinglyLinkedList<string>();

            // Create Node and add to head
            var node = new Node<string>("Apple");
            list.Add(node);

            // node 2
            node = new Node<string>("Banana");
            list.Add(node);

            // node 3
            node = new Node<string>("Lemon");
            list.Add(node);

            // node 4
            node = new Node<string>("Melon");
            list.Add(node);
            Console.WriteLine("After Add 4 nodes: {0}", list.Count());
            Console.WriteLine("====================");

            //Remove node
            node = list.FindFirst("Banana");
            list.Remove(node);
            Console.WriteLine("After Remove(node): {0}", list.Count());

            // Add after
            node = list.FindFirst("Lemon");
            var newNode = new Node<string>("Grape");
            list.AddAfter(node, newNode);
            Console.WriteLine("After AddAfter(node, newNode): {0}", list.Count());
            Console.WriteLine("====================");

            // GetNode
            try
            {
                Console.WriteLine($"GetNode: Index(3) , {list.GetNode(3)}");
                Console.WriteLine($"GetNode: Index(11) , {list.GetNode(11)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

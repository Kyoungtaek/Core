using System;

namespace ConsoleApp.DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var da = new MyDynamicArray();
            Console.WriteLine("Initialization");
            Console.WriteLine("Count:{0}, Capacity:{1}", da.Count, da.Capacity);
            Console.WriteLine();

            Console.WriteLine("Add 1 items");
            da.Add(1); 
            Console.WriteLine("Count:{0}, Capacity:{1}", da.Count, da.Capacity);
            Console.WriteLine();

            Console.WriteLine("Add 2 more items");
            da.Add(2); da.Add(3);
            Console.WriteLine("Count:{0}, Capacity:{1}", da.Count, da.Capacity);
            Console.WriteLine();

            try
            {
                Console.WriteLine("Before myArray[2]: {0}", da[2]);
                da[2] = "Test Indexer";
                Console.WriteLine("After  myArray[2]: {0}", da[2]);

                Console.WriteLine();
                Console.WriteLine("Try to Add item, out of count.");
                Console.WriteLine("Current index position: {0}, Target index: da[31]", da.Count);
                da[31] = "Indexer 31";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

            Console.WriteLine("Count:{0}, Capacity:{1}", da.Count, da.Capacity);
            Console.WriteLine();

            Console.WriteLine("Add 1 items");
            da.Add("final");
            Console.WriteLine("Count:{0}, Capacity:{1}", da.Count, da.Capacity);
        }
    }
}

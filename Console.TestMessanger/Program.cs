using System;

namespace ConsoleApp.TestMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Messenger m1 = new Messenger("Alex");
            Messenger m2 = new Messenger("John");

            m1.SendMessage(m2, "Hi John");
            m2.SendMessage(m1, "Hello Alex");
            m2.SendMessage(m1, "How are you doing?");

            string msg = m2.ReceiveMessage();
            Console.WriteLine(msg);

            msg = m1.ReceiveMessage();
            Console.WriteLine(msg);

            msg = m1.ReceiveMessage();
            Console.WriteLine(msg);
        }
    }
}

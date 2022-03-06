using System;
using System.Collections.Generic;

namespace ConsoleApp.TestMessanger
{
    public class TinyMessageCenter
    {
        static List<Message> messages = new List<Message>();

        public static void Send(string from, string to, string msg)
        {
            Message newMsg = new Message
            {
                From = from,
                To = to,
                Content = msg,
                Time = DateTime.Now,
                Read = false
            };

            messages.Add(newMsg);
        }

        public static Message Read(string @for)
        {
            foreach (var m in messages)
            {
                if (m.To == @for && m.Read == false)
                {
                    m.Read = true;
                    return m;
                }
            }
            return null;
        }
    }
}

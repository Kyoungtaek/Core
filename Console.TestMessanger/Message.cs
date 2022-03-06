using System;

namespace ConsoleApp.TestMessanger
{
    public class Message
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public bool Read { get; set; }
    }
}

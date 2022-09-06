using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    internal class Message
    {
        public string title;
        public string message;

        public Message(string title, string message)
        {
            this.title = title;
            this.message = message;
        }

        public void Display()
        {
            Console.WriteLine(title);
            Console.WriteLine(message);
        }
    }
}

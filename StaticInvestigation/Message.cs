using System;
using System.Collections.Generic;
using System.Text;

namespace StaticInvestigation
{
    class Message
    {
        public static int count = 0;

        public string Title { get; set; }
        public string Text { get; set; }

        public string[] data = new string[10000];

        public Message(string title, string text)
        {
            Title = title;
            Text = text;
            count++;
        }

        ~Message()
        {
            // this should get called when the 
            // object is destroyed
            Console.WriteLine($"Destructor called:{count}");
            count--;
        }
        public static void DisplayCount()
        {
            Console.WriteLine($"The count is {count}");
        }
    }
}

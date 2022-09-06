using System;

namespace StaticInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Static Investigation");

            Message m1 = new Message("Message 1", "this is message 1");
            Console.WriteLine(Message.count);

            Message m2 = new Message("Message 2", "this is message 2");
            Console.WriteLine(Message.count);

            Message m3 = new Message("Message 3", "this is message 3");
            Console.WriteLine(Message.count);


            Message.DisplayCount();

        }
    }
}

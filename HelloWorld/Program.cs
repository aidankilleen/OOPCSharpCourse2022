using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Message m = new Message("News Item", "something interesting");

            m.Display();




            Console.WriteLine("Hello World!");

            var x = 10; 
            var y = 100;

            if (x < 10) 
            {
                Console.WriteLine("less than 10");
            }

            int count = 1;


            while (count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }














            




        }
    }
}

using System;

namespace ArrayInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Investigation");

            string[] days = new string[]
            {
                "monday",
                "tuesday",
                "wednesday",
                "thursday",
                "friday"
            };

            for (int i=0; i<days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

            Console.WriteLine("==========================");

            foreach(string day in days)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("=========================");


            foreach(var day in days)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("========================");

            // array in C# is very limited in functionality
            //days.


            // days = days.

            // TBD - investigate the use of the collections classes.


            // initialising arrays
            int[] list = new int[]
            {
                1, 2, 3, 4, 5, 6, 7
            };


            int[] numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 10;
            numbers[2] = 7;
            numbers[3] = 9;
            numbers[4] = 3;


            //numbers[5] = 999;






















        }
    }
}

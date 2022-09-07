using System;
using System.Collections.Generic;
using System.Text;

namespace ListInvestigation
{
    class ProcessList
    {


        public static bool CheckForEven(int i)
        {
            return i % 2 == 0;
        }
        public static bool CheckForOdd(int i)
        {
            return i % 2 == 1;
        }
        public delegate bool CheckFunction(int n);

        public static void ScanList(List<int> list, CheckFunction checkFunction)
        {
            foreach (int item in list)
            {
                if (checkFunction(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Process Integer List");
            List<int> list = new List<int>
            {
                1, 4, 3, 7, 5, 9, 10, 2
            };
            ScanList(list, CheckForEven);
        }
    }
}

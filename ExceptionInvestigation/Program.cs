using System;

namespace ExceptionInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Investigation");


            int a = 100;
            int b = 0;
            int[] list = { 1, 2, 3 };
            string s = null;
            int answer = 0;

            Random randomGenerator = new Random();
            int r = randomGenerator.Next(5);

            try
            {
                switch(r)
                {
                    case 0:
                        answer = s.Length;
                        break;
                    case 1:
                        answer = list[3];
                        break;
                    case 2:
                        answer = a / b;
                        break;
                    case 3:
                        answer = 10;
                        break;
                    default:
                        throw new CustomException("Custom error");
                        break;
                }
            }
            catch(CustomException ex)
            {
                Console.WriteLine("Custom Exception");
                answer = 99;
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range");
                answer = list[0];
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Null reference");
                answer = -1;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Other Exception:" + ex.Message);
                answer = -2;
            }
            finally
            {
                // no matter what happens this will be run
                Console.WriteLine($"The answer is { answer }");
            }

            
            Console.WriteLine("finished");
        }
    }
}

using System;

namespace PlayingCardProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Playing Card Example");

            Card c;

            for (int suit=1; suit <= 4; suit++)
            {
                for (int value=1; value<=13; value++)
                {
                    c = new Card((Suit)suit, value);
                    c.Display();
                }
                Console.WriteLine();
            }

            Card cbad = new Card((Suit)99, 99);
            cbad.Display();

        }
    }
}

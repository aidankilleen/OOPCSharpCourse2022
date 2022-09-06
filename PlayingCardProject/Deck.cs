using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardProject
{
    class Deck
    {
        // member variable(s)
        public Card[] cards = new Card[52];

        public int CurrentCard { get; set; } = 0;

        // member functions (methods)

        // constructor
        public Deck()
        {
            int count = 0;
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards[count++] = new Card((Suit)suit, value);
                }
            }
        }

        public Card Deal()
        {
            return cards[CurrentCard++];
        }

        public void Display()
        {
            for (int i=0; i<cards.Length; i++)
            {
                cards[i].Display();

                if (i == 12 || i == 25 || i == 38)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public void Shuffle(int count)
        {
            Random randomGenerator = new Random();

            for (int i = 0; i < count; i++)
            {

                int r1 = randomGenerator.Next(52);
                int r2 = randomGenerator.Next(52);

                // swap the cards at locations r1 & r2
                Card temp = cards[r1];
                cards[r1] = cards[r2];
                cards[r2] = temp;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Deck Test");
            Deck d = new Deck();

            d.Display();
            Console.WriteLine();

            d.Shuffle(1);
            d.Display();
            Console.WriteLine();

            d.Shuffle(10);
            d.Display();
            Console.WriteLine();

            d.Shuffle(100);
            d.Display();
            Console.WriteLine();

            d.Shuffle(100000000);
            d.Display();
            Console.WriteLine();
















        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardProject
{
    class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Card Game");

            Deck deck = new Deck();

            deck.Shuffle(500);

            Card nextCard = deck.Deal();

            nextCard.Display();

            nextCard = deck.Deal();

            nextCard.Display();
        }
    }
}

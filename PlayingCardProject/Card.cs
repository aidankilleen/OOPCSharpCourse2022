using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardProject
{
    enum Suit
    {
        Heart = 1, 
        Spade, 
        Diamond,
        Club
    }

    class Card
    {
        // member variables (fields)
        private Suit _suit;    // Hearts =1, Spades=2, Diamonds=3, Clubs=4 
        private int _value;  // Ace = 1, 2, 3, ..., 10, Jack = 11, Queen =12, King =13

        // properties
        public int Value { 
            get {
                return _value;
            } 
            set { 
                if (value < 1 || value > 13)
                {
                    //Console.WriteLine("ERROR: invalid value");
                    throw new ArgumentOutOfRangeException("ERROR: invalid value");
                } else
                {
                    _value = value;
                }
            } 
        }

        public Suit Suit
        {
            get
            {
                return _suit;
            }
            set
            {
                if (value < Suit.Heart || value > Suit.Club)
                {
                    // Console.WriteLine("ERROR: Invalid suit");
                    throw new ArgumentOutOfRangeException("Error: invalid suit");
                } else
                {
                    _suit = value;
                }
            }
        }

        // constructor
        public Card(Suit suit, int value)
        {
            Suit = suit;
            Value = value;
        }
        // other functions
        // Display
        public void Display()
        {
            string card = "";

            switch (_value)
            {
                case 1:
                    card += " A";
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    card += " " + _value;
                    break;
                case 10:
                    card += _value;
                    break;
                case 11:
                    card += " J";
                    break;
                case 12:
                    card += " Q";
                    break;
                case 13:
                    card += " K";
                    break;
                default:
                    card += " ?";
                    break;
            }
        
            if (_suit == Suit.Heart)
            {
                card += "H ";
            } else if (_suit == Suit.Spade)
            {
                card += "S ";
            } else if (_suit == Suit.Diamond)
            {
                card += "D ";
            } else if (_suit == Suit.Club)
            {
                card += "C ";
            } else
            {
                card += "? ";
            }
            Console.Write( card );
        }
    }
}

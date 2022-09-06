using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardProject
{
    class Validation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Invalid Values");

            Card c = new Card(Suit.Heart, 1);

            
            
            try
            {
                c.Suit = (Suit)999;
                c.Value = 999;

            } catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("invalid value");
            }



            c.Display();


            Card c2;
            
            try
            {
                c2 = new Card((Suit)999, 999);
                c2.Display();

            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("invalid card");
            }

        }
    }
}

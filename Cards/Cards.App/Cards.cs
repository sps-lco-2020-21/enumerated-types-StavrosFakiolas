using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cards.App
{
    
    public class Card 
    {
        public enum Value
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }


        [Flags]
        public enum Suit
        {
            Spades = 1,
            Clubs = 2,
            Diamonds = 4,
            Hearts = 8,

            Red = Diamonds | Hearts,
            Black = Spades | Clubs
        }

        Suit suit;
        Value value;

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }

        public override string ToString()
        {
            return suit.ToString() + " " + value.ToString();
        }
    }
}


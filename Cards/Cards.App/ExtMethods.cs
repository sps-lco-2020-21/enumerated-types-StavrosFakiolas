using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace Cards.App
{
    public static class ExtMethods
    {
        public static int MaxRunLength(this List<Card.Value> list)
        {
            //nested for loop - is there a run starting at this number, second loop for counting run length

            Card.Value current = Card.Value.Ace;
            int largestRun = 1;

            for (; (int)current < 15; ++current) //up to 15 because Ace can be counted as high or low?
            {
                int counter = 1;
                
                while(list.Contains(current+1))
                {
                    ++counter;
                    ++current;
                }

                if (counter > largestRun)
                {
                    largestRun = counter;
                }
                
            }

            return largestRun;
        }

        public static Card ToCard(this string str)
        {
            char number = str[0];
            char type = str[1];

            Card.Value val = Card.Value.Ace;
            Card.Suit race = Card.Suit.Spades; //Default is Ace of Spades

            if (type == 'S')
            {
                race = Card.Suit.Spades;
            }
            else if (type == 'C')
            {
                race = Card.Suit.Clubs;
            }
            else if (type == 'D')
            {
                race = Card.Suit.Diamonds;
            }
            else if (type == 'H')
            {
                race = Card.Suit.Hearts;
            }

            if (number == 'T')
            {
                val = Card.Value.Ten;
            }
            else if (number == 'J')
            {
                val = Card.Value.Jack;
            }
            else if (number == 'Q')
            {
                val = Card.Value.Queen;
            }
            else if (number == 'K')
            {
                val = Card.Value.King;
            }
            else
            {
                switch (int.Parse(number.ToString()))
                {
                    case 1:
                        val = Card.Value.Ace;
                        break;
                    case 2:
                        val = Card.Value.Two;
                        break;
                    case 3:
                        val = Card.Value.Three;
                        break;
                    case 4:
                        val = Card.Value.Four;
                        break;
                    case 5:
                        val = Card.Value.Five;
                        break;
                    case 6:
                        val = Card.Value.Six;
                        break;
                    case 7:
                        val = Card.Value.Seven;
                        break;
                    case 8:
                        val = Card.Value.Eight;
                        break;
                    case 9:
                        val = Card.Value.Nine;
                        break;
                }
            }

            Card yourCard = new Card(race, val);
            return yourCard;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.App
{
    class Program
    {
        static void Main()
        {
            List<Card.Value> values = new List<Card.Value> { Card.Value.Ace, Card.Value.Three, Card.Value.Two };
            Console.WriteLine(values.MaxRunLength());
            foreach(Card card in Shuffle(10))
            {
                Console.WriteLine(card);
            }
            Console.ReadKey();

            Colours.Rainbow myCol = Colours.Rainbow.Red | Colours.Rainbow.Blue;
            Console.WriteLine(myCol.ToString("G"));
            Console.WriteLine(myCol.ToString("D"));



            Console.ReadKey();
        }

        static List<Card> Shuffle(int n) //Shuffling
        {
            char[] suits = { 'S','C','D','H' };
            char[] values = { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K' };
            List<Card> allCards = new List<Card>();
            foreach(char suit in suits)
            {
                foreach(char value in values)
                {
                    allCards.Add((value.ToString() + suit.ToString()).ToCard());
                }
            }
            Random random = new Random();
            List<Card> deck = new List<Card>();

            for (int i = 0; i < n; ++i)
            {
                deck.Add(allCards[random.Next(52)]);
            }

            return deck;
        }

        static void PrintColours()
        {
            Colours.Rainbow col = Colours.Rainbow.Red;
            while ((int)col < 65)
            {
                Console.WriteLine(col);
                col = (int)col + col;
            }

        }
    }
}
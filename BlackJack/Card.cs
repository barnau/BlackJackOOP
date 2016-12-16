using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public int Suit { get; set; }
        public int Value { get; set; }
        public Card()
        {

        }

        public Card(int suit, int value)
        {
            this.Suit = suit;
            this.Value = value;

        }

        public string CardToString()
        {
            string suit = "";
            switch (Suit)
            {
                case 0:
                    suit = "Spades";
                    break;
                case 1:
                    suit = "Clubs";
                    break;
                case 2:
                    suit = "Hearts";
                    break;
                case 3:
                    suit = "Diamonds";
                    break;
            }
            string value = "";
            switch (Value)
            {
                case 9:
                    value = "Jack";
                    break;
                case 10:
                    value = "Queen";
                    break;
                case 11:
                    value = "King";
                    break;
                case 12:
                    value = "Ace";
                    break;
                default:
                    var intValue = Value + 2;
                    value = intValue.ToString();
                    break;
            }

            return value + " of " + suit;
        }
    }
}

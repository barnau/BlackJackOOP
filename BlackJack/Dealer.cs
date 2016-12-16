using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer
    {
        public List<Card> Deck { get; set; } = new List<Card>();

        public Dealer()
        {
            this.Deck = new Deck().FullDeck;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        private const int NumCards  = 13;
        private const int NumSuits = 4;
        public int DeckCount { get; private set; } = 52;


        public List<Card> FullDeck { get; set; } = new List<Card>();
      


        public Deck()
        {
            for (int s = 0; s < NumSuits; s++)
            {
                for (int v = 0; v < NumCards; v++)
                {
                    this.FullDeck.Add(new Card(s, v));
                }

            }
        }

        public Card Deal()
        {
            if (DeckCount > 1)
            {
                Random rnd = new Random();
                int cn = rnd.Next(DeckCount - 1);
                var returnCard = this.FullDeck.ElementAt(cn);
                this.FullDeck.RemoveAt(cn);
                DeckCount--;

                return returnCard;
            }
            return null;
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class BasePlayer
    {
        public int NumOfCards { get; private set; } = 0;
        public int HandValue { get; private set; } = 0;

        public void ReceiveCard(Card card)
        {
            NumOfCards += 1;
            
            if (card.Value == 13 && HandValue > 21)
            {
                HandValue += 1;
            }
            else
            {
                HandValue += card.Value + 2;
            }
        }

        
    }
}

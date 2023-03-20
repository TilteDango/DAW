using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Adicional_Video_Poker
{
     class PokerDeck
    {
        private List<PokerCard> deck;

        public PokerDeck()
        {
            deck = new List<PokerCard>();
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 12; k++)
                {
                    PokerCard pc = new PokerCard((Suit)i, (Rank)k);
                    deck.Add(pc); 
                }
            }

            deck = Barajar(deck);
        }

        public List<PokerCard> Barajar(List<PokerCard> pc)
        {
            Random r = new Random();
            int n;
            List<PokerCard> barajada = new List<PokerCard>();

            while(pc.Count > 0)
            {
                n = r.Next(pc.Count);

                barajada.Add(pc[n]);
                pc.RemoveAt(n);
            }

            return barajada;
        }

        public PokerCard DrawCard()
        {

            PokerCard pc = new PokerCard(deck[deck.Count - 1].Suit, deck[deck.Count -1].Rank);
            deck.Remove(deck[deck.Count - 1]);

            return pc;
        }

      
    }
}

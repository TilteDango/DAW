using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Adicional_Video_Poker
{
    class PokerHand
    {
        private PokerCard[] hand = new PokerCard[5];

        internal PokerCard[] Hand { get => hand;}

        public PokerHand(PokerCard c0, PokerCard c1, PokerCard c2, PokerCard c3, PokerCard c4)
        {
            hand[0] = c0;
            hand[1] = c1;
            hand[2] = c2;
            hand[3] = c3;
            hand[4] = c4;
            SortHand();
        }

        public override string ToString()
        {
            string s = "";
           

            for (int i = 0; i < hand.Length; i++)
            {
                if (i < hand.Length - 1)
                {
                    s += hand[i].ToString() + " ";
                }
                else
                {
                    s += hand[i].ToString() + " ";
                }
            }


            return s;
        }

        public void EscribeAbajo()
        {

            for (int i = 0; i < hand.Length; i++)
            {
  
                    Console.Write(hand[i].EscribeReves() + " ");
 
            }

        }

        public void SortHand()
        {
            Array.Sort(hand);
        }

        public bool isPair()
        {
            bool pareja = false;
            for (int i = 0; i < hand.Length - 1; i++)
            {
                if ((hand[i].Rank == hand[i + 1].Rank))
                {
                    pareja = true;
                }
            }

            return pareja;
        }

        public bool isJPair()
        {
            bool pareja = false;
            for (int i = 0; i < hand.Length - 1; i++)
            {
                if ((hand[i].Rank == hand[i + 1].Rank) && hand[i].Rank >= Rank.Jack)
                {
                    pareja = true;
                }
            }

            return pareja;
        }

        public bool isTwoPairs()
        {
            bool pareja = false;
            int cont = 0;

            for (int i = 0; i < hand.Length -1; i++)
            {
                if (hand[i].Rank == hand[i+1].Rank)
                {
                    cont++;
                    i++;
                }
            }

            if (cont == 2)
            {
                pareja = true;
            }

            return pareja;
        }

        public bool isThree()
        {
            bool pareja = false;

            for (int i = 0; i < hand.Length -2; i++)
            {
                if (hand[i].Rank == hand[i+1].Rank && hand[i].Rank == hand[i +2].Rank)
                {
                    pareja = true;
                }
            }

            return pareja;
        }

        public bool isStraight() // No funciona si es As, 2, 3, 4 --> Preguntar si tiene que funcionar
        {
            return hand[0].Rank == (hand[1].Rank - 1) && hand[0].Rank == (hand[2].Rank - 2) && hand[0].Rank == (hand[3].Rank - 3) && hand[0].Rank == (hand[4].Rank - 4);
        }

        public bool isFlush()
        {
            return hand[0].Suit == hand[1].Suit && hand[0].Suit == hand[2].Suit && hand[0].Suit == hand[3].Suit && hand[0].Suit == hand[4].Suit;
        }

        public bool isFull()
        {
            bool pareja = false, trio = false;
            int ntrio = 20;

            for (int i = 0; i < hand.Length - 2; i++)
            {
                if (hand[i].Rank == hand[i + 1].Rank && hand[i].Rank == hand[i + 2].Rank)
                {
                    trio = true;
                    ntrio = (int)hand[i].Rank;
                }
            }

            for (int i = 0; i < hand.Length -1; i++)
            {
                if (hand[i].Rank == hand[i+1].Rank && hand[i].Rank != (Rank)ntrio)
                {
                    pareja = true;
                }
            }

            return pareja && trio;
        }

        public bool isPoker()
        {
            bool pareja = false;

            for (int i = 0; i < hand.Length - 4; i++)
            {
                if ((hand[i].Rank == hand[i +1].Rank) && (hand[i].Rank == hand[i+2].Rank) && (hand[i].Rank == hand[i +3].Rank))
                {
                    pareja = true;
                }
            }
            return pareja;
        }

        public bool isStraightFlush()
        {
            return isStraight() && isFlush();
        }

        public bool isRoyalFlush()
        {
            return isStraightFlush() && hand[4].Rank == Rank.Ace;
        }

        public void ChangeCard(string[] cambios, PokerDeck pd)
        {
            for (int i = 0; i < cambios.Length; i++)
            {
                hand[int.Parse(cambios[i]) -1] = pd.DrawCard();
            }
           
        }

    }
}

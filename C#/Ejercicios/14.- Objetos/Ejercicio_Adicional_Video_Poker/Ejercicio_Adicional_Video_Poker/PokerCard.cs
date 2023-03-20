using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ejercicio_Adicional_Video_Poker
{

    enum Suit { Hearts, Diamonds, Spades, Clubs };
    enum Rank { N2, N3, N4, N5, N6, N7, N8, N9, N10, Jack, Queen, King, Ace };

     class PokerCard : IComparable<PokerCard>
    {
        private Suit suit;
        private Rank rank;

        public Suit Suit { get => suit; }
        public Rank Rank { get => rank; }

        public PokerCard(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public int CompareTo([AllowNull] PokerCard other)
        {
            if ((int)this.rank > (int)other.rank)
            {
                return 1;
            }
            else
            {
                if ((int)this.rank < (int)other.rank)
                {
                    return -1;
                }
                else
                {
                    return ((int)this.suit).CompareTo(((int)other.suit));
                }
            }
        }

        public override string ToString()
        {
            string s = "\x1b[107m\x1b[30m";
            switch (Rank)
            {
                case Rank.N2:
                    s += "2";
                    break;
                case Rank.N3:
                    s += "3";
                    break;
                case Rank.N4:
                    s += "4";
                    break;
                case Rank.N5:
                    s += "5";
                    break;
                case Rank.N6:
                    s += "6";
                    break;
                case Rank.N7:
                    s += "7";
                    break;
                case Rank.N8:
                    s += "8";
                    break;
                case Rank.N9:
                    s += "9";
                    break;
                case Rank.N10:
                    s += "10";
                    break;
                case Rank.Jack:
                    s += "J";
                    break;
                case Rank.Queen:
                    s += "Q";
                    break;
                case Rank.King:
                    s += "K";
                    break;
                case Rank.Ace:
                    s += "A";
                    break;
                default:
                    break;
            }

            switch (Suit)
            {
                case Suit.Hearts:
                    s += "\x1b[31m♥";
                    break;
                case Suit.Diamonds:
                    s += "\x1b[31m♦";
                    break;
                case Suit.Spades:
                    s += "♠";
                    break;
                case Suit.Clubs:
                    s += "♣";
                    break;
                default:
                    break;
            }
            if (Rank == Rank.N10)
            {
                s += "\x1b[0m";
            }
             s += " \x1b[0m";

            return s;
                
        }

        public string EscribeReves()
        {
            string s = "";
            if (Rank == Rank.N10)
            {
                s += "\x1b[107m\x1b[30m";
            }
            else
            {
                s += "\x1b[107m\x1b[30m ";
            }

            

            switch (Suit)
            {
                case Suit.Hearts:
                    s += "\x1b[31m♥";
                    break;
                case Suit.Diamonds:
                    s += "\x1b[31m♦";
                    break;
                case Suit.Spades:
                    s += "♠";
                    break;
                case Suit.Clubs:
                    s += "♣";
                    break;
                default:
                    break;
            }

            switch (Rank)
            {
                case Rank.N2:
                    s += "2";
                    break;
                case Rank.N3:
                    s += "3";
                    break;
                case Rank.N4:
                    s += "4";
                    break;
                case Rank.N5:
                    s += "5";
                    break;
                case Rank.N6:
                    s += "6";
                    break;
                case Rank.N7:
                    s += "7";
                    break;
                case Rank.N8:
                    s += "8";
                    break;
                case Rank.N9:
                    s += "9";
                    break;
                case Rank.N10:
                    s += "10";
                    break;
                case Rank.Jack:
                    s += "J";
                    break;
                case Rank.Queen:
                    s += "Q";
                    break;
                case Rank.King:
                    s += "K";
                    break;
                case Rank.Ace:
                    s += "A";
                    break;
                default:
                    break;
            }


         
            s += "\x1b[0m";

            return s;
        }
    }
}

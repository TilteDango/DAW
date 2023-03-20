using System;

namespace Ejercicio_Adicional_Video_Poker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int saldo = 1, opcion = 1;
            string cambio;
            string[] array;

            PantallaGeneral();
            EscribeSaldo(saldo);
            while (saldo > 0 || saldo < 850 || opcion != 2)
            {
               
               
                PokerDeck pd = new PokerDeck();
                PokerHand ph = new PokerHand(pd.DrawCard(), pd.DrawCard(), pd.DrawCard(), pd.DrawCard(), pd.DrawCard());

                LimpiarMapa();

                Console.SetCursorPosition(4, 8);
                Console.WriteLine("Para empezar vamos a ver tu mano: ");
                PintaMano(ph);
                EscribeListaPremios(ph);
                Console.SetCursorPosition(4, 10);
                Console.WriteLine("¿Desearías cambiar alguna carta?");
                Console.SetCursorPosition(4, 11);
                Console.WriteLine("Debes poner todos los numeros que quieras cambiar  del 1 al 5, separados por comas)");
                Console.SetCursorPosition(4, 12);
                cambio = Console.ReadLine();
                array = cambio.Split(',');

                for (int i = 0; i < array.Length; i++)
                {
                    if (int.Parse(array[i]) > 5 || int.Parse(array[i]) < 0)
                    {
                        throw new Exception("No puedes poner números que no esten comprendidos entre 1 y 5");
                    }
                }
                ph.ChangeCard(array, pd);
                ph.SortHand();
                Console.SetCursorPosition(4, 15);
                Console.WriteLine("Tu nueva mano es: ");
                PintaMano(ph);
                EscribeListaPremios(ph);
                Console.SetCursorPosition(4, 17);
                if (ph.isRoyalFlush())
                {
                    Console.WriteLine("Felicidades, premio gordo -> 800 euros");
                    saldo += 800;
                }
                else
                {
                    if (ph.isStraightFlush())
                    {
                        Console.WriteLine("Tienes un Straight FLush -> 50 euros");
                        saldo += 50;
                    }
                    else
                    {
                        if (ph.isPoker())
                        {
                            Console.WriteLine("Tienes Poker -> 25 euros");
                            saldo += 25;
                        }
                        else
                        {
                            if (ph.isFull())
                            {
                                Console.WriteLine("Tienes un Full -> 9 euros");
                                saldo += 9;
                            }
                            else
                            {
                                if (ph.isFlush())
                                {
                                    Console.WriteLine("Tienes un Flush -> 6 euros");
                                    saldo += 6;
                                }
                                else
                                {
                                    if (ph.isStraight())
                                    {
                                        Console.WriteLine("Tienes un Straight -> 4 euros");
                                    }
                                    else
                                    {
                                        if (ph.isThree())
                                        {
                                            Console.WriteLine("Tienes un trio -> 3 euros");
                                            saldo += 3;
                                        }
                                        else
                                        {
                                            if (ph.isTwoPairs())
                                            {
                                                Console.WriteLine("Tienes doble pareja -> 2 euros");
                                                saldo += 2;
                                            }
                                            else
                                            {
                                                if (ph.isJPair())
                                                {
                                                    Console.WriteLine("Por los pelos, tienes una pareja -> 1 euro");
                                                    saldo += 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No tienes nada, pierdes el dinero");
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
                EscribeSaldo(saldo);
                Console.SetCursorPosition(4, 20);
                Console.WriteLine("Quieres seguir jugando");
                Console.SetCursorPosition(4, 21);
                Console.WriteLine("1. Si");
                Console.SetCursorPosition(4, 22);
                Console.WriteLine("2. No");
                Console.SetCursorPosition(4, 23);
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1 && saldo == 0)
                {
                    saldo++;
                }
                
                saldo--;
                EscribeSaldo(saldo);
            }

        }

        static void EscribeListaPremios(PokerHand ph)
        {
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.SetCursorPosition(120, 15);
            if (ph.isRoyalFlush())
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine("Royal Flush ".PadLeft(25) +"> 800".PadLeft(15, '-'));
            Console.ForegroundColor = ConsoleColor.White;

            if (ph.isStraightFlush() && !ph.isRoyalFlush())
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(120, 18);
            Console.WriteLine("Straight Flush ".PadLeft(28) + "> 50".PadLeft(11, '-'));
            Console.ForegroundColor = ConsoleColor.White;

            if (ph.isPoker() && !ph.isRoyalFlush() && !ph.isStraightFlush())
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(120, 21);
            Console.WriteLine("Poker ".PadLeft(19) + "> 25".PadLeft(20, '-'));
            Console.ForegroundColor = ConsoleColor.White;

            if (ph.isFull() && !ph.isPoker() && !ph.isRoyalFlush() && !ph.isStraightFlush())
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(120, 24);
            Console.WriteLine("Full".PadLeft(17) + "> 9".PadLeft(21, '-'));
            Console.ForegroundColor = ConsoleColor.White;

            if (ph.isFlush() && !ph.isFull() && !ph.isPoker() && !ph.isRoyalFlush() && !ph.isStraightFlush())
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(120, 27);
            Console.WriteLine("Flush".PadLeft(18) + "> 6".PadLeft(20,'-'));
            Console.ForegroundColor = ConsoleColor.White;
            if (ph.isStraight() && !ph.isFlush() && !ph.isFull() && !ph.isPoker() && !ph.isRoyalFlush() && !ph.isStraightFlush())
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(120, 30);
            Console.WriteLine("Straight ".PadLeft(22) + "> 4".PadLeft(16,'-'));
            Console.ForegroundColor = ConsoleColor.White;

            if (ph.isThree() && !ph.isStraight() && !ph.isFlush() && !ph.isFull() && !ph.isPoker() && !ph.isRoyalFlush() && !ph.isStraightFlush())
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(120, 33);
            Console.WriteLine("Three ".PadLeft(19) + "> 3".PadLeft(19,'-'));
            Console.ForegroundColor = ConsoleColor.White;

            if (ph.isTwoPairs() && !ph.isThree() && !ph.isStraight() && !ph.isFlush() && !ph.isFull() && !ph.isPoker() && !ph.isRoyalFlush() && !ph.isStraightFlush())
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(120, 36);
            Console.WriteLine("Two Pairs ".PadLeft(23) + "> 2".PadLeft(15,'-'));
            Console.ForegroundColor = ConsoleColor.White;
            if (ph.isJPair() && !ph.isTwoPairs() && !ph.isThree() && !ph.isStraight() && !ph.isFlush() && !ph.isFull() && !ph.isPoker() && !ph.isRoyalFlush() && !ph.isStraightFlush())
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(120, 39);
            Console.WriteLine("Jacks or Better ".PadLeft(29) + "> 1".PadLeft(9,'-'));
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y);
        }


        static void PantallaGeneral()


        {

            Console.WindowWidth = 167;
            Console.WindowHeight = 45;
            Console.SetCursorPosition(89, 4);
            Console.Write("VIDEOPOKER");


            for (int i = 3; i < 165; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("═");

                Console.SetCursorPosition(i, 42);
                Console.Write("═");
            }

            for (int i = 120; i < 165; i++)
            {
                Console.SetCursorPosition(i, 12);
                Console.Write("═");
            }

            for (int i = 2; i < 42; i++)
            {
                Console.SetCursorPosition(119, i);
                Console.Write("║");
            }

            for (int i = 3; i < 42; i++)
            {
                Console.SetCursorPosition(2, i);
                Console.Write("║");

                Console.SetCursorPosition(165, i);
                Console.Write("║");
            }

            for (int i = 3; i < 119; i++)
            {
                Console.SetCursorPosition(i, 6);
                Console.Write("═");
            }

            Console.SetCursorPosition(2, 2);
            Console.Write("╔");
            Console.SetCursorPosition(165, 2);
            Console.Write("╗");
            Console.SetCursorPosition(2, 42);
            Console.Write("╚");
            Console.SetCursorPosition(165, 42);
            Console.Write("╝");
            Console.SetCursorPosition(165, 12);
            Console.Write("╢");
            Console.SetCursorPosition(119, 42);
            Console.Write("╩");
            Console.SetCursorPosition(119, 12);
            Console.Write("╠");
            Console.SetCursorPosition(119, 2);
            Console.Write("╦");
            Console.SetCursorPosition(2, 6);
            Console.Write("╠");
            Console.SetCursorPosition(119, 6);
            Console.Write("╣");
            Console.SetCursorPosition(72, 2);
            Console.Write("╦");
            for (int i = 3; i < 6; i++)
            {
                Console.SetCursorPosition(72, i);
                Console.Write("║");
            }
            Console.SetCursorPosition(72, 6);
            Console.Write("╩");



            Console.SetCursorPosition(119, 34);
            Console.Write("╣");

            Console.SetCursorPosition(2, 34);
            Console.Write("╠");

            for (int i = 35; i < 42; i++)
            {
                Console.SetCursorPosition(106, i);
                Console.Write("║");
            }

            for (int i = 107; i < 119; i++)
            {
                Console.SetCursorPosition(i, 34);
                Console.Write("═");
            }

            for (int i = 3; i < 107; i++)
            {
                Console.SetCursorPosition(i, 34);
                Console.Write("═");
            }

            Console.SetCursorPosition(106, 42);
            Console.Write("╩");

            Console.SetCursorPosition(106, 34);
            Console.Write("╦");

            Console.SetCursorPosition(50, 50); 
        }

        static void EscribeSaldo(int saldo)
        {
            Console.SetCursorPosition(3, 4);

            Console.WriteLine(saldo.ToString().PadLeft(25) + " de saldo");
        }

        static void PintaMano (PokerHand ph)
        {
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.SetCursorPosition(41, 37);
            Console.WriteLine(" 1   2   3   4   5 ");
            Console.SetCursorPosition(41, 38);
            Console.WriteLine(ph);
            Console.SetCursorPosition(41, 39);
            for (int i = 0; i < 5; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("   ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            Console.SetCursorPosition(41, 40);
            ph.EscribeAbajo();
            Console.SetCursorPosition(x, y);
        }

        static void LimpiarMapa()
        {
            for (int k = 7; k < 34; k++)
            {
                for (int i = 3; i < 119; i++)
                {
                    Console.SetCursorPosition(i, k); Console.WriteLine(" ");
                }
            }
        }

        
    }
}

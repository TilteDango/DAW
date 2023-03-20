using System;

namespace Objetos_Opcional___Tres_en_Raya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tres en raya");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Modo PvP");
            Console.WriteLine("2. Modo PvE");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1: PvP(); break;
                case 2: Pve();break;
                default: Environment.Exit(0);
                    break;
            }
        }

        static void PvP()
        {
            TresEnRaya c = new TresEnRaya();
            Console.Clear();
            
            Random r = new Random();
            int n = r.Next(2);
            for (int i = n; i <= 2; i++)
            {
                c.DibujaTablero();
                if (i == 1)
                {
                    Console.Clear();
                    c.DibujaTablero();
                    Console.Write("Es el turno del jugador 1: ");
                    n = int.Parse(Console.ReadLine());

                    if (c.MovimientoValido(n))
                    {
                        c.MueveJugador1(n);
                    }
                    else
                    {
                        while (!c.MovimientoValido(n))
                        {
                            Console.Clear();
                            c.DibujaTablero();
                            Console.Write("Movimiento inválido, mueve una ficha: ");
                            n = int.Parse(Console.ReadLine());
                        }
                        c.MueveJugador1(n);
                    }
                }
                else
                {
                    Console.Clear();
                    c.DibujaTablero();
                    Console.Write("Es el turno del jugador 2: ");
                    n = int.Parse(Console.ReadLine());

                    if (c.MovimientoValido(n))
                    {
                        c.MueveJugador2(n);
                    }
                    else
                    {
                        while (!c.MovimientoValido(n))
                        {
                            Console.Clear();
                            c.DibujaTablero();
                            Console.Write("Movimiento inválido, mueve una ficha: ");
                            n = int.Parse(Console.ReadLine());
                        }
                        c.MueveJugador2(n);
                    }

                    i = 0;
                }

                if (c.GanaJugador1())
                {
                    Console.Clear();
                    c.DibujaTablero();
                    Console.WriteLine("Felicidades, ha ganado el jugador 1");
                    i = 3;
                }
                else
                {
                    if (c.GanaJugador2())
                    {
                        Console.Clear();
                        c.DibujaTablero();
                        Console.WriteLine("Felicidades, ha ganado el jugador 2");
                        i = 3;
                    }
                    else
                    {
                        if (!c.QuedanMovimientos())
                        {
                            Console.Clear();
                            c.DibujaTablero();
                            Console.WriteLine("Habeis quedado empate");
                            i = 3;
                        }
                    }
                }


            }
        }

        static void Pve()
        {
           
            Console.Clear();
            int n;
            Console.WriteLine("1. Modo fácil");
            Console.WriteLine("2. Modo díficil");
            Console.WriteLine("3. Modo imposible");
            Console.WriteLine("Quieres modo fácil, modo díficil o modo imposible: ");
            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1: PveFacil();break;
                case 2: PveDificil();break;
                case 3: PveImposible();break;
                default: Environment.Exit(0); break;
            }
        }

        private static void PveImposible()
        {
            
            //padre.CreaNodoHijo();

            ////padre.Imprime();
            //int punt = padre.Puntuacion();
            //Console.WriteLine(punt);

            //for (int i = 0; i < padre.hijos.Count; i++)
            //{
            //    if (padre.hijos[i].puntuacion == punt)
            //    {
            //        Console.WriteLine(NodoArbol.EscribeArray(padre.hijos[i].datos));
            //    }
            //}
            TresEnRaya c = new TresEnRaya();
            Console.Clear();
            Random r = new Random();
            int n = r.Next(1, 2);


            for (int i = n; i <= 2; i++)
            {
                c.DibujaTablero();
                if (i == 1)
                {
                    Console.Clear();
                    c.DibujaTablero();
                    Console.Write("Es tú turno, mueve una ficha: ");
                    n = int.Parse(Console.ReadLine());

                    if (c.MovimientoValido(n))
                    {
                        c.MueveJugador1(n);
                    }
                    else
                    {
                        while (!c.MovimientoValido(n))
                        {
                            Console.Clear();
                            c.DibujaTablero();
                            Console.Write("Movimiento inválido, mueve una ficha: ");
                            n = int.Parse(Console.ReadLine());
                        }
                        c.MueveJugador1(n);
                    }
                }
                else
                {
                    c.JuegaOrdenadorPro();
                    i = 0;
                }

                if (c.GanaJugador1())
                {
                    Console.Clear();
                    c.DibujaTablero();
                    Console.WriteLine("Felicidades, has ganado");
                    i = 3;
                }
                else
                {
                    if (c.GanaJugador2())
                    {
                        Console.Clear();
                        c.DibujaTablero();
                        Console.WriteLine("Lo siento, has perdido");
                        i = 3;
                    }
                    else
                    {
                        if (!c.QuedanMovimientos())
                        {
                            Console.Clear();
                            c.DibujaTablero();
                            Console.WriteLine("Habeis quedado empate");
                            i = 3;
                        }
                    }
                }


            }
        }

        static void PveDificil()
        {
            TresEnRaya c = new TresEnRaya();
            Console.Clear();
            Random r = new Random();
            int n = r.Next(2);
            

            for (int i = n; i <= 2; i++)
            {
                c.DibujaTablero();
                if (i == 1)
                {
                    Console.Clear();
                    c.DibujaTablero();
                    Console.Write("Es tú turno, mueve una ficha: ");
                    n = int.Parse(Console.ReadLine());

                    if (c.MovimientoValido(n))
                    {
                        c.MueveJugador1(n);
                    }
                    else
                    {
                        while (!c.MovimientoValido(n))
                        {
                            Console.Clear();
                            c.DibujaTablero();
                            Console.Write("Movimiento inválido, mueve una ficha: ");
                            n = int.Parse(Console.ReadLine());
                        }
                        c.MueveJugador1(n);
                    }
                }
                else
                {
                    c.MueveOrdenador1Pro();
                    i = 0;
                }
                if (c.GanaJugador1())
                {
                    Console.Clear();
                    c.DibujaTablero();
                    Console.WriteLine("Felicidades, has ganado");
                    i = 3;
                }
                else
                {
                    if (c.GanaJugador2())
                    {
                        Console.Clear();
                        c.DibujaTablero();
                        Console.WriteLine("Lo siento, has perdido");
                        i = 3;
                    }
                    else
                    {
                        if (!c.QuedanMovimientos())
                        {
                            Console.Clear();
                            c.DibujaTablero();
                            Console.WriteLine("Habeis quedado empate");
                            i = 3;
                        }
                    }
                }
            }
        }

       

         static void PveFacil()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_Opcional___Tres_en_Raya
{
    class TresEnRaya
    {
        private static Random r = new Random();

        private int[] tablero = new int[9];

        public void MueveJugador1 (int pos)
        {
            if (MovimientoValido(pos))
            {
                tablero[pos - 1] = 1;
            }
            else
            {
                throw new Exception("El hueco esta ocupado");
            }
            
        }

        public void MueveJugador2 (int pos)
        {
            if (MovimientoValido(pos))
            {
                tablero[pos - 1] = 2;
            }
            else
            {
                throw new Exception("El hueco esta ocupado");
            }
           
        }

        public bool MovimientoValido(int pos)
        {
            bool valido = true;
            if (tablero[pos - 1] != 0)
            {
                valido = false; 
            }
            else
            {
                valido = true;
            }

            return valido;
        }

        public void MueveOrdenador1()
        {
            Random r = new Random();
            int n = r.Next(1,10);

            while (!MovimientoValido(n))
            {
                n = r.Next(1, 10);
            }

            MueveJugador1(n);

        }
        public void MueveOrdenador1Pro()
        {
            int n;
            Random r = new Random();
            if (!GanaMaquinaSJ())
            {
                if (!GanaSiguienteJugada())
                {
                    n = r.Next(9) + 1;
                    if (MovimientoValido(n))
                    {
                        MueveJugador2(n);
                    }
                    else
                    {
                        while (!MovimientoValido(n))
                        {
                            n = r.Next(9) + 1;
                        }
                        MueveJugador2(n);
                    }
                }
            }
        }


        public void MueveOrdenador2()
        {
            Random r = new Random();
            int n = r.Next(1, 10);

            while (!MovimientoValido(n))
            {
                n = r.Next(1, 10);
            }

            MueveJugador2(n);
        }

        public void Iniciar()
        {
            for (int i = 0; i < tablero.Length; i++)
            {
                tablero[i] = 0;
            }
        }

        public bool QuedanMovimientos()
        {
            bool queda = false;
            for (int i = 0; i < tablero.Length; i++)
            {
                if (tablero[i] == 0)
                {
                    queda = true;
                    i = tablero.Length;
                }
            }

            return queda;
        }

        public static bool QuedanMovimientos(int[] tablero)
        {
            bool queda = false;
            for (int i = 0; i < tablero.Length; i++)
            {
                if (tablero[i] == 0)
                {
                    queda = true;
                    i = tablero.Length;
                }
            }

            return queda;
        }

        public bool GanaJugador1()
        {
            return (tablero[0] == 1 && tablero[1] == 1 && tablero[2] == 1) || (tablero[3] == 1 && tablero[4] == 1 && tablero[5] == 1) || (tablero[6] == 1 && tablero[7] == 1 && tablero[8] == 1 )|| (tablero[0] == 1 && tablero[3] == 1 && tablero[6] == 1) || (tablero[1] == 1 && tablero[7] == 1 && tablero[4] == 1) || (tablero[2] == 1 && tablero[5] == 1 && tablero[8] == 1) || (tablero[0] == 1 && tablero[4] == 1 && tablero[8] == 1) || (tablero[6] == 1 && tablero[4] == 1 && tablero[2] == 1);
        }

        public static bool GanaJugador(int[] tablero, int jugador)
        {
            return (tablero[0] == jugador && tablero[1] == jugador && tablero[2] == jugador) || 
                   (tablero[3] == jugador && tablero[4] == jugador && tablero[5] == jugador) || 
                   (tablero[6] == jugador && tablero[7] == jugador && tablero[8] == jugador) || 
                   (tablero[0] == jugador && tablero[3] == jugador && tablero[6] == jugador) || 
                   (tablero[1] == jugador && tablero[4] == jugador && tablero[7] == jugador) || 
                   (tablero[2] == jugador && tablero[5] == jugador && tablero[8] == jugador) || 
                   (tablero[0] == jugador && tablero[4] == jugador && tablero[8] == jugador) || 
                   (tablero[2] == jugador && tablero[4] == jugador && tablero[6] == jugador);
        }

        public bool GanaJugador2()
        {
            return (tablero[0] == 2 && tablero[1] == 2 && tablero[2] == 2) || (tablero[3] == 2 && tablero[4] == 2 && tablero[5] == 2) || (tablero[6] == 2 && tablero[7] == 2 && tablero[8] == 2) || (tablero[0] == 2 && tablero[3] == 2 && tablero[6] == 2) || (tablero[1] == 2 && tablero[7] == 2 && tablero[4] == 2) || (tablero[2] == 2 && tablero[5] == 2 && tablero[8] == 2) || (tablero[0] == 2 && tablero[4] == 2 && tablero[8] == 2) || (tablero[6] == 2 && tablero[4] == 2 && tablero[2] == 2);
        }

        public void DibujaTablero()
        {
            string[] s = new string[9]; 
            for (int i = 0; i < tablero.Length; i++)
            {
                if (tablero[i] == 1)
                {
                    s[i] = "X";
                }
                else
                {
                    if (tablero[i] == 2)
                    {
                        s[i] = "O";
                    }
                    else
                    { 
                        s[i] = (i+1).ToString();
                    }
                }

            }

            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("║");
            }

            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(12, i);
                Console.WriteLine("║");

                Console.SetCursorPosition(8, i);
                Console.WriteLine("║");

                Console.SetCursorPosition(4, i);
                Console.WriteLine("║");
            }

            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("═");
            }

            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(i, 12);
                Console.WriteLine("═");

                Console.SetCursorPosition(i, 4);
                Console.WriteLine("═");

                Console.SetCursorPosition(i, 8);
                Console.WriteLine("═");
            }

            Console.SetCursorPosition(0,0);
            Console.WriteLine("╔");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("╚");
            Console.SetCursorPosition(12, 12);
            Console.WriteLine("╝");
            Console.SetCursorPosition(12, 0);
            Console.WriteLine("╗");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("╠");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("╠");
            Console.SetCursorPosition(12, 4);
            Console.WriteLine("╣");
            Console.SetCursorPosition(12, 8);
            Console.WriteLine("╣");
            Console.SetCursorPosition(4, 0);
            Console.WriteLine("╦");
            Console.SetCursorPosition(8, 0);
            Console.WriteLine("╦");
            Console.SetCursorPosition(4, 12);
            Console.WriteLine("╩");
            Console.SetCursorPosition(8, 12);
            Console.WriteLine("╩");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("╬");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("╬");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("╬");
            Console.SetCursorPosition(8, 4);
            Console.WriteLine("╬");
            int x = 2;
            int y = 2;
            for (int i = 0; i < tablero.Length; i++)
            {
                Console.SetCursorPosition(y, x);
                if (s[i] == "X")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    if (s[i] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine(s[i]);
                y = y + 4;
                if (y > 12)
                {
                    x = x + 4;
                    y = 2;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20, 20);



        }

        public bool GanaSiguienteJugada()
        {
            bool gana = false;
            for (int i = 0; i < tablero.Length; i++)
            {
                if (tablero[i] == 0)
                {
                    tablero[i] = 1;
                    if (GanaJugador1())
                    {
                        tablero[i] = 2;                        
                        gana = true;
                        i = tablero.Length;
                    }
                    else
                    {
                        tablero[i] = 0;
                    }
                }        
            }
            return gana;
        }

        public bool GanaMaquinaSJ()
        {
            bool gana = false;

            for (int i = 0; i < tablero.Length; i++)
            {
                if (tablero[i] == 0)
                {
                    tablero[i] = 2;
                    if (!GanaJugador2())
                    {
                        tablero[i] = 0;
                        
                    }
                    else
                    {
                        gana = true;
                        i = tablero.Length;
                    }
                }
            }
            return gana;
        }

        public void JuegaOrdenadorPro()
        {
            NodoArbol n = new NodoArbol(tablero, 1);
            n.CreaNodoHijo();
            int punt = n.Puntuacion2();
            List<int[]> posibilidades = new List<int[]>();
            for (int i = 0; i < n.hijos.Count; i++)
            {
                if(n.hijos[i].puntuacion == punt)
                {
                    posibilidades.Add(n.hijos[i].datos);
                }
            }
            int pos = r.Next(posibilidades.Count);
            posibilidades[pos].CopyTo(tablero, 0);
        }

       


    }
}

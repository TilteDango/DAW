using System;
using System.IO;
using System.Net.Sockets;

namespace Clases_1__Carta_y_Baraja
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteSieteyMedia();
        }

        static void SieteYMedia()
        {
            Random r = new Random();
            int n = 45, ran;
            decimal suma = 0, banca = 0;
            Baraja b = new Baraja(true);
            Carta ban = b.Robar();
            banca = banca + ban.Valor7ymedia;
            while (n != 1)
            {
                Console.Clear();
                Carta c = b.Robar();
                suma = suma + c.Valor7ymedia;
                Console.WriteLine(c + "--> " + suma);
                if (suma > 7.5m)
                {
                    n = 1;
                }
                else
                {
                    Console.WriteLine("0.- Robar Carta");
                    Console.WriteLine("1.- Plantarse");
                    Console.WriteLine("¿Quiere más cartas?");
                    n = int.Parse(Console.ReadLine());
                }

                if (banca < 5)
                {
                    ban = b.Robar();
                    banca = banca + ban.Valor7ymedia;
                }
                else
                {
                    if (banca > 5.5m && banca < 7.5m)
                    {
                        ran = r.Next(101);
                        if (ran > 90)
                        {
                            ban = b.Robar();
                            banca = banca + ban.Valor7ymedia;
                        }
                    }
                }
            }

            if ((suma <= 7.5m && suma > banca) || (suma <= 7.5m && banca > 7.5m))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Has ganado");
            }
            else
            {
                if (suma > 7.5m && banca > 7.5m)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Has empatado");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Has perdido");
                }

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tu puntuación es: " + suma);
            Console.WriteLine("La puntuación de la banca es " + banca);



        }

        static void ClienteSieteyMedia()
        {
            TcpClient cliente = new TcpClient("172.30.250.36", 9999);
            StreamWriter sw = new StreamWriter(cliente.GetStream());
            StreamReader sr = new StreamReader(cliente.GetStream());

            string linea;

            linea = sr.ReadLine();
            while (linea.Contains('$')==false)
            {
                Console.WriteLine(linea.Replace("@", "\n"));
                int n = int.Parse(Console.ReadLine());

                sw.WriteLine(n);
                sw.Flush();
                
                linea = sr.ReadLine();
            }
            Console.WriteLine(linea.Replace("$", ""));
           
            sw.Close();
            cliente.Close();
        }
    }

   
}

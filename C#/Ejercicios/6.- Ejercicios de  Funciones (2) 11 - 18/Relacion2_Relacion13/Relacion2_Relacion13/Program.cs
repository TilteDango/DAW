using System;

namespace Relacion2_Relacion13
{
    class Program
    {
        static void Main(string[] args)
        {
            double n; 
            Console.WriteLine("Vamos a pasar la nota a formato texto");
            Console.WriteLine();
            Console.Write("Dime la nota: ");
            n = double.Parse(Console.ReadLine());

            while (n > 10 || n < 0)
            {
                Console.WriteLine("Nota no válida, vuelve a introducirla");
                n = double.Parse(Console.ReadLine());

            }

            NotaEnTexto(n);
        }

        static void NotaEnTexto(double a)
        {
            if (a < 5)
            {
                Console.WriteLine("Suspenso");
            }
            else
            {
                if (a < 6)
                {
                    Console.WriteLine("Suficiente");
                }
                else
                {
                    if (a < 7)
                    {
                        Console.WriteLine("Bien");
                    }
                    else
                    {
                        if (a < 8)
                        {
                            Console.WriteLine("Notable");
                        }
                        else
                        {
                            Console.WriteLine("Sobresaliente");
                        }
                    }
                }
            }
        }
    }
}

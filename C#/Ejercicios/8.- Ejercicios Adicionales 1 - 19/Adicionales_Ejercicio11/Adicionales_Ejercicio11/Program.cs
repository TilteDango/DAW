using System;

namespace Adicionales_Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string valor;
            Console.Write("Dime un número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Dime otro número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Dime otro número: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Quieres el maximo, minimo o medio?");
            valor = Console.ReadLine();

            if (valor == "maximo")
            {
                Console.WriteLine(Maximo(a, b, c));
            }
            else
            {
                if (valor == "minimo")
                {
                    Console.WriteLine(Minimo(a, b, c));
                }
                else
                {
                    if (valor == "medio")
                    {
                        Console.WriteLine(Medio(a, b, c));
                    }
                    else
                    {
                        Console.WriteLine("Erroneo");
                    }
                }
            }
        }
        static int Maximo ( int a, int b, int c)
        {
            int max;
            if (a > b && a > c)
            {
                max = a;
            }
            else
            {
                if (a < b && b > c)
                {
                    max = b;
                }
                else
                {
                    max = c;
                }
            }

            return max;
        }

        static int Minimo(int a, int b, int c)
        {
            int min;
            if (a < b && a < c)
            {
                min = a;
            }
            else
            {
                if (a > b && b < c)
                {
                    min = b;
                }
                else
                {
                    min = c;
                }
            }

            return min;
        }

        static int Medio ( int a, int b, int c)
        {
            int medio;
            if (a > b && b > c)
            {
                medio = b;
            }
            else
            {
                if (c > a && a > b)
                {
                    medio = a;
                }
                else
                {
                    medio = c;
                }
            }

            return medio;
        }
    }
}

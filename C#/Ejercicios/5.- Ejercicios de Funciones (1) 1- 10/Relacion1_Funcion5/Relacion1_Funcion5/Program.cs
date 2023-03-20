using System;

namespace Relacion1_Funcion5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Vamos a averiguar si tu número es positivo, negativo o cero");
            n = int.Parse(Console.ReadLine());
            Signo(n);
        }

        static void Signo(int n)
        {
            if (n == 0)
            {
                Console.WriteLine();
                Console.WriteLine("0");
            }

            else
            {
                if (n > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("-1");
                }
            }
        }
    }
}




using System;

namespace Relacion1_Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, max;
            Console.WriteLine("Vamos a averiguar cual es el menor de dos números");
            Console.Write("Dime un número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dime otro número: ");
            b = int.Parse(Console.ReadLine());

            max = Min(a, b);

            Console.WriteLine("El número minimo es " + max);

        }

        static int Min(int a, int b)
        {
            if (a > b)
            {
                return b;
            }

            else
            {
                return a;
            }
        }
    }
}

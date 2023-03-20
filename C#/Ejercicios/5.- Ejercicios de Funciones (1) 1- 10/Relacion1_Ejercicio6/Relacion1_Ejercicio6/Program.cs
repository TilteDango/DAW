using System;

namespace Relacion1_Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, max;
            Console.WriteLine("Vamos a averiguar cual es el mayor de dos números");
            Console.Write("Dime un número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dime otro número: ");
            b = int.Parse(Console.ReadLine());

            max = Max(a, b);

            Console.WriteLine("El número máximo es " + max);

        }

        static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            else
            {
                return b;
            }
        }
    }
}

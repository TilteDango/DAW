using System;

namespace Relacion1_Funcion9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, mcm;
            Console.WriteLine("Vamos a calcular el Minimo comun multiplo de dos números");
            Console.WriteLine();
            Console.Write("Dime el primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dime el segundo número: ");
            b = int.Parse(Console.ReadLine());
            mcm = Mcm(a, b);

            Console.WriteLine("El minimo comun multiplo es: " + mcm);


        }

        static int Mcm(int a, int b)
        {
            int n;
            n = a * b;

            for (int i = a; i < a * b; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    n = i;
                    i = a * b;
                }
            }

            return n;
        }
    }
}


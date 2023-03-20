using System;

namespace Relacion1_Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, mcd;
            Console.WriteLine("Vamos a calcular el Maximo comun Divisor de dos números");
            Console.WriteLine();
            Console.Write("Dime el primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dime el segundo número: ");
            b = int.Parse(Console.ReadLine());
            mcd = Mcd(a, b);

            Console.WriteLine("El máximo comun divisor es: " + mcd);


        }

        static int Mcd(int a, int b)
        {
            int n;
            n = 1; 

            for (int i = a; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    n = i;
                    i = 0;
                }       
            }

            return n;
        }
    }
}

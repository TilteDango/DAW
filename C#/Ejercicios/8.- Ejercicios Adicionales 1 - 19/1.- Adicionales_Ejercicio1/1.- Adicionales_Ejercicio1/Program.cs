using System;

namespace _1.__Adicionales_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Vamos a averiguar si los números son primos relativos");
            Console.WriteLine();
            Console.Write("Dime un número ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dime otro número ");
            b = int.Parse(Console.ReadLine());

            if (PrimosRelativos(a, b))
            {
                Console.WriteLine("Ambos números son primos relativos");
            }
            else
            {
                Console.WriteLine("Ambos números no son primos relativos");

            }

        }

        static bool PrimosRelativos (int a, int b)
        {
            int tmp, cont = 0;

            if (a > b)
            {
                tmp = b;
                b = a;
                a = tmp; 
            }

            for (int i = 2; i < a; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    cont++;
                }
            }

            if (cont == 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}

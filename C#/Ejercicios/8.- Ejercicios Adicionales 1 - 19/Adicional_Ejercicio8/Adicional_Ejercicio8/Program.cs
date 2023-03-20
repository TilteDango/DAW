using System;

namespace Adicional_Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduzca un número: ");
            n = int.Parse(Console.ReadLine());

            CuadradoEstrellitas(n);
        }

        static void CuadradoEstrellitas (int n)
        {
            if (n > 20 || n < 1)
            {
                Console.WriteLine("ERROR");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((j == 1) || (j == n))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
            }
        }
    }
}

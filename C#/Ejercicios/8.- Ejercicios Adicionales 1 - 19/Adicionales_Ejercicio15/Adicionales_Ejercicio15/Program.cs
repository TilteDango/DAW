using System;

namespace Adicionales_Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, tmp;
            Console.WriteLine("Vamos a ver  los cuadrados perfectos entre dos números");
            Console.WriteLine();
            Console.Write("Dime un número: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Dime otro número: ");
            max = int.Parse(Console.ReadLine());

            if (min > max)
            {
                tmp = max;
                max = min;
                min = tmp;
            }
            ListaCuadradosPerfectos(min, max);

        }

        static bool CuadradoPerfecto (int n)
        {
            int j = 0;
            for (int i = 1; i <= n; i++)
            {
                if (Math.Sqrt(n) % i == 0)
                {
                    j++;                 
                    i = n;
                }
            }

            if (j > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void ListaCuadradosPerfectos (int min, int max)
        {
            for (int i = min; i <= max; i++)
            {


                if (CuadradoPerfecto(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

using System;

namespace Adicionales_Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            TrianguloEstrellitas();
        }

        static void TrianguloEstrellitas()
        {
            int n;
            Console.Write("Dime un número entre 3 y 20: ");
            n = int.Parse(Console.ReadLine());

            while ((n < 3) && (n > 20))
            {
                Console.Write("ERROR, vuelva a introducirlo: ");
            }

            for (int i = 0; i <= n; i++)
            {
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }


        }
    }


}

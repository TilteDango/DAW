using System;

namespace BuclesMas_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, cont = 0;

            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());

            for (int i = a; i > 0; i--)
            {
                if (a % i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                Console.WriteLine("El número es primo");
            }
            else
            {
                Console.WriteLine("El número no es primo");
            }
        }
    }
}

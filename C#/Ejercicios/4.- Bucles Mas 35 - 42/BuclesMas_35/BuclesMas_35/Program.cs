using System;

namespace BuclesMas_35
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.WriteLine("Dime la nota");
            n = double.Parse(Console.ReadLine());

            if (n > 10 || n < 0)
            {
                while (n > 10 || n < 0)
                {
                    Console.WriteLine("La nota no es correcta, escribe otra");
                    n = double.Parse(Console.ReadLine());
                }
            }

            if (n <= 4)
            {
                Console.WriteLine("Suspenso");
            }
            if (n >= 5 && n < 6)
            {
                Console.WriteLine("Sufieciente");
            }
            if (n >= 6 && n < 7)
            {
                Console.WriteLine("Bien");
            }
            if (n >= 7 && n < 9)
            {
                Console.WriteLine("Notable");
            }
            if (n >= 9 && n <= 10)
            {
                Console.WriteLine("Sobresaliente");
            }


        }
    }
}


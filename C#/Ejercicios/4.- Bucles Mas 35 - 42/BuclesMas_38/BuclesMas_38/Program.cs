using System;

namespace BuclesMas_38
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp, i;
            bool encontrado;

            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime otro número");
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                temp = a;
                b = a;
                a = b;
            }
            i = b;
            encontrado = false;
            while (!encontrado)
            {
               
                if (b % i == 0 && a % i == 0)
                {
                    Console.WriteLine("El máximo comun sería " + i);
                    encontrado = true;
                }
               
                i--;                               
            }
        }
    }
}

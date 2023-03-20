using System;

namespace BuclesMas_39
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, temp;
            bool minimo;

            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime otro número");
            b = int.Parse(Console.ReadLine());
            minimo = false;
            if (a > b)
            {
                temp = a;
                a = b;
                b = a;
            }
            i = a;
           
            while (!minimo)
            {
                if (i % a == 0 && i % b == 0)
                {
                    Console.WriteLine("El máximo común múltiplo es " + i);
                    minimo = true;
                }
                i++;
            }
        }

    }
}

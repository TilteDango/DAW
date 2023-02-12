using System;

namespace BuclesWhile_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, max, min;
            double total, media;
            i = 1;


            Console.WriteLine("Dime el número " + i);
            n = int.Parse(Console.ReadLine());
            i++;

            min = n;
            max = n;
            total = n; 

            while (i <= 10)
            {
                Console.WriteLine("Dime el número " + i);
                n = int.Parse(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                }


                if (n < min)
                {
                    min = n;
                }


                total = total + n;


                i++;


            }

            media = total / 10.00;

            Console.WriteLine("El número mínimo es " + min + ", el superior es " + max + " y la media aritmética es " + media);
        }

    }
}

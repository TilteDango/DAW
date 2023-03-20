using System;

namespace BuclesFor_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, min, max, i;
            double media;
            i = 1;

            Console.WriteLine("Dime un número " + i);
            n = int.Parse(Console.ReadLine());

            media = 0;
            max = n;
            min = n;
            i++;
            while (i <= 10)
            {
                Console.WriteLine("Dime un número " + i);
                n = int.Parse(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                }

                if (n < min)
                {
                    min = n;
                }


                media = media + n;

                i++;
            }

            Console.WriteLine("El minimo es " + min + ", el máximo es " + max + " y la media es " + (media / i));
        }
    }
}

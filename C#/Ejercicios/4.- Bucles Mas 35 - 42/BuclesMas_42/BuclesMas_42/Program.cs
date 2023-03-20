using System;

namespace BuclesMas_42
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(1, 101), a, i;

            Console.WriteLine("Empecemos, dime un número");
            a = int.Parse(Console.ReadLine());
            i = 1;

            while (!(a == n))
            {
                if (a > n)
                {
                    Console.WriteLine("Tu número es superior");
                    a = int.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Tu número es inferior");
                    a = int.Parse(Console.ReadLine());

                }
                
                i++;
            }

            if (i == 1)
            {
                Console.WriteLine("¡En el clavo! Eres impresionante en " + i + " intento");
            }
            else
            {
                if (i < 5)
                {
                    Console.WriteLine("¡Exacto! Solo has necesitado " + i + " intentos");
                }
                else
                {
                    if (i < 10)
                    {
                        Console.WriteLine("No esta mal, has necesitado " + i + " intentos");
                    }
                    else
                    {
                        Console.WriteLine("Eres un desgraciado, has necesitado " + i + " intentos");
                    }
                }
            }
           

        }
    }
}

using System;

namespace BuclesWhiles_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, e, h, q;

            h = 1;
            e = 0;
            q = 0;


            while (h <= 30)
            {
                Console.WriteLine("Escribe la nota " + h);
                i = int.Parse(Console.ReadLine());
                if ((i <= 10) && (i >= 0))
                {


                    if (i >= 5)
                    {
                        e++;
                        h++;
                    }

                    else
                    {
                        q++;
                        h++;
                    }
                    
                }

                else
                {
                    Console.WriteLine("Nota no válida, vuelva a introducirla");
                }
            }

            Console.WriteLine("Los aprobado son " + e + " y los suspendidos son " + q);
        }
    }
}

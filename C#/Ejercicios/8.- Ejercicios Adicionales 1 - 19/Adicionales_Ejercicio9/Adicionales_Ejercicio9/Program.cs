using System;

namespace Adicionales_Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a escribir todos los años bisiestos del siglo XXI");
            Console.WriteLine();
            Console.WriteLine();
            BisiestosXXI();
        }

        static bool Bisiesto(int n)
        {
            if (n % 4 == 0)
            {
                if (n % 100 == 0)
                {
                    if (n % 400 == 0)
                    {
                        return true;
                    }

                    return false;
                }

                return true;
            }

            else
            {
                return false;
            }
        }

        static void BisiestosXXI ()
        {
            for (int i = 2000; i <= 2100; i++)
            {
                if (Bisiesto(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

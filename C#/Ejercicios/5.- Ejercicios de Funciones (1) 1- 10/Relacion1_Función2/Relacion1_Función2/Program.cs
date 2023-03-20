using System;

namespace Relacion1_Función2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Dime el año que quieres saber si es bisiesto o no");
            n = int.Parse(Console.ReadLine());

            if (Bisiesto(n) == true)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
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
    }
}

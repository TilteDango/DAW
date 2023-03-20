using System;

namespace Relacion1_Ejecricio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Vamos a ver si tu número es par o impar");
            Console.Write("Escribe tu número: ");
            n = int.Parse(Console.ReadLine());
            if (Par(n) == true)
            {
                Console.WriteLine("Tu número es par");
            }

            else
            {
                Console.WriteLine("Tu número es impar");
            }
        }

        static bool Par (double n)
        {
            bool resultado;
            if (n % 2 == 0)
            {
                resultado = true;
            }

            else
            {
                resultado = false;
            }

            return resultado;
        }

    }
}

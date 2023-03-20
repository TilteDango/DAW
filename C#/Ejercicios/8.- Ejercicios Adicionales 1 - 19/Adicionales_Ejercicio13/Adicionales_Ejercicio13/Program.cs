using System;

namespace Adicionales_Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaNotaFinal();
        }

        static void CalculaNotaFinal()
        {
            double n, media = 0, suspensos = 0;


            for (int i = 1; i <= 7; i++)
            {




                Console.Write("Dime la nota " + i + ": ");
                n = double.Parse(Console.ReadLine());
                while (n > 10 || n < 0)
                {
                    Console.Write("Esa nota no es válida, dime otra: ");
                    n = double.Parse(Console.ReadLine());
                }

                if (n < 5)
                {
                    suspensos++;
                }
                media = media + n;

            }

            media = media / 7;

            if (suspensos >= 2 && media > 4)
            {
                media = 4;
            }

            Console.WriteLine("La media es " + media + ".");
        }

        
    }
}

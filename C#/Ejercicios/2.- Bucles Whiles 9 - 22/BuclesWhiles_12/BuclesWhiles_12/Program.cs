using System;

namespace BuclesWhiles_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            string resultado;
            Console.WriteLine("¿Quiéres números pares o impares? (par/impar)");
            resultado = Console.ReadLine();

            if (resultado == "par")
            {
                i = 0;
                while (i <= 10)
                {
                    Console.WriteLine(i);

                    i = i + 2;
                }
            }

            else
            {
                i = 1;

                while (i <= 10)
                {
                    Console.WriteLine(i);

                    i = i + 2;
                }
            }


        }
    }
}

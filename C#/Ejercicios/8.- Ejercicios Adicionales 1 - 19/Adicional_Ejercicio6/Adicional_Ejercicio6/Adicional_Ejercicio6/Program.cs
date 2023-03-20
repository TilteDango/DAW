using System;

namespace Adicional_Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Rombo();
        }
        static void Rombo()
        {
            int a, j, max;
            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());

            a = a + a;
            j = a;
            max = a;


            for (int i = 1; i <= a; i++)
            {
                while (j >= 1)
                {
                    Console.Write(" ");
                    j--;

                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("**");
                }



                Console.WriteLine();
                a = a - 1;
                j = a;
            }

            //Parte de abajo del rombo

            
            for (int i = a - 1; i >= 1 ; i--)
            {
                Console.Write("  ");

                while (j >= 1)
                {
                    Console.Write(" ");
                    j--;

                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
                a = a + 1;
                j = a;
                
            }
        }
    }
}

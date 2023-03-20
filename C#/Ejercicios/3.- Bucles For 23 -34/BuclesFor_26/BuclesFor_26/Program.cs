using System;

namespace BuclesFor_26
{
    class Program
    { 
        static void Main(string[] args)
        {

            string a;

            Console.WriteLine("pares o impares");
            a = Console.ReadLine();

            if (a == "pares")
            {
                for (int i = 2; i <= 10 ; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                if (a == "impares")
                {
                    for (int i = 1; i <= 10; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

                else
                {
                    Console.WriteLine("Opción invalida");
                }
            }

            
        }
    }
}

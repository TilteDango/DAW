using System;

namespace Estructurada_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Dime un número");
            n1 = int.Parse(Console.ReadLine());

            if (n1 >= 10 || n1 <= -10)
            {
                if (n1 >= 100 || n1 <= -100)
                {
                    if (n1 >= 1000 || n1 <= -1000)
                    {
                        if (n1 >= 10000 || n1 <= -10000)
                        {
                            Console.WriteLine("El número es de 5 cifras");
                        }
                        else
                        {
                            Console.WriteLine("El número es de 4 cifras");
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número es de 3 cifras");
                    }
                }
                else
                {
                    Console.WriteLine("El número es de 2 cifras");
                }
            }
            else
            {
                Console.WriteLine("El número es de 1 cifra");
            }
        }
    }
}
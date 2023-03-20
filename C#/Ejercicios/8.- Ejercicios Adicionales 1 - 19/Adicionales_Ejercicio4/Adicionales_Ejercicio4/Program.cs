using System;

namespace Adicionales_Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                if (n < 0)
                {
                    Console.WriteLine("-1");
                }
                else
                {                   
                    Console.WriteLine(Potencia2(n));
                }
            }
        }

        static int Potencia2(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res = res * 2;
            }

            return res;
        }
    }
}

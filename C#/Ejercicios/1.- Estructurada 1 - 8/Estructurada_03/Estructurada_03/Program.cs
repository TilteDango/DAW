using System;

namespace Estructurada_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, resultado;
            string moneda;
            Console.WriteLine("Dime el número de la moneda");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dime a que quieres convertirlo (peseta/euro)");
            moneda = Console.ReadLine();

            if (moneda == "peseta")
            {
                resultado = (n1 * 166.386);

                Console.WriteLine("Serían " + resultado + " pesetas");
            }
            else
            {
                resultado = (n1 / 166.386);

                Console.WriteLine("Serían " + resultado + " euros");
            }
        }
    }
}
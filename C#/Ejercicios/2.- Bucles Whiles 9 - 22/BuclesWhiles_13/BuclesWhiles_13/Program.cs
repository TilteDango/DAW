using System;

namespace BuclesWhiles_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num, resultado;
            i = 0;
            
            Console.WriteLine("Dime el número que quieres la tabla");
            num = int.Parse(Console.ReadLine());
            
          
            while (i <= 10)
            {
                resultado = (num * i);
                

                Console.WriteLine(num + " * " + i + " = " + resultado);

                i++;
            }
        }
    }
}

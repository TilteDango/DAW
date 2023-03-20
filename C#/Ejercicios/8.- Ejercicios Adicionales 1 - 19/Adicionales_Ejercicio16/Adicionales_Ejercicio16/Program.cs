using System;

namespace Adicionales_Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            DescomponerFactoresPrimos(24);
        }

        static void DescomponerFactoresPrimos(int n)
        {
            int cont = 0;
            Console.Write(n + " = ");
            
            for (int i = 2; n > 1; i++)
            {
                if (n % i == 0)
                {
                    if (cont == 0)
                    {
                        Console.Write(i);
                        cont++;
                        n = n / i;
                        i--;
                        
                        
                    }
                    else
                    {
                        Console.Write(" * " + i);
                        n = n / i;
                        i--;
                    }
                }
            } 
            
        }
    }
}

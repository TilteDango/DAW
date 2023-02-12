using System;

namespace BuclesWhiles_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, suma;
      
           
            suma = 0;
            i = 1;
            
            while (i <= 1000)
            {
                if (i % 2 == 0)
                {
                    suma = suma + 1;

                    
                }

                i++;
            }
               
                Console.WriteLine("La suma de todos los números pares es " + suma);
                

                
            
        }
    }
}

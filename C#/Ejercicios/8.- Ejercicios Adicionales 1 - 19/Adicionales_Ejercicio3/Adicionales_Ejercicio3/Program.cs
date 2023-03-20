using System;

namespace Adicionales_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.WriteLine("¿Cuánto tengo que devolver?");
            n = double.Parse(Console.ReadLine());

            Calderilla(n);
        }

        static void Calderilla (double n)
        {
            int nentero = (int)(n * 100); 
            int dinero = 500 - nentero, moneda2 = 0, moneda1 = 0, moneda50 = 0, moneda20 = 0, moneda10 = 0, moneda5 = 0, moneda02 = 0, moneda01 = 0;

            while (dinero >= 200)
            {
                dinero = dinero - 200;
                moneda2++;
                
            }

            while (dinero >= 100)
            {
                dinero = dinero - 100;
                moneda1++;
                
            }

            while (dinero >= 50)
            {
                dinero = dinero - 50;
                moneda50++;
                
            }

            while (dinero >= 20)
            {
                dinero = dinero - 20;
                moneda20++;
               
            }

            while (dinero >= 10)
            {
                dinero = dinero - 10;
                moneda10++;
                
            }

            while (dinero >= 5)
            {
                dinero = dinero - 5;
                moneda5++;
               
            }

            while (dinero >= 2)
            {
                dinero = dinero - 2;
                moneda02++;
               
            }

            while (dinero >= 1)
            {
                dinero = dinero - 1;
                moneda01++;
                
            }


            Console.WriteLine("La vuelta es " + moneda2 + " monedas de 2 euros, " + moneda1 + " monedas de 1 euro, " + moneda50 + " monedas de 50 cents, " + moneda20 +  " moneda de 20 cents, " + moneda10 + " monedas de 10 cents, " + moneda5 + " monedas de 5 cents, " + moneda02 + " monedas de 2 cents, " + moneda01 + " monedas de 1 cent." );
            
        }
    }
}

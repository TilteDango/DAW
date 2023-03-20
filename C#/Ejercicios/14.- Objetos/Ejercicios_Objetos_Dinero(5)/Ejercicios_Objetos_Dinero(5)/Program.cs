using System;

namespace Ejercicios_Objetos_Dinero_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Dinero.ActualizaListaInternet();
            Dinero d1 = new Dinero(5.5, TipoMoneda.euro);
            Dinero d2 = new Dinero(5.5, TipoMoneda.euro);
            Console.WriteLine("La moneda uno es:");
            Console.WriteLine(d1);
            Console.WriteLine();
            Console.WriteLine("La moneda dos es:");
            Console.WriteLine(d2);
            Console.WriteLine();
            Console.WriteLine("Las monedas son iguales:");
            Console.WriteLine(d1 == d2);
            Console.WriteLine();
            Console.WriteLine("Las monedas son diferentes:");
            Console.WriteLine(d1 != d2);
            Console.WriteLine();
            Console.WriteLine("El nuevo valor de la moneda 2 es:");
            d2.Cantidad = 6.5m;
            Console.WriteLine(d2);
            Console.WriteLine();
            Console.WriteLine("La moneda 1 es superior a la 2");
            Console.WriteLine(d1 > d2);
            Console.WriteLine();
            Console.WriteLine("La moneda 1 es inferior a la 2");
            Console.WriteLine(d1 < d2);
            Console.WriteLine();
            Console.WriteLine("La moneda 1 es igual o superior a la 2");
            Console.WriteLine(d1 >= d2);
            Console.WriteLine();
            Console.WriteLine("La moneda 1 es igual o inferior a la 2");
            Console.WriteLine(d1 <= d2);
            Console.WriteLine();
            Console.WriteLine("El valor de 1 convertido en yen es:");
            Console.WriteLine(d1.ConvierteEn(TipoMoneda.yen));
            Console.WriteLine();
            Console.WriteLine("El valor de 2 convertido en rublos es:");
           Console.WriteLine(d2.ConvierteEn(TipoMoneda.rublo));
            Console.WriteLine();
            Dinero d3 = new Dinero(345, TipoMoneda.yen);
            Console.WriteLine("El valor de 3 es de:");
            Console.WriteLine(d3);
            Console.WriteLine();
            Console.WriteLine("La moneda 3 convertida a dolares es");
            Console.WriteLine(d3.ConvierteEn(TipoMoneda.dolar));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Los datos sacados de este ejercicio han salido de la api exchangerate.host");
            Console.ForegroundColor = ConsoleColor.White;
        }
       
    }
}

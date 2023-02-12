using System;

namespace Examen_Programacion_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperatura t = new Temperatura(0, UnidadTemperatura.Celsius);
            Temperatura t1 = new Temperatura(32, UnidadTemperatura.Farenheit);
            Temperatura t2 = new Temperatura(273, UnidadTemperatura.Kelvin);
            Console.WriteLine(t);
            Console.WriteLine(t1.ConvierteEn(UnidadTemperatura.Celsius));
            Console.WriteLine(t2.ConvierteEn(UnidadTemperatura.Celsius));
            Console.WriteLine(t > t2);
            Console.WriteLine(t < t2);
            Console.WriteLine(t >= t2);
            Console.WriteLine(t <= t2);
         
        }
    }
}

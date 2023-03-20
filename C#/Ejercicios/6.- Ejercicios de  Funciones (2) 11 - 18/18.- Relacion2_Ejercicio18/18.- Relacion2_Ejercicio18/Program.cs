using System;

namespace _18.__Relacion2_Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.WriteLine("Vamos a calcular la resolución máxima de las fotos de tu cámara");
            Console.WriteLine();
            Console.Write("Dime los MegaPixeles de tu cámara: ");
            n = int.Parse(Console.ReadLine());
            n = n * 1000000;

            ResolucionCamara(n, out double altura, out double anchura);
        }

        static void ResolucionCamara(double n, out double altura, out double anchura)
        {
             anchura = Math.Sqrt(n / (16.0 / 9.0)); // anchura = y || altura = x;
             altura = n / anchura;
            Console.WriteLine();
            Console.WriteLine("La altura es " + altura + " y la anchura es " + anchura);
            
        }
    }
}

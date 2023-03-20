using System;

namespace Relacion2_Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            double cm, pulgadas, resultado;
            Console.WriteLine("Necesitas de Centimetros a pulgadas o viceversa");
            Console.WriteLine("a) Centimetros a Pulgadas");
            Console.WriteLine("b) Pulgadas a Centimetros");
            Console.WriteLine();
            Console.Write("(a / b): ");
           n = Console.ReadLine();

            while (!(n == "a" || n == "b"))
            {
                Console.WriteLine("Respuesta no válida, vuelve a intentarlo");
                Console.WriteLine("a) Centimetros a Pulgadas");
                Console.WriteLine("b) Pulgadas a Centimetros");
                Console.WriteLine();
                Console.Write("(a / b): ");
                n = Console.ReadLine();
            }

      

            if (n == "a")
            {
                Console.WriteLine();
                Console.WriteLine("Introduce los centimetros");
                cm = double.Parse (Console.ReadLine());
                resultado = CentimetrosaPulgadas(cm);

                Console.WriteLine(cm + " centimetros son " + resultado + " pulgadas");

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Introduce las pulgadas");
                pulgadas = double.Parse(Console.ReadLine());
                resultado = PulgadasACentimetros(pulgadas);

                Console.WriteLine(pulgadas + " pulgadas son " + resultado + " centimetros");


                
            }
        }

        static double PulgadasACentimetros (double a)
        {
            double cm;

            cm = a * 0.39370;

            return cm;
        }

        static double CentimetrosaPulgadas (double a)
        {
            double pulgadas;

            pulgadas = a / 0.39370;

            return pulgadas;
        }
    }
}

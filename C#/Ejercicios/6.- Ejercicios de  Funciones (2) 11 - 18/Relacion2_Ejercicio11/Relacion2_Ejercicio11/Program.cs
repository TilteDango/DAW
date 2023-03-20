using System;

namespace Relacion2_Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, res;

            Console.WriteLine("Vamos a calcular el área de tu triangulo");
            Console.WriteLine();
            Console.Write("Dime la base: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dime la altura: ");
            b = int.Parse(Console.ReadLine());
            res = areaTriangulo(a, b);

            Console.WriteLine("El área del triangulo es: " + res);
        }
        
        static int areaTriangulo (int basse, int altura)
        {
            int resultado;
            resultado = basse * altura;

            return resultado;
        }
    }
}

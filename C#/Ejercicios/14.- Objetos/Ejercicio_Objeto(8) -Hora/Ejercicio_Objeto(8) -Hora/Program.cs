using System;

namespace Ejercicio_Objeto_8___Hora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Hora h1 = new Hora(3600);
            Hora h2 = new Hora(5498);
            while (n != 0)
            {
                Console.WriteLine("Horas, Minutos y Segundos");
                Console.WriteLine("1. Crear horas");
                Console.WriteLine("2. Sumas horas");
                Console.WriteLine("3. Restar horas");
                Console.WriteLine("4. Escribe horas");
                Console.WriteLine("0. Salir");
                n = int.Parse(Console.ReadLine());


                switch (n)
                {
                    case 1:
                        Console.Write("Escribe las horas: ");
                        int horas = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Escribe los minutos: ");
                        int minutos = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Escribe los segundos: ");
                        int segundos = int.Parse(Console.ReadLine());

                        Hora h = new Hora(horas, minutos, segundos);
                        Console.WriteLine(h);
                        
                        break;
                    case 2:
                        
                        Console.Write(h1 +" + " + h2 + "= ");
                        Console.Write(h1 + h2);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write(h2 + " - " + h1 + "= ");
                        Console.Write(h2 - h1);
                        Console.WriteLine();
                        break;
                    case 4:

                        Console.WriteLine(h1); break;

                }
            }
        }
    }
}

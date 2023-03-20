using System;
using System.IO;

namespace Ejercicio_Objetos__10__Venta_De_Coches
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            bool modificado = false;
            AutoVenta av = new AutoVenta();
            if (File.Exists("prueba.csv"))
            {
                av.CargaCSV("prueba.csv");
            }
            while (n != 0)
            {
                Console.Clear();
                Console.WriteLine("AutoVentas Sanlúcar");
                Console.WriteLine("1.- Insertar coche");
                Console.WriteLine("2.- Buscar coche");
                Console.WriteLine("3.- Imprime lista coches");
                Console.WriteLine("0.- Salir");
                 n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    
                    case 1:
                        Console.Clear();
                        string matricula, marca, modelo;
                        int dia, mes, anno;
                        double precio;
                        Console.WriteLine();
                        Console.Write("Dime la matricula del coche: ");
                        matricula = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Dime el año de matriculación: ");
                        anno = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Dime el mes de matriculación: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Dime el día de matriculación: ");
                        dia = int.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.Write("Dime la marca del coche: ");
                        marca = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Dime el modelo del coche: ");
                        modelo = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Dime el precio del coche: ");
                        precio = double.Parse(Console.ReadLine());

                        Coche a = new Coche(matricula, new DateTime(anno, mes, dia), marca, modelo, precio);
                        modificado = true;
                        av.InsertaCoche(a);
                        break;
                    case 2:
                        Console.Clear();
                        string buscar;
                        Coche ch;
                        Console.WriteLine("Dime la matricula del coche: ");
                        buscar = Console.ReadLine();
                        ch = av.BuscaCoche(buscar);
                        Console.WriteLine(ch);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(av);
                        Console.ReadKey(); break;
                    default:
                        if (modificado)
                        {
                            av.GuardaCSV("prueba.csv");
                        }
                        Environment.Exit(0); break;                        
               }

            }

           

        }
    }
}

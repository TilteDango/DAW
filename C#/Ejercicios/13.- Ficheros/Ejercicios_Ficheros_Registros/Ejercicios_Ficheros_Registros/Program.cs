using System;
using System.Collections.Generic;
using System.IO;

namespace Ejercicios_Ficheros_Registros
{
    class Program
    {
        public class FichaAlumno
        {
            public string nombre;
            public int edad;
            public double calificacion;
        }

        static void Menu()
        {
            int n = 1;
            Console.Clear();
            List<FichaAlumno> listaAlumnos = new List<FichaAlumno>();

            

            while (n != 0)
            {
                Console.WriteLine("1. LeeAlumnoLista");
                Console.WriteLine("2. ImprimeListaAlumnos");
                Console.WriteLine("3. EscribeFicheroAlumnosBinario");
                Console.WriteLine("4. LeeFicheroAlumnosBinario");
                Console.WriteLine("5. EscribeFicheroAlumnosTexto");
                Console.WriteLine("6. LeeFicheroAlumnosTexto");
                Console.WriteLine("7. EscribeFicheroAlumnosCSV");
                Console.WriteLine("8. LeeFicheroAlumnosCSV");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Introduzca un número: ");
                n = int.Parse(Console.ReadLine());

                Console.WriteLine("==============================================================");

                switch (n)
                {
                    case 1:
                        {
                            LeeAlumnoLista(listaAlumnos);
                        }
                        break;

                    case 2:
                        {
                            ImprimeListaAlumnos(listaAlumnos);
                        }
                        break;

                    case 3:
                        {
                          
                            EscribeFicheroAlumnosBinario(listaAlumnos, "eje3.bin");
                        }
                        break;

                    case 4: 
                        {
                            LeeFicheroAlumnosBinario(listaAlumnos, "eje3.bin");
                        }
                        break;

                    case 5:
                        {
                            FichaAlumno fa2 = new FichaAlumno();
                            fa2.nombre = "Pedro";
                            fa2.edad = 23;
                            fa2.calificacion = 7.2;
                            listaAlumnos.Add(fa2);

                            EscribeFicheroAlumnosTexto(listaAlumnos, "eje5.txt");
                        }
                        break;

                    case 6:
                        {
                            LeeFicheroAlumnosTexto(listaAlumnos, "eje5.txt");
                        }
                        break;

                    case 7:
                        {
                            FichaAlumno fa3 = new FichaAlumno();
                            fa3.nombre = "Pedro";
                            fa3.edad = 23;
                            fa3.calificacion = 7.2;
                            listaAlumnos.Add(fa3);
                            EscribeFicheroAlumnosCSV(listaAlumnos, "eje7.csv");
                        }
                        break;

                    case 8:
                        {
                            LeeFicheroAlumnosCSV(listaAlumnos, "eje7.csv");
                        }
                        break;

                    case 0:
                        {
                            
                        }
                        break;


                    default:
                        break;
                }
                Console.WriteLine("==================================");
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }

        static void LeeAlumnoLista (List<FichaAlumno> listaAlumnos)
        {
            FichaAlumno fa = new FichaAlumno();
            Console.Write("Introduzca el nombre del alumno: ");
            fa.nombre = Console.ReadLine();
            Console.Write("Introduzca la edad del alumno: ");
            fa.edad = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la calificación del alumno: ");
            fa.calificacion = double.Parse(Console.ReadLine());

            listaAlumnos.Add(fa);

          
        }

        static void ImprimeListaAlumnos (List<FichaAlumno> listaAlumnos)
        {
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                Console.WriteLine(listaAlumnos[i].nombre +" "+ listaAlumnos[i].edad +" "+ listaAlumnos[i].calificacion);
            }
        }

        static void EscribeFicheroAlumnosBinario (List<FichaAlumno> listaAlumnos, string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            int n = listaAlumnos.Count;
            bw.Write(n);

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                bw.Write(listaAlumnos[i].nombre);
                bw.Write(listaAlumnos[i].edad);
                bw.Write(listaAlumnos[i].calificacion);
            }

            bw.Close();
            fs.Close();
        }

        static void LeeFicheroAlumnosBinario(List<FichaAlumno> listaAlumnos, string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            listaAlumnos.Clear();
            
            int  n = br.ReadInt32();

            while (fs.Position < fs.Length)
            {
                FichaAlumno fa = new FichaAlumno();
                fa.nombre = br.ReadString();
                fa.edad = br.ReadInt32();
                fa.calificacion = br.ReadDouble();

                listaAlumnos.Add(fa);
            }
               
            

            br.Close();
            fs.Close();

            ImprimeListaAlumnos(listaAlumnos);
        }

        static void EscribeFicheroAlumnosTexto (List<FichaAlumno> listaAlumnos, string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                sw.WriteLine(listaAlumnos.Count);
                sw.WriteLine($"{listaAlumnos[i].nombre}");
                sw.WriteLine($"{listaAlumnos[i].edad}");
                sw.WriteLine($"{listaAlumnos[i].calificacion}");
            }

            sw.Close();
        }

        static void LeeFicheroAlumnosTexto (List<FichaAlumno> listaAlumnos, string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            listaAlumnos.RemoveRange(0, listaAlumnos.Count);
            FichaAlumno fa = new FichaAlumno();
            int n = int.Parse(sr.ReadLine());


            for (int i = 0; i < n; i++)
            {
                fa.nombre = sr.ReadLine();
                fa.edad = int.Parse(sr.ReadLine());
                fa.calificacion = double.Parse(sr.ReadLine());

                listaAlumnos.Add(fa);
            }
            ImprimeListaAlumnos(listaAlumnos);
        }

        static void EscribeFicheroAlumnosCSV (List<FichaAlumno> listaAlumnos, string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                sw.Write($"{listaAlumnos[i].nombre}" + ";");
                sw.Write($"{listaAlumnos[i].edad}" + ";");
                sw.Write($"{listaAlumnos[i].calificacion}" + ";");
                sw.WriteLine();
            }

            sw.Close();
        }

        static void LeeFicheroAlumnosCSV (List<FichaAlumno> listaAlumnos, string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            string[] palabras;
            listaAlumnos.RemoveRange(0, listaAlumnos.Count);
            FichaAlumno fa = new FichaAlumno();
            while (!sr.EndOfStream)
            {
                palabras = sr.ReadLine().Split(';');

                for (int i = 0; i < palabras.Length -3; i = i +3)
                {
                    fa.nombre = palabras[i];
                    fa.edad = int.Parse(palabras[i + 1]);
                    fa.calificacion = double.Parse(palabras[i + 2]);
                    listaAlumnos.Add(fa); 
                }

            }
            ImprimeListaAlumnos(listaAlumnos);
            sr.Close();
        }
    }
}

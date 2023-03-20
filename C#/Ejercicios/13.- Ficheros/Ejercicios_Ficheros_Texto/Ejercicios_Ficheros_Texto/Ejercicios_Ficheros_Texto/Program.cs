using System;
using System.Collections.Generic;
using System.IO;

namespace Ejercicios_Ficheros_Texto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. EscribeFicheroNumRandom10");
            Console.WriteLine("2. SumaFicheroInt10");
            Console.WriteLine("3. EscribeFicheroNumRandom");
            Console.WriteLine("4. SumaFicheroInt");
            Console.WriteLine("5. EscribeFicheroTexto");
            Console.WriteLine("6. LeeFicheroTexto");
            Console.WriteLine("7. CopiaFicheroTexto");
            Console.WriteLine("8. InvierteLineasFichero");
            Console.WriteLine("9. InvierteFicheroTexto");
            Console.WriteLine("10. SeparaPalabrasFichero");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Escoja la opción que quiera comprobar: ");            
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (n)
            {
                case 1:
                    {
                        string fichero = "fichero.txt";
                        EscribeFicheroNumRandom10(fichero);
                    }
                    break;

                case 2:
                    {
                        string fichero = "fichero.txt";
                        Console.WriteLine(SumaFicheroInt10(fichero));
                    }
                    break;

              
                case 3:
                    {
                        int numero = 20;
                        string fichero = "ficheron.txt";
                        EscribeFicheroNumRandom(fichero, numero);
                    }
                    break;

                case 4:
                    {
                        string fichero = "ficheron.txt";
                        Console.WriteLine(SumaFicheroInt(fichero));
                    }
                    break;

                case 5:
                    {
                        string fichero = "escribefichero.txt";
                        EscribeFicheroTexto(fichero);
                    }
                    break;

                case 6:
                    {
                        string fichero = "escribefichero.txt";
                        LeeFicheroTexto(fichero);
                    }
                    break;

                case 7:
                    {
                        string fichero = "escribefichero.txt";
                        string copia = "copia7.txt";
                        CopiaFicheroTexto(fichero, copia);
                    }
                    break;

                case 8:
                    {
                        string fichero = "escribefichero.txt";
                        string copia = "copia8.txt";
                        InvierteLineasFichero(fichero, copia);
                    }
                    break;

                case 9:
                    {
                        string fichero = "ejercicio9.txt";
                       
                        InvierteFicheroTexto(fichero);
                    }
                    break;

                case 10:
                    {
                        string fichero = "ejercicio10a.txt";
                        string copia = "ejercicio10copia.txt";
                        SeparaPalabrasFichero(fichero, copia);
                    }
                    break;

                default:
                    break;
            }
        }

        static void EscribeFicheroNumRandom10(string fichero)
        {

            StreamWriter sw = new StreamWriter(fichero);
            int n;
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                n = r.Next(1, 101);
                sw.WriteLine(n);
            }

            sw.Close();
        }

        static int SumaFicheroInt10 (string fichero)
        {
            int suma = 0, n;
            StreamReader sr = new StreamReader(fichero);

            for (int i = 0; i < 10; i++)
            {
                n = int.Parse(sr.ReadLine());
                suma = suma + n; 
            }

            sr.Close();

            return suma;
        }

        static void EscribeFicheroNumRandom (string fichero, int n)
        {
            StreamWriter sw = new StreamWriter(fichero);
            int s;
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                s = r.Next(1, 101);
                sw.WriteLine(s);
            }

            sw.Close();
        }

        static int SumaFicheroInt(string fichero)
        {
            int suma = 0, n;
            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                n = int.Parse(sr.ReadLine());
                suma = suma + n;
            }
 
            sr.Close();

            return suma;
        }

        static void EscribeFicheroTexto (string fichero)
        {
            string n = "base";
            StreamWriter sr = new StreamWriter(fichero);

            while (n !="")
            {
                Console.Write("Dime una línea de texto a escribir: ");
                n = Console.ReadLine();

                sr.WriteLine(n);
            }

            sr.Close();
        }

        static void LeeFicheroTexto (string fichero)
        {
            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }

        static void CopiaFicheroTexto (string fichero, string copia)
        {
            string n;
            StreamReader sr = new StreamReader(fichero);
            StreamWriter sw = new StreamWriter(copia);

            while (!sr.EndOfStream)
            {
                n = sr.ReadLine();
                sw.WriteLine(n);
            }

            sr.Close();
            sw.Close();
        }

        static void InvierteLineasFichero (string fichero, string copia)
        {

            string cadena, cadena2;
            StreamWriter sw = new StreamWriter(copia);
            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                cadena = sr.ReadLine();
                cadena2 = InvierteCadena(cadena);
                sw.WriteLine(cadena2);                
            }

            sr.Close();
            sw.Close();
        }

        static string InvierteCadena(string cad)
        {
            string aux = "";

            for (int i = cad.Length - 1; i >= 0; i--)
            {
                aux = aux + cad[i];
            }
            return aux;
        }

        static void InvierteFicheroTexto (string fichero)
        {
          
            List<string> frases = new List<string>();
            StreamReader sr = new StreamReader(fichero);
            

            while (!sr.EndOfStream)
            {
                frases.Add(sr.ReadLine());
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(fichero);

            for (int i = frases.Count -1; i >= 0; i--)
            {
                sw.WriteLine(frases[i]);
            }

            sw.Close();
            
        }

        static void SeparaPalabrasFichero (string fichero, string palabras)
        {
            StreamReader sr = new StreamReader(fichero);
            StreamWriter sw = new StreamWriter(palabras);

            string frases;
            string[] separadas;

            while (!sr.EndOfStream)
            {
                frases = sr.ReadLine();
                separadas = frases.Split(' ');

                for (int i = 0; i < separadas.Length; i++)
                {
                    sw.WriteLine(separadas[i]);
                }
            }

            sw.Close();
            sr.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace Ejercicios_Directorios
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("1. CuantosFicheros");
            Console.WriteLine("2. CuantosFicherosPro");
            Console.WriteLine("3. CreaBackup");
            Console.WriteLine("4. RenombraMasivo");
            Console.WriteLine("5. CuentaLineasFicheros");
            Console.WriteLine("6. FicheroMasGrande");
            Console.WriteLine("7. ClasificaFicheros");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Inserta el número que quieras resolver: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (n)
            {

                case 1:
                    Console.WriteLine(CuantosFicheros(".txt"));
                    break;

                case 2:
                    Console.WriteLine(CuantosFicherosPro(".exe", "C:\\Windows"));
                    break;
                case 3:
                    CreaBackUp("nuevo.txt");
                    break;

                case 4:
                    RenombraMasvio(".txt", ".texto");
                    break;
              
                case 5:
                    Console.WriteLine(CuentaLineasFicheros(".txt"));
                    break;

                case 6:
                    Console.WriteLine(FicheroMasGrande());
                    break;
                case 7:
                    ClasificaFicheros();
                    break;
                   
            }
        }


        static int CuantosFicheros (string ext)
        {
            string cf = Directory.GetCurrentDirectory();
            int n = 0;
            string[] ficheros = Directory.GetFiles(cf);
           
            for (int i = 0; i < ficheros.Length; i++)
            {
                FileInfo f = new FileInfo(ficheros[i]);
                if (f.Extension == ext)
                {
                    n++;
                }
            }

            return n;
        }

        static int CuantosFicherosPro (string ext, string fichero)
        {
            int n = 0;
            string[] ficheros = Directory.GetFiles(fichero);

            for (int i = 0; i < ficheros.Length; i++)
            {
                FileInfo f = new FileInfo(ficheros[i]);
                if (f.Extension == ext)
                {
                    n++;
                }
            }

            return n;
        }

        static void CreaBackUp (string fichero)
        {


            while (File.Exists(fichero + ".bak"))
            {
                fichero = fichero + ".bak";
            }

            File.Copy(fichero, fichero + ".bak");

        }

        static void RenombraMasvio ( string ext1, string ext2)
        {
            string cf = Directory.GetCurrentDirectory();
            string[] ficheros = Directory.GetFiles(cf);
            string ext, archivo;

            for (int i = 0; i < ficheros.Length; i++)
            {
                ext = Path.GetExtension(ficheros[i]);

                if (ext == ext1)
                {
                    archivo = Path.GetFileNameWithoutExtension(ficheros[i]) + ext2;
                    File.Move(ficheros[i], archivo);
                }
            }
        }

        static int CuentaLineasFicheros (string ext1)
        {
            string cf = Directory.GetCurrentDirectory();
            string[] ficheros = Directory.GetFiles(cf);
            int n = 0;
            string ext;

            for (int i = 0; i < ficheros.Length; i++)
            {
                ext = Path.GetExtension(ficheros[i]);

                if (ext == ext1)
                {
                    StreamReader sr = new StreamReader(ficheros[i]);

                    while (!sr.EndOfStream)
                    {
                        sr.ReadLine();
                        n++;
                    }
                }
            }

            return n;


        }

        static string FicheroMasGrande()
        {
            string cf = Directory.GetCurrentDirectory();
            string[] ficheros = Directory.GetFiles(cf);
            string max = ficheros[0];
            long by = 0;

            for (int i = 0; i < ficheros.Length; i++)
            {
                FileInfo f = new FileInfo(ficheros[i]);
                
                 
                if (f.Length > by)
                {
                    by = f.Length;
                    max = f.Name;
                }
            }

            return max;

            
        }

        static void ClasificaFicheros()
        {
            string cf = Directory.GetCurrentDirectory();
            string[] ficheros = Directory.GetFiles(cf);
            Dictionary<string, int> dict1 = new Dictionary<string, int>();

            for (int i = 0; i < ficheros.Length; i++)
            {

                if (dict1.ContainsKey(Path.GetExtension(ficheros[i])))
                {
                    dict1[Path.GetExtension(ficheros[i])]++;
                }
                else
                {
                    dict1[Path.GetExtension(ficheros[i])] = 1;
                }
            }

            foreach (KeyValuePair<string, int> pareja in dict1)
            { 
                Console.WriteLine(pareja.Key + " -> " + pareja.Value);
            }
        }


    }
}

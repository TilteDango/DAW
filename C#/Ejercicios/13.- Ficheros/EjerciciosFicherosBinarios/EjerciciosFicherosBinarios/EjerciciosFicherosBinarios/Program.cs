using System;
using System.Collections.Generic;
using System.IO;
namespace EjerciciosFicherosBinarios
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("11. EscribeFichero1_100");
            Console.WriteLine("12. LeeFicheroInt100");
            Console.WriteLine("13. EscribeFicheroIntAleatorio");
            Console.WriteLine("14. EscribeFicheroIntAleatorio");
            Console.WriteLine("15. LeeFicheroInt");
            Console.WriteLine("16. SumaFicheroInt");
            Console.WriteLine("17. LeeFicheroIntLista");
            Console.WriteLine("18. EscribeFicheroIntLista");
            Console.WriteLine("19. OrdenaFicheroInt");
            Console.WriteLine("20. SeparaFicheroInt");
            Console.WriteLine("21. InvierteFicheroInt");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Escoja el número que quiera corregir: ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {

                case 1:
                    {
                        EscribeFichero1_100("datos02.bin");
                    }
                    break;

                case 2:
                    {
                        LeeFicheroInt100("datos01.bin");
                    }
                    break;
                case 3:
                    {
                        EscribeFicheroIntAleatorio("ejercicio03.bin", 3);
                    }
                    break;

                case 4:
                    {
                        EscribeFicheroIntAleatorioPro("datos.bin", 10, -5, 5);
                    }
                    break;

                case 5:
                    {
                        LeeFicheroInt("datos.bin");
                    }
                    break;

                case 6:
                    {
                        Console.WriteLine(SumaFicheroInt("datos.bin"));
                    }
                    break;

                case 7:
                    {
                        List<int> lista = LeeFicheroIntLista("datos.bin");

                    }

                    break;

                case 8:
                    {
                        List<int> lista = LeeFicheroIntLista("datos01.bin");
                        EscribeFicheroIntLista("lista.bin", lista);
                    }
                    break;

                case 9:
                    {
                        OrdenaFicheroInt("datos.bin");
                    }
                    break;

                case 10:
                    {
                        SeparaFicheroInt("datos.bin");
                    }
                    break;

                case 11:
                    {
                        InvierteFicheroInt("datos02.bin");
                    }
                    break;

                default:
                    break;
            }


        }

        static void EscribeFichero1_100(string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 1; i <= 100; i++)
            {
                bw.Write(i);
            }

            bw.Close();
            fs.Close();
        }

        static void LeeFicheroInt100(string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            int n;
            for (int i = 0; i <= 100; i++)
            {
                n = br.ReadInt32();
                Console.WriteLine(n);
            }

            br.Close();
            fs.Close();


        }

        static void EscribeFicheroIntAleatorio(string fichero, int veces)
        {
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            int n;
            Random r = new Random();

            for (int i = 0; i < veces; i++)
            {
                n = r.Next(1, 101);
                bw.Write(n);
            }

            bw.Close();
            fs.Close();
        }

        static void EscribeFicheroIntAleatorioPro(string fichero, int veces, int min, int max)
        {
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            int n;
            Random r = new Random();

            for (int i = 0; i < veces; i++)
            {
                n = r.Next(min, max);
                bw.Write(n);
            }

            bw.Close();
            fs.Close();
        }

        static void LeeFicheroInt(string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int n;

            while (fs.Position < fs.Length)
            {
                n = br.ReadInt32();
                Console.WriteLine(n);
            }

            br.Close();
            fs.Close();
        }

        static int SumaFicheroInt(string fichero)
        {
            int n, suma = 0;
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            

            while (fs.Position < fs.Length)
            {
                n = br.ReadInt32();
                suma = suma + n; 
            }

            br.Close();
            fs.Close();

            return suma;
        }

        static List<int> LeeFicheroIntLista (string fichero)
        {
            List<int> lista = new List<int>();
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            int n;

            while (fs.Position < fs.Length)
            {
                n = br.ReadInt32();
                lista.Add(n);
            }

            br.Close();
            fs.Close();

            return lista;


        }

        static void EscribeFicheroIntLista(string fichero, List<int> lista) 
        {
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < lista.Count; i++)
            {
                bw.Write(lista[i]);
            }

            bw.Close();
            fs.Close();
        }

        static void OrdenaFicheroInt (string fichero)
        {
            List<int> lista = LeeFicheroIntLista(fichero);
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            lista.Sort();

            for (int i = 0; i < lista.Count; i++)
            {
                bw.Write(lista[i]);
            }

            bw.Close();
            fs.Close();



        }

        static void SeparaFicheroInt (string fichero)
        {
            FileStream fsp = new FileStream(fichero+"positivo", FileMode.Create);
            BinaryWriter bwp = new BinaryWriter(fsp);
            FileStream fsn = new FileStream(fichero +"negativo", FileMode.Create);
            BinaryWriter bwn = new BinaryWriter(fsn);
            List<int> lista = LeeFicheroIntLista(fichero);

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > 0)
                {
                    bwp.Write(lista[i]);
                }
                else
                {
                    if (lista[i] < 0)
                    {
                        bwn.Write(lista[i]);
                    }
                }
            }

            bwp.Close();
            bwn.Close();
            fsn.Close();
            fsp.Close();
        }

        static void InvierteFicheroInt (string fichero)
        {
          List<int> lista = LeeFicheroIntLista(fichero);
            lista.Reverse();

            EscribeFicheroIntLista(fichero, lista);

        }
       
    }
}

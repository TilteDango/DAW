using System;
using System.IO;

namespace Ficheros_Binarios_Adicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            switch (n)
            {

                case 1:
                    {
                        ImprimeJornada("jornada3");
                    }
                    break;

                case 2:
                    {
                        LeeColorinesConsola("colorines4.color");
                    }
                    break;

                case 3:
                    {
                        LeeJuegoEnRaya("4x4.ttt");
                    }
                    break;

                case 4:
                    {
                        ASCIIArt("eiffel.bin");
                    }
                    break;

                case 5:
                    {
                        PintaBandera("esp.flag");
                    }
                    break;

                case 6:
                    {
                        EstadisticasNBA("Ej6");
                    }
                    break;

                case 7: break;
                case 8:
                    {
                        SuperCodificadorPlus("Quijote_Codificado2.txt","Quijote.txt");
                    }
                    break;
                default:
                    break;
            }

        }

        static void ImprimeJornada (string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            string local, visit;
            int golloc, golvisit;

            for (int i = 0; i < 10; i++)
            {
                local = br.ReadString();
                visit = br.ReadString();
                golloc = br.ReadInt32();
                golvisit = br.ReadInt32();

                Console.WriteLine(local.PadLeft(11) +" " +golloc + " - " + golvisit +" " + visit.PadRight(11));
            }

            fs.Close();
            br.Close();
        }

        static void LeeColorinesConsola (string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            for (int i = 0; i < 10; i++)
            {
                
                for (int k = 0; k < 10; k++)
                {
                    int color = br.ReadInt32();

                    switch (color)
                    {
                        case 0: Console.BackgroundColor = ConsoleColor.Black; break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            break;
                        case 4:
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            break;
                        case 5:
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            break;
                        case 6:
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;
                        case 7:
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;
                        case 8:
                            Console.BackgroundColor = ConsoleColor.DarkGray;

                            break;
                        case 9:
                            Console.BackgroundColor = ConsoleColor.Blue;

                            break;
                        case 10:
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                        case 11:
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            break;
                        case 12:
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;
                        case 13:
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            break;
                        case 14:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;
                        case 15:
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                        default:
                            Console.BackgroundColor = ConsoleColor.Black; break;
                    }

                    Console.Write(" ");
                }


                Console.WriteLine();

               
            }
            fs.Close();
            br.Close();
        }

        static void LeeJuegoEnRaya (string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            int tamaño = br.ReadInt32(), juego;
            char ficha = '.';
            for (int i = 0; i < tamaño; i++)
            {
                for (int k = 0; k < tamaño; k++)
                {
                    juego = br.ReadInt32();

                    switch (juego)
                    {
                        case 0:  ficha = '.'; break;
                        case 1: ficha = 'X'; break;
                        case 2: ficha = 'O';  break;
                    
                        default:
                            break;
                    }

                    Console.Write(ficha + " ");
                }
                Console.WriteLine();
                
            }
            fs.Close();
            br.Close();
        }

        static void ASCIIArt (string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int x, y;
            char c;

            Console.Clear();

            while (fs.Position < fs.Length)
            {
                x = br.ReadInt32();
                y = br.ReadInt32();
                c = br.ReadChar();

                Console.SetCursorPosition(x, y);
                Console.Write(c);
            }
            fs.Close();
            br.Close();
        }

        static void PintaBandera(string fichero)
        {

            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int x, y, color;
            x = br.ReadInt32();
            y = br.ReadInt32();

            for (int i = 0; i < x; i++)
            {
                for (int k = 0; k < y; k++)
                {
                    color = br.ReadInt32();

                    switch (color)
                    {
                        case 1: Console.BackgroundColor = ConsoleColor.Red; break;
                        case 2: Console.BackgroundColor = ConsoleColor.Yellow; break;
                        case 3: Console.BackgroundColor = ConsoleColor.Blue; break;
                        case 4: Console.BackgroundColor = ConsoleColor.Green; break;
                        case 5: Console.BackgroundColor = ConsoleColor.White; break;
                        case 6: Console.BackgroundColor = ConsoleColor.Black; break;
                       
                        default:
                            break;
                    }

                    Console.Write(' ');
                }
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.Black;

            fs.Close();
            br.Close();


        }

        static void EstadisticasNBA (string fichero)
        {
            
            string [] ficheros = Directory.GetFiles(fichero);
            string[] nombres = new string [ficheros.Length], aux = new string [ficheros.Length];
            double[] resultado = new double [ficheros.Length], auxres = new double [ficheros.Length];
            double puntos = 0, cont = 0, media;
            bool escribir = false;
            string cad = "";
            double max;
            int conti = 0;
            for (int i = 0; i < ficheros.Length; i++)
            {
                FileStream fs = new FileStream(ficheros[i], FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                cont = 0;
                puntos = 0;

                while (fs.Position < fs.Length)
                {
                    puntos = puntos + br.ReadInt32();
                    cont++;

                }

                media = Math.Round(puntos / cont, 2);

                nombres[i] = ficheros[i];
                resultado[i] = media;

                br.Close();
                fs.Close();
            }
            
            for (int i = 0; i < nombres.Length; i++)
            {
                cad = "";
                for (int k = 0; k < nombres[i].Length; k++)
                {
                    if (nombres[i][k] != '.' && escribir)
                    {
                        cad = cad + nombres[i][k];
                    }
                    else
                    {
                        if (nombres[i][k] == '6')
                        {
                            escribir = true;
                            k++;
                        }
                        else
                        {
                            if (nombres[i][k] == '.')
                            {
                                escribir = false;
                            }
                        }
                    }
                   
                }

                nombres[i] = cad;
            }

            for (int i = 0; i < resultado.Length; i++)
            {

                max = resultado[0];

               for (int k = 0; k < resultado.Length; k++)
                {
                   if (resultado[k] > max)
                   {
                       max = resultado[k];
                    }
                }

                for (int k = 0; k < resultado.Length; k++)
                {
                    if (max == resultado[k])
                    {
                        aux[conti] = nombres[k];
                        auxres[conti] = resultado[k];
                       resultado[k] = 0;
                        k = resultado.Length;
                   }
                }
                conti++;
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(aux[i].PadRight(30) +  auxres[i]);
            }

        }

        static void NuevoFormatoBanco (string fichero) {
        
        
        
        }

        static void SuperCodificadorPlus (string fichero, string copia)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            FileStream fs2 = new FileStream(copia, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs2);
            byte b;

            while (fs.Position < fs.Length)
            {
                b = br.ReadByte();

                if (b <= 127)
                {
                     b = (byte)(b + 127);
                }
                else
                {
                    b = (byte)(b - 127);
                }

                bw.Write(b);
            }

            bw.Close();
            fs2.Close();
            br.Close();
            fs.Close();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Adicionales_Bidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;

            switch (n)
            {

                case 1:
                    {
                        int[,] a = { { 1, 2, 3, 4 }, 
                                    { 10, 20, 30, 120 },
                                    { 350, 40, 50, 60 },
                                    { 90, 70, 100, 20 } };

                        EscribeArrayBi(a);
                        Console.WriteLine();
                        InvierteBi(a);
                        EscribeArrayBi(a);
                    }
                    break;

                case 2:
                    {
                        int[,] a = { { 1, 2, 3 },
                                    { 6, 5, 4},
                                    { 7, 8, 9}};

                        Console.WriteLine(CalculaDeterminante(a));
                    }
                    break;

                case 3:
                    {
                        int[,] a = { { 4, 9, 2 },
                                    { 3, 5, 7},
                                    { 8, 1, 6}};

                        Console.WriteLine(CuadradoMagico(a));
                    }
                    break;

                case 4:
                    {
                        int[,] sudoku = { { 5, 3, 4, 6, 7, 8, 9, 1, 2 }, 
                                            { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                                            { 1, 9, 8, 3, 4, 2, 5, 6, 7 }, 
                                            { 8, 5, 9, 7, 6, 1, 4, 2, 3 }, 
                                            { 4, 2, 6, 8, 5, 3, 7, 9, 1 }, 
                                            { 7, 1, 3, 9, 2, 4, 8, 5, 6 }, 
                                            { 9, 6, 1, 5, 3, 7, 2, 8, 4 }, 
                                            { 2, 8, 7, 4, 1, 9, 6, 3, 5 }, 
                                            { 3, 4, 5, 2, 8, 6, 1, 7, 9 } };

                        Console.WriteLine(CompruebaSudoku(sudoku));
                    }
                    break;
                case 5:
                    {
                        int[,] a = new int[4, 6];

                        RellenaBordeBidimensional(a, 1, 0);
                        EscribeArrayBi(a);
                    }
                    break;


                default:
                    break;
            }
        }

        static void EscribeArrayBi(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void EscribeArray(bool[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(a[i] + ",");
                }
                else
                {

                    if (i == a.Length - 1)
                    {
                        Console.Write(" " + a[i]);
                    }
                    else
                    {
                        Console.Write(" " + a[i] + ",");
                    }
                }

            }

            Console.WriteLine("]");
        }

        static void EscribeArrayi(int[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(a[i] + ",");
                }
                else
                {

                    if (i == a.Length - 1)
                    {
                        Console.Write(" " + a[i]);
                    }
                    else
                    {
                        Console.Write(" " + a[i] + ",");
                    }
                }

            }

            Console.WriteLine("]");
        }

        static void InvierteBi (int[,] a)
        {
            int tmp;
            for (int y = 0; y < a.GetLength(0); y++)
            {
                
                    for (int x = y+1; x < a.GetLength(1); x++)
                    {
                   // if (y >= x)
                   // {
                        tmp = a[x, y];
                        a[x, y] = a[y, x];
                        a[y, x] = tmp;
                   // }
                        
                    }
                                            
            }
        }

        static int CalculaDeterminante (int [,] a )
        {
            int resultado;
            resultado =a[0, 0] * a[1, 1] * a[2, 2] + a[0, 1] * a[1, 2] * a[2, 0] + a[1, 0] * a[2, 1] * a[0, 2] - a[0, 2] * a[1, 1] * a[2, 0] - a[0, 1] * a[1, 0] * a[2, 2] - a[1, 2] * a[2, 1] * a[0, 0];

            return resultado;
        }

        static bool CuadradoMagico (int [,] a)
        {
            int cont = 0;
            int[] sumas = new int[8];
            bool igual = false;

            for (int y = 0; y < a.GetLength(0); y++)
            {                
                for (int x = 0; x < a.GetLength(1); x++)
                {
                   sumas[cont] = sumas[cont] + a[x, y];
                    
                }
                cont++;
            }

            for (int y = 0; y < a.GetLength(0); y++)
            {
                for (int x = 0; x < a.GetLength(1); x++)
                {
                    if (y == x)
                    {
                        sumas[cont] = sumas[cont] + a[x, y];
                    }
                   
                }
                 
            }
            cont++;

            for (int y = 0; y < a.GetLength(0); y++)
            {
                for (int x = 0; x < a.GetLength(1); x++)
                {
                    if (y + x == a.GetLength(1) - 1)
                    {
                        sumas[cont] = sumas[cont] + a[x, y];
                    }
                }
                
            }
            cont++;

            sumas[cont] = a[1, 0] + a[2, 0] + a[0, 0];
            cont++;
            sumas[cont] = a[1, 1] + a[2, 1] + a[0, 1];
            cont++;
            sumas[cont] = a[1, 2] + a[2, 2] + a[0, 2];
            cont++;

            for (int i = 0; i < sumas.Length -1; i++)
            {
                if (sumas[i] == sumas[i+1])
                {
                    igual = true;
                }
                else
                {
                    igual = false;
                }
            }
            return igual;
        }

        static bool CompruebaArray19(int[] a)
        {
            bool bien = true;
            List<int> l = new List<int>();
            
            l.AddRange(a);
            l.Sort();

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] != i +1)
                {
                    bien = false;
                }              
            }
            return bien;
        }

        static bool CompruebaSudoku (int [,] a)
        {
            bool devolver = true;
            int cont = 0, cont2;
            bool[] bien= new bool[27];
            int[] aux = new int[9];
            for (int k = 0; k < 9; k++)
            {
                for (int y = 0; y < a.GetLength(0); y++)
                {
                    aux[y] = a[y, k];
                    
                }
                bien[cont] = CompruebaArray19(aux);
                cont++;
            }
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    aux[y] = a[x, y];
                    
                }
                bien[cont] = CompruebaArray19(aux);
                cont++;
            }

            for (int i = 0; i < 9; i = i +3)
            {
                for (int k = 0; k < 9; k = k + 3)
                {
                    cont2 = 0; 
                    for (int y = i; y < i +3; y++)
                    {
                        for (int x = k; x < k + 3; x++)
                        {
                            //aux[((y-i)*3)+(x-k)] = a[x, y];

                           aux[cont2] = a[x, y];
                            cont2++;
                        }
                       
                    }
                    EscribeArrayi(aux);
                    bien[cont] = CompruebaArray19(aux);
                    cont++;
                }
                
            }
            EscribeArray(bien);

            for (int i = 0; i < bien.Length; i++)
            {
                if (!bien[i])
                {
                    devolver = false;
                }
            }

            return devolver;
        }

        static void RellenaBordeBidimensional (int [,] a, int borde, int inferior)
        {
            for (int y = 0; y < a.GetLength(0); y++)
            {
                for (int x = 0; x < a.GetLength(1); x++)
                {
                    if (y == 0 ||y == a.GetLength(1) -1 || y == a.GetLength(0) -1 || x == 0 || x == a.GetLength(1) -1)
                    {
                        a[y, x] = borde;
                    }
                    else
                    {
                        a[y, x] = inferior;
                    }
                }
            }
        }

        static void HundirLaFlota()
        {

        }
        




    }
}

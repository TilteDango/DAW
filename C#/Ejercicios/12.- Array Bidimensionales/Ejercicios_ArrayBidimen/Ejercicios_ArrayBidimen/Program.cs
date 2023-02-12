using System;

namespace Ejercicios_ArrayBidimen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;

            switch (n)
            {
                case 1:
                    {
                        int[,] a = { { 1, 2, 3 }, { 4, 7, 6 }, { 7, 8, 9 } };
                        EscibeArray3x3(a);
                    }
                    break;
                case 2:
                    {
                        int[,] a = new int[3,3];
                        Rellena3x3(a);
                        EscibeArray3x3(a);
                    }
                    break;

                case 3:
                    {
                        int[,] a = new int[3, 3];
                        RellenaAleatorio3x3(a);
                        EscibeArray3x3(a);
                    }
                    break;
                case 4:
                    {
                        int[,] a = { { 1, 2, 3 }, { 4, 7, 6 }, { 7, 8, 9 } };
                        Console.WriteLine(SumaArray3x3(a));
                    }
                    break;

                case 5:
                    {
                        int[,] a = { { 1, 2, 3, 6 }, { 4, 7, 6, 7 }, { 7, 8, 9, 9 }, { 1, 4, 5 , 1} };
                        EscribeArrayBi(a);
                    }
                    break;

                case 6:
                    {
                        int[,] a = new int[5, 8];
                        RellenaAleatorioBi(a);
                        EscribeArrayBi(a);
                    }
                    break;

                case 7:
                    {
                        int[,] a = new int[10, 10];
                        RellenaEnOrdenBi(a);
                        EscribeArrayBi(a);
                    }
                    break;

                case 8:
                    {
                        int[,] a = { { 1, 2, 3, 6 }, { 4, 7, 6, 7 }, { 7, 8, 9, 9 }, { 1, 4, 5, 1 } };
                        Console.WriteLine(SumaArrayBi(a));
                    }
                    break;

                case 9:
                    {
                        int[,] a = { {1,2,3,4 }, { 4, 3, 2, 1 } };
                        int[,] b = { { 4, 3, 2, 1 }, { 1, 2, 3, 4 } };
                        int[,] c = new int[a.GetLength(0), a.GetLength(1)]; 

                        Suma2ArrayBi(a, b, c);

                        EscribeArrayBi(c);
                    }
                    break;

                case 10:
                    {
                        int[,] a = { { 1, 2, 3, 4 }, { 4, 3, 2, 1 } };
                        int[,] b = new int [a.GetLength(0), a.GetLength(1)];
               

                       CopiaArrayBi(a, b);

                        EscribeArrayBi(b);
                    }
                    break;

                case 11:
                    {
                        int[,] a = { { 1, 2, 3, 4 }, { 4, 3, 2, 1 } };
                        int[,] b;
                        b =  CopiaArrayBiPro(a);

                        EscribeArrayBi(b);
                    }
                    break;

                case 12:
                    {
                        int[,] ajedrez = new int[8, 8];

                        RellenaArrayAjedrez(ajedrez);
                        EscribeArrayBi(ajedrez);
                    }
                    break;

                case 13:
                    {
                        int[,] diagonal = new int[8, 8];

                        RellenaDiagonal(diagonal);
                        EscribeArrayBi(diagonal);
                    }
                    break;

                case 14:
                    {
                        int[,] diagonal = new int[5, 5];

                        RellenaX(diagonal);
                        EscribeArrayBi(diagonal);
                    }
                    break;

                case 15:
                    {
                        int[,] diagonal = new int[6, 6];

                        RellenaCuadros(diagonal);
                        EscribeArrayBi(diagonal);
                    }
                    break;


                default:
                    break;
            }
        }

        static void EscibeArray3x3(int[,] a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }

        static void Rellena3x3 (int[,] a)
        {
            int cont = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    a[i, k] = cont;
                    cont++;
                }
            }
        }

        static void RellenaAleatorio3x3 (int[,] a)
        {
            Random r = new Random();
            int n;

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                   n = r.Next(1, 100);
                    a[i, k] = n;
                }
            }
        }

        static int SumaArray3x3 (int[,] a)
        {
            int cont = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    cont = cont + a[i, k];                    
                }
            }

            return cont;
        }

        static void EscribeArrayBi (int[,] a)
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

        static void RellenaAleatorioBi(int[,] a)
        {
            Random r = new Random();
            int n;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    n = r.Next(1, 100);
                    a[i, k] = n;
                }
            }
        }

        static void RellenaEnOrdenBi(int[,] a)
        {
            int cont = 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    a[i, k] = cont;
                    cont++;
                }
            }
        }

        static int SumaArrayBi(int[,] a)
        {
            int cont = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    cont = cont + a[i, k];
                }
            }

            return cont;
        }

        static void Suma2ArrayBi (int [,] a, int [,] b, int [,] c)
        {          
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    c[i, k] = a[i, k] + b[i, k];
                }
            }

        }

        static void CopiaArrayBi (int [,] datos, int [,] copia)
        {
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int k = 0; k < datos.GetLength(1); k++)
                {
                    copia[i, k] = datos[i, k]; 
                }
            }
        }

        static int [,] CopiaArrayBiPro (int [,] datos)
        {
            int[,] copia = new int[datos.GetLength(0), datos.GetLength(1)];

            CopiaArrayBi(datos, copia);

            return copia;
        }

        static void RellenaArrayAjedrez (int [,] ajedrez)
        {
            int cont = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    if (cont == 0)
                    {
                        ajedrez[i, k] = cont;
                            cont++;
                    }
                    else
                    {
                        ajedrez[i, k] = 1;
                        cont = 0;
                    }
                  
                }

                if (cont == 0)
                {
                    cont = 1;
                }
                else
                {
                    cont = 0;
                }
            }
        }

        static void RellenaDiagonal (int [,] diagonal)
        {
            for (int i = 0; i < diagonal.GetLength(0); i++)
            {
                for (int k = 0; k < diagonal.GetLength(1); k++)
                {
                    if (i == k)
                    {
                        diagonal[i, k] = 1;
                    }
                    else
                    {
                        if (i > k)
                        {
                            diagonal[i, k] = 3;
                        }
                        else
                        {
                            diagonal[i, k] = 2;
                        }
                    }
                }
            }
        }

        static void RellenaX (int [,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int k = 0; k < x.GetLength(1); k++)
                {
                    if (i == k || k + i == x.GetLength(1) - 1)
                    {
                        x[i, k] = 1;
                    }
                    else
                    {
                        x[i, k] = 2;
                    }
                }
            }
        }

        static void RellenaCuadros (int [,] cuadro)
        {
            for (int i = 0; i < cuadro.GetLength(0); i++)
            {
                if (i >= cuadro.GetLength(0) / 2)
                {
                    for (int k = 0; k < cuadro.GetLength(1); k++)
                    {
                        if (k >= cuadro.GetLength(1) / 2)
                        {
                            cuadro[i, k] = 4;
                        }
                        else
                        {
                            cuadro[i, k] = 3;
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < cuadro.GetLength(1); k++)
                    {
                        if (k >= cuadro.GetLength(1) / 2)
                        {
                            cuadro[i, k] = 2;
                        }
                        else
                        {
                            cuadro[i, k] = 1;
                        }
                    }
                }
                
            }
        }

       



    }
}

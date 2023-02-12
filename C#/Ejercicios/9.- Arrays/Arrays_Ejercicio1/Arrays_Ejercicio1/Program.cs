using System;

namespace Arrays_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("Menú");
            Console.WriteLine("----");
            Console.WriteLine();
            Console.WriteLine("1- EscribeArray5");
            Console.WriteLine("2- EscribeArray");
            Console.WriteLine("....");
            Console.WriteLine("0- Salir");
            Console.WriteLine();
            Console.Write("Elije una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        int[] a = { 23, 43, 1, -3, 6 };
                        EscribeArray5(a);
                    }
                    break;
                case 2:
                    {
                        int[] a = { 12, 24, 1, 13, 2, 25, -3 };
                        EscribeArray(a);
                    }
                    break;

                case 3:
                    {
                        int[] a=new int[5];
                        LeeArray5(a);
                        EscribeArray(a);
                        break;
                        
                    }

                case 4:
                    {
                        int tam;
                        Console.Write("Dime el tamaño del array: ");
                        tam = int.Parse(Console.ReadLine());
                        int[] a = new int[tam];
                        LeeArray(a);
                        EscribeArray(a);
                        break;
                    }
                    
                case 5:
                    {
                        int[] a = new int[5];
                        PonCeros(a);
                        EscribeArray(a);
                        break;
                    }

                case 6:
                    {
                        int tam;
                        Console.Write("Dime el tamaño del array: ");
                        tam = int.Parse(Console.ReadLine());
                        int[] a = new int[tam];
                        PonCeros(a);
                        EscribeArray(a);
                        break;
                    }

                case 7:
                    {
                        int[] a = new int[5];
                        LeeArray5(a);
                    
                        Console.WriteLine(SumaArray(a));
                        
                        break;

                        
                    }
                case 8:
                    {
                        int tam;
                        Console.Write("Dime el tamaño del array: ");
                        tam = int.Parse(Console.ReadLine());
                        int[] a = new int[tam];
                        LeeArray(a);
                        Console.WriteLine(SumaArray(a));
                        break;
                    }
                case 9:
                    {
                        int[] a = new int[5];
                        LeeArray5(a);

                        Console.WriteLine(MediaArray5(a));

                        break;
                    }
                case 10:
                    {
                        int tam;
                        Console.Write("Dime el tamaño del array: ");
                        tam = int.Parse(Console.ReadLine());
                        int[] a = new int[tam];
                        LeeArray(a);
                        Console.WriteLine(MediaArray(a));
                        break;
                    }
                
                default:
                    break;
            }
        }

        static void EscribeArray5(int[] a)
        {
            Console.Write("[");

            for (int i = 0; i < 5; i++)
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

        static void EscribeArray(int[] a)
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

        static void LeeArray5(int[] a)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Dime el número " + (i + 1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }

        }

        static void LeeArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Dime el número " + (i +1) + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void PonCeros5 (int[] a)
        {
            for (int i = 0; i < 5; i++)
            {
                a[i] = 0;
            }
        }

        static void PonCeros(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
        }

        static int SumaArray5 (int[] a)
        {
            int n = 0;
            for (int i = 0; i < 5; i++)
            {
                n = n + a[i];
            }
            return n;
        }

        static int SumaArray(int[] a)
        {
            int n = 0;
            for (int i = 0; i < a.Length; i++)
            {
                n = n + a[i];
            }

            return n;
        }

        static double MediaArray5 (int[] a)
        {
            double media;
            media = SumaArray5(a) / 5.0;

            return media;
        }

        static double MediaArray(int[] a)
        {
            double media;
            double longitud = a.Length;
            media = SumaArray(a) / (double)a.Length;

            return media;
        }
    }
}

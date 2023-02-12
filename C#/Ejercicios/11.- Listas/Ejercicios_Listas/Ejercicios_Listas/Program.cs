using System;
using System.Collections.Generic;
using System.Linq; // Max() Min ()

namespace Ejercicios_Listas
{
    class Program
    {
       static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {

            bool ejecutar = false;


            //Funcionalidades con las teclas                  

            for (int k = 0; ;)
            {
                PintaMenu(k);
                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.Escape: Environment.Exit(0); break;

                    case ConsoleKey.UpArrow:
                        if (k == 18)
                        {
                            k = 9;
                        }
                        else
                        {
                            k--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (k == 8 || k == 18)
                        {
                            k = 18;
                        }
                        else
                        {
                            if (k < 18)
                            {
                                k++;
                            }
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (k < 10)
                        {
                            k = k + 10;
                        }
                        else
                        {

                            k = k - 10;
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        if (k > 11)
                        {
                            k = k - 10;
                        }
                        else
                        {
                            k = k + 10;
                        }
                        break;
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (k < 0) k = 18; else if (k > 18) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    Console.CursorVisible = true;
                    switch (k)
                    {
                        case 19: Environment.Exit(0); break;
                        case 1:
                            {
                                List<int> l = new List<int>();

                                LeeLista(l);
                                EscribeList(l);
                            }
                            break;
                        case 2:
                            {
                                List<int> l = new List<int>();

                                LeeListaN(l, 10);
                                EscribeList(l);
                            }
                            break;

                        case 3:
                            {
                                List<int> l = new List<int> { 5, 6, 8, 19 };
                                EscribeList(l);
                            }
                            break;

                        case 4:
                            {
                                List<int> l = new List<int> { -2, 4, 8, -1, 6, -2, 7, -1 };
                                EliminaNegativos(l);
                                EscribeList(l);
                            }
                            break;

                        case 5:
                            {
                                List<int> l = new List<int> { -2, 4, 8, -1, 6, -2, 7, -1 };
                                List<int> positivos = new List<int>();
                                List<int> negativos = new List<int>();

                                ClasificaNumeros(l, positivos, negativos);
                                EscribeList(l);
                                EscribeList(positivos);
                                EscribeList(negativos);
                            }
                            break;

                        case 6:
                            {
                                List<int> l = new List<int> { 1, 2, 3, 1, 1, 2, 3, 1, 2, 3, 4 };
                                EliminaRepetidos(l);
                                EscribeList(l);
                            }
                            break;

                        case 7:
                            {
                                List<int> l = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                                l.Reverse();
                                OrdenaListaSeleccion(l);
                                EscribeList(l);
                            }
                            break;

                        case 8:
                            {
                                List<int> l = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                                l.Reverse();
                                OrdenaListaSeleccion(l);
                                EscribeList(l);
                            }
                            break;

                        case 9:
                            {
                                List<string> l = new List<string> { "casas", "cadas", "codos", "perro", "zarigüeya", "ahora", "loco", "reversa" };
                                EscribeListcad(l);
                                OrdenaListaPalabras(l);
                                EscribeListcad(l);
                            }
                            break;

                        case 10:
                            {
                                List<string> l = new List<string> { "casas", "cadas", "codos", "perro", "zarigüeya", "ahora", "loco", "reversa" };
                                EscribeListcad(l);
                                OrdenaListaPalabras2(l);
                                EscribeListcad(l);
                            }
                            break;

                        case 11:
                            {
                                int[] a = { 1, 2, 3, 7, 8, 9 };
                                int posicion = 3;
                                int[] c = { 4, 5, 6 };
                                int[] resultado;

                                resultado = InsertaArrayEnArrayPro(a, posicion, c);

                                for (int i = 0; i < resultado.Length; i++)
                                {
                                    Console.Write(resultado[i] + " ");
                                }
                            }
                            break;

                        case 12:
                            {
                                EscribeList(SorteoBonoloto());
                            }
                            break;

                        case 13:
                            {
                                int[] a = { 1, 2, 3, 3, 2, 1 };

                                int[] resultado;

                                resultado = EliminaRepetidos(a);


                                for (int i = 0; i < resultado.Length; i++)
                                {
                                    Console.Write(resultado[i] + " ");
                                }
                            }
                            break;

                        case 14:
                            {
                                List<int> l = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                                List<int> l2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

                                List<int> resultado;
                                resultado = UnionListas(l, l2);

                                EscribeList(resultado);
                            }
                            break;

                        case 15:
                            {
                                List<int> l = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                                List<int> l2 = new List<int> { 1, 2, 24, 4, 5, 6, 7, 8, 9, 12, 11 };

                                List<int> resultado;
                                resultado = InterseccionListas(l, l2);

                                EscribeList(resultado);
                            }
                            break;

                        case 16:
                            {
                                List<int> l = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };


                                List<int> resultado;
                                resultado = DesordenaLista(l);

                                EscribeList(resultado);
                            }
                            break;

                        case 17:
                            {
                                List<int> l = new List<int> { 1, 2, 3, 4, 5, 5, 4, 3, 2, 2, 1 };

                                Console.WriteLine(ModaLista(l));

                            }
                            break;

                        case 18:
                            {
                                List<double> l = new List<double> { 1.92, 2.45, 3.65, 4.12, 5.45, 6.23, 7.05 };

                                Console.WriteLine(PuntuacionesTrampolin(l));

                            }
                            break;

                    }  
                }
            }
        }

     


        static void LeeLista(List<int> l)
        {
            int n = 0;
            while (n != -1)
            {
                Console.Write("Dime un número entero para añadirlo: ");
                n = int.Parse(Console.ReadLine());
                if (n != -1)
                {
                    l.Add(n);
                }
            }
        }

        static void LeeListaN(List<int> l, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Dime un número entero para añadirlo: ");
                n = int.Parse(Console.ReadLine());
                l.Add(n);
            }
        }

        static void EscribeList(List<int> l)
        {
            Console.Write("<");

            for (int i = 0; i < l.Count; i++)
            {

                if (i == l.Count - 1)
                {
                    Console.Write(l[i]);
                }
                else
                {
                    Console.Write(l[i] + ",");
                }
            }

            Console.WriteLine(">");


        }

        static void EscribeListcad(List<string> l)
        {
            Console.Write("<");

            for (int i = 0; i < l.Count; i++)
            {

                if (i == l.Count - 1)
                {
                    Console.Write(l[i]);
                }
                else
                {
                    Console.Write(l[i] + ",");
                }
            }

            Console.WriteLine(">");


        }

        static void EliminaNegativos(List<int> l)
        {
            //l.RemoveAll(p => p < 0);

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] < 0)
                {
                    l.RemoveAt(i);
                    i--;
                }
            }
        }

        static void ClasificaNumeros(List<int> l, List<int> positivos, List<int> negativos)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] >= 0)
                {
                    positivos.Add(l[i]);
                }
                else
                {
                    negativos.Add(l[i]);
                }
            }

            positivos.Sort();
            negativos.Sort();
        }

        static void EliminaRepetidos(List<int> l)
        {
            List<int> copia = new List<int>();


            for (int i = 0; i < l.Count; i++)
            {
                if (!copia.Contains(l[i]))
                {
                    copia.Add(l[i]);
                }
            }

            l.Clear();
            l.AddRange(copia);
        }

        static void OrdenaListaSeleccion(List<int> l)
        {
            int min;
            List<int> resultado = new List<int>();



            for (int k = 0; k < l.Count; k++)
            {
                min = l[0];
                for (int i = 0; i < l.Count; i++)
                {
                    if (min > l[i])
                    {
                        min = l[i];
                    }
                }
                resultado.Add(min);
                l.Remove(min);
                k--;
            }

            l.Clear();
            l.AddRange(resultado);
        }

        static void OrdenaListaInsercion(List<int> l)
        {
            bool insertado = false;
            List<int> resultado = new List<int>();
            for (int i = 0; i < l.Count; i++)
            {
                insertado = false;
                for (int k = 0; k < resultado.Count; k++)
                {
                    if (l[i] > resultado[k] && l[i] < resultado[k + 1])
                    {
                        resultado.Insert(k, l[i]);
                        insertado = true;
                    }
                }

                if (!insertado)
                {
                    resultado.Add(l[i]);
                }
            }

            l.Clear();
            l.AddRange(resultado);
        }

        static void OrdenaListaPalabras(List<string> l)
        {
            //l.Sort();

            string min = l[0];
            List<string> resultado = new List<string>();



            for (int k = 0; k < l.Count; k++)
            {
                min = l[0];
                for (int i = 0; i < l.Count; i++)
                {
                    if (l[i].CompareTo(min) < 0)
                    {
                        min = l[i];
                    }
                }
                resultado.Add(min);
                l.Remove(min);
                k--;
            }
            l.Clear();
            l.AddRange(resultado);
        }

        static void OrdenaListaPalabras2(List<string> l)
        {
            bool insertado = false;
            List<string> resultado = new List<string>();
            for (int i = 0; i < l.Count; i++)
            {
                insertado = false;
                for (int k = 0; k < resultado.Count; k++)
                {
                    if (l[i].Length < resultado[k].Length)
                    {
                        resultado.Insert(k, l[i]);
                        insertado = true;
                        break;
                    }
                }

                if (!insertado)
                {
                    resultado.Add(l[i]);
                }
            }

            l.Clear();
            l.AddRange(resultado);
        }

        static int[] InsertaArrayEnArrayPro (int[] a, int posicion, int [] c)
        {
            int[] resultado;
            List<int> array = new List<int>();

            array.AddRange(a);
            array.InsertRange(posicion, c);

            resultado = array.ToArray();

            return resultado;
        }

        static List<int> SorteoBonoloto()
        {
            int n;
            List<int> bonoloto = new List<int>();
            List<int> bonoloto2 = new List<int>();

            System.Random r = new Random();
            
            for (int i = 1; i < 50; i++)
            {
                bonoloto.Add(i); 
            }

            for (int i = 0; i <= 6; i++)
            {
                
                n= r.Next(bonoloto.Count);
                bonoloto2.Add(n);
                bonoloto.RemoveAt(n);
            }

            return bonoloto2;


            
            
        }

        static int[] EliminaRepetidos (int[] a)
        {
            int[] resultado;
            List<int> l = new List<int>();

            l.AddRange(a);

            for (int i = 0; i < l.Count; i++)
            {
                for (int k = i+1; k < l.Count; k++)
                {
                    if (l[i] == l[k])
                    {
                        l.RemoveAt(k);
                        k--;
                    }
                }
               
            }

            resultado = l.ToArray();

            return resultado;
        }

        static List<int> UnionListas (List<int> l, List<int> l2)
        {
            List<int> resultado = new List<int>();

            resultado.AddRange(l);
            resultado.AddRange(l2);

            EliminaRepetidos(resultado);

            return resultado;
        }

        static List<int> InterseccionListas (List<int> l, List<int> l2)
        {
            List<int> resultado = new List<int>();

            for (int i = 0; i < l2.Count; i++)
            {
                if (l2.Contains(l[i]))
                {
                    resultado.Add(l[i]);
                }
            }
            return resultado;
        }

        static List<int> DesordenaLista (List<int> l)
        {
            int n;
            List<int> desordenado = new List<int>();
            System.Random r = new Random();

            while (l.Count != 0)
            {
                n = r.Next(l.Count);
                desordenado.Add(l[n]);
                l.RemoveAt(n);
            }

            return desordenado;
        }

        static int ModaLista (List<int> l)
        {
            int moda = 0, cont = 0; 
            for (int i = 0; i < l.Count; i++)
            {
                for (int k = 0; k < l.Count; k++)
                {
                    if (l[i] == l[k])
                    {
                        cont++;
                    }
                }

                if (moda < cont)
                {
                    moda = l[i];
                }

                cont = 0;
            }

            return moda;
        }

        static double PuntuacionesTrampolin (List<double> l)
        {
            double resultado;
            for (int i = 0; i < 2; i++)
            {
                l.Remove(l.Max());
            }
            
            for (int i = 0; i < 2; i++)
            {
                l.Remove(l.Min());
            }

             resultado = l.Sum();

            return resultado;



        }

        static void PintaMenu(int k)
        {


            ConsoleColor menu = ConsoleColor.White;
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.Blue;

            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(45, 2);
            Console.ForegroundColor = menu;
            Console.WriteLine(" ▌ Relación de Ejercicios de Cadenas");


            //Escribir líneas horizontales
            for (int i = 0; i < 113; i++)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(i + 4, 4);
                Console.WriteLine("═");

                Console.SetCursorPosition(i + 4, 24);
                Console.WriteLine("═");
            }
            //
            //Escribir lineas verticales
            for (int i = 0; i < 21; i++)
            {
                if (i == 0)
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(3, i + 4);
                    Console.WriteLine("╔");
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(88, i + 4);
                    Console.Write("╤");
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(58, i + 4);
                    Console.Write("╤");
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(28, i + 4);
                    Console.Write("╤");
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(117, i + 4);
                    Console.WriteLine("╗");
                }
                else
                {
                    if (i == 20)
                    {
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(3, i + 4);
                        Console.WriteLine("╚");
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(88, i + 4);
                        Console.Write("╩");
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(58, i + 4);
                        Console.Write("╩");
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(28, i + 4);
                        Console.Write("╩");
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(117, i + 4);
                        Console.WriteLine("╝");

                    }
                    else
                    {
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(117, i + 4);
                        Console.WriteLine("║");

                        Console.CursorVisible = false;
                        Console.SetCursorPosition(3, i + 4);
                        Console.WriteLine("║");
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(88, i + 4);
                        Console.Write("║");
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(58, i + 4);
                        Console.Write("║");
                        Console.CursorVisible = false;
                        Console.SetCursorPosition(28, i + 4);
                        Console.Write("║");
                    }

                }
            }
            //

            //Selector del cursor
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = k == 0 ? sel : cc;
            Console.Write("1. LeeLista");
            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = k == 1 ? sel : cc;
            Console.WriteLine("2. LeeListaN");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = k == 2 ? sel : cc;
            Console.WriteLine("3. EscribeLista");
            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = k == 3 ? sel : cc;
            Console.WriteLine("4. EliminaNegativos");
            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = k == 4 ? sel : cc;
            Console.WriteLine("5. ClasificaNumeros");
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = k == 5 ? sel : cc;
            Console.WriteLine("6. EliminaRepetidos");
            Console.SetCursorPosition(5, 17);
            Console.ForegroundColor = k == 6 ? sel : cc;
            Console.WriteLine("7. OrdenaListaSeleccion");
            Console.SetCursorPosition(5, 19);
            Console.ForegroundColor = k == 7 ? sel : cc;
            Console.WriteLine("8. OrdenaListaInsercion");
            Console.SetCursorPosition(5, 21);
            Console.ForegroundColor = k == 8 ? sel : cc;
            Console.WriteLine("9. OrdenaListaPalabras");
            Console.SetCursorPosition(5, 23);
            Console.ForegroundColor = k == 9 ? sel : cc;
            Console.WriteLine("10. OrdenaListaPalabras2");
            Console.SetCursorPosition(30, 5);
            Console.ForegroundColor = k == 10 ? sel : cc;
            Console.WriteLine("11. InsertaArrayEnArrayPro");
            Console.SetCursorPosition(30, 7);
            Console.ForegroundColor = k == 11 ? sel : cc;
            Console.WriteLine("12. SorteoBonoloto");
            Console.SetCursorPosition(30, 9);
            Console.ForegroundColor = k == 12 ? sel : cc;
            Console.WriteLine("13. EliminaRepetidos");
            Console.SetCursorPosition(30, 11);
            Console.ForegroundColor = k == 13 ? sel : cc;
            Console.WriteLine("14. UnionListas");
            Console.SetCursorPosition(30, 13);
            Console.ForegroundColor = k == 14 ? sel : cc;
            Console.WriteLine("15. IntersecciónListas");
            Console.SetCursorPosition(30, 15);
            Console.ForegroundColor = k == 15 ? sel : cc;
            Console.WriteLine("16. DesordenaLista");
            Console.SetCursorPosition(30, 17);
            Console.ForegroundColor = k == 16 ? sel : cc;
            Console.WriteLine("17. ModaLista");
            Console.SetCursorPosition(30, 19);
            Console.ForegroundColor = k == 17 ? sel : cc;
            Console.WriteLine("18. PuntuaciónesTrampolin");
            Console.SetCursorPosition(30, 21);

            Console.SetCursorPosition(20, 28);
            Console.ForegroundColor = k == 18 ? sel : cc;
            Console.WriteLine("► Salir");

            //

        }
    }
}

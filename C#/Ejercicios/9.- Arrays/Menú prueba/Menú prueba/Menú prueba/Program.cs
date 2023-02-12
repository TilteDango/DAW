using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {           
            Menu();
        }

       static  void Menu()
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
                        if (k == 40)
                        {
                            k = 9;
                        }
                        else
                        {
                            k--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (k == 9 || k == 19)
                        {
                            k = 40;
                        }
                        else
                        {
                            if (k < 40)
                            {
                                k++;
                            }
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (k < 10)
                        {
                            k = k + 30;
                        }
                        else
                        {

                            k = k - 10;
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        if (k > 29)
                        {
                            k = k - 30;
                        }
                        else
                        {
                            k = k + 10;
                        }
                        break;
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (k < 0) k = 40; else if (k > 40) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    Console.CursorVisible = true;
                    switch (k)
                    {
                        case 40: Environment.Exit(0); break;
                        case 0:
                            {
                                LimpiaMenu(k);
                                int[] a = { 23, 43, 1, -3, 6 };
                                
                                Console.WriteLine("Escribe una función “EscribeArray5” a la que le pasamos un array de tipo entero de cinco elementos y lo escribe por pantalla de la siguiente forma: [23, 43, 1, -3, 6]");
                                Console.WriteLine();
                                EscribeArray5(a);

                                VolverOSalir();
                            }
                            break;
                        case 1:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “EscribeArray” a la que le pasamos un array de enteros del tamaño que sea y lo escribe por pantalla de la misma forma.Tendremos que usar la propiedad “Length” para saber el tamaño del array desde dentro de la función.");
                                
                                int[] a = { 12, 24, 1, 13, 2, 25, -3 };
                                EscribeArray(a);

                                VolverOSalir();
                            }
                            break;

                        case 2:
                            {

                                LimpiaMenu(k);

                                Console.WriteLine("Escribe una función “LeeArray5” que lea un array de enteros de 5 elementos. Habrá que pasarle el array ya definido y él lo rellenará pidiéndole los valores al usuario por consola.");
                                Console.WriteLine();
                                int[] a = new int[5];
                                LeeArray5(a);
                                EscribeArray(a);

                                VolverOSalir();
                            }
                            break;

                        case 3:
                            {
                                LimpiaMenu(k);

                                Console.WriteLine("Escribe una función “LeeArray” que lea un array de enteros de cualquier tamaño. El array lo crearemos fuera de la función y dentro de la función usaremos la propiedad “Length” para saber cuál es el tamaño y cuántos datos debemos leer");                                
                                Console.WriteLine();
                                int tam;
                                Console.CursorVisible = true;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                int[] a = new int[tam];
                                LeeArray(a);
                                EscribeArray(a);
                                VolverOSalir();

                            }
                            break;

                        case 4:
                            {
                                
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “PonCeros5” que modifique el contenido de un array de enteros de cinco elementos y ponga en todas las posiciones un 0.");
                                int[] a = new int[5];
                                PonCeros(a);
                                EscribeArray(a);
                                VolverOSalir();
                            }
                            break;

                        case 5:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “PonCero” que haga lo mismo para un array de enteros de cualquier tamaño.");
                                Console.WriteLine();
                                int tam;
                                Console.CursorVisible = true;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                int[] a = new int[tam];
                                PonCeros(a);
                                EscribeArray(a);
                                VolverOSalir();

                            }
                            break;

                        case 6:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “SumaArray5” que sume todas las posiciones de un array de enteros de cinco elementos y nos devuelva el resultado");
                                Console.WriteLine();
                                int[] a = new int[5];
                                LeeArray5(a);
                                Console.WriteLine();
                                Console.WriteLine(SumaArray(a));

                                VolverOSalir();


                            }
                            break;
                        case 7:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escriba una función “SumaArray” que haga lo mismo para un array de enteros de cualquier tamaño.");
                                Console.WriteLine();
                                int tam;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                int[] a = new int[tam];
                                LeeArray(a);
                                Console.WriteLine();
                                Console.WriteLine(SumaArray(a));
                                VolverOSalir();

                            }
                            break;
                        case 8:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “MediaArray5” que nos calcule el valor medio de los elementos de un array de enteros de tamaño 5.");
                                Console.WriteLine();
                                
                                int[] a = new int[5];
                                LeeArray5(a);
                                Console.WriteLine();
                                Console.WriteLine(MediaArray5(a));
                                VolverOSalir();


                            }
                            break;
                        case 9:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “MediaArray” que haga lo mismo para un array de enteros de cualquier tamaño.");
                                Console.WriteLine();
                                int tam;
                                Console.Write("Dime el tamaño del array: ");                               
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int[] a = new int[tam];
                                LeeArray(a);
                                Console.WriteLine();
                                Console.WriteLine(MediaArray(a));
                                VolverOSalir();

                            }
                            break;

                        case 10:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “RellenaEnOrden” que nos rellena un array de enteros con los números desde el 1 en adelante(1, 2, 3, 4... hasta el tamaño del array). ");
                                Console.WriteLine();
                                int tam;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int[] a = new int[tam];
                                RellenaEnOrden(a);
                                EscribeArray(a);
                                VolverOSalir();

                            }
                            break;
                        case 11:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “RellenaEnOrdenDesc” que nos rellena un array con los valores siguientes: tamaño del array, tamaño del array - 1, etc., 3, 2, 1.");
                                Console.WriteLine();
                                int tam;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int[] a = new int[tam];
                                RellenaEnOrdenDesc(a);
                                EscribeArray(a);
                                VolverOSalir();

                            }
                            break;
                        case 12:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “RellenaAleatorio” a la que le pasamos un array de enteros y nos lo rellena de valores aleatorios entre 1 y 10");
                                Console.WriteLine();
                                int tam;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int[] a = new int[tam];
                                RellenaAleatorio(a);
                                EscribeArray(a);
                                VolverOSalir();

                            }
                            break;

                        case 13:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “EstaOrdenado” a la que le pasas un array de enteros y te devuelve un booleano que será verdadero si los elementos del array se encuentran en orden ascendente.");
                                Console.WriteLine();
                                
                                int tam;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int[] a = new int[tam];
                                if (EstaOrdenado(a))
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Esta ordenado");
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("No esta ordenado");
                                }

                                VolverOSalir();


                            }
                            break;

                        case 14:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “NumeroImpares” a la que le pasas un array de enteros y te devuelve un entero que corresponde a la cantidad de números impares que tenemos en el array");
                                Console.WriteLine();
                                int tam;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int[] a = new int[tam];
                                Console.WriteLine(NumeroImpares(a));
                                VolverOSalir();

                            }
                            break;
                        case 15:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “MinArray” a la que le pasas un array y te devuelve el valor más pequeño de los contenidos en dicho array.");
                                Console.WriteLine();
                                int tam;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int[] a = new int[tam];
                                LeeArray(a);
                                Console.WriteLine();
                                Console.WriteLine("El minimo es " + MinArray(a));
                                VolverOSalir();
                            }
                            break;

                        case 16:
                            {
                                Console.WriteLine(". Escribe una función “MaxArray” que te devuelve el más grande");
                                Console.WriteLine();
                                LimpiaMenu(k);
                                int tam;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int[] a = new int[tam];
                                LeeArray(a);
                                Console.WriteLine();
                                Console.WriteLine("El máximo es " + MaxArray(a));
                                VolverOSalir();

                            }
                            break;

                        case 17:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “NumeroAprobados” a la que se le pasa un array de enteros y, suponiendo que son notas, nos devuelve el número de aprobados(valores entre 5 y 10).");
                                Console.WriteLine();
                                int tam;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int[] a = new int[tam];
                                LeeArray(a);
                                Console.WriteLine();
                                Console.WriteLine("Los aprobados son " + NumeroAprobados(a));
                                VolverOSalir();

                            }
                            break;

                        case 18:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “PorEncimaDe” a la que le pasamos un valor “limite” y nos devuelve cuántos elementos del array son iguales o mayores que ese límite.Por ejemplo, le pasamos el valor 10 y nos dice cuántos elementos son 10 o más");
                                Console.WriteLine();
                                int tam;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int[] a = new int[tam];
                                LeeArray(a);
                                Console.WriteLine();
                                Console.WriteLine(" Hay por encima " + PorEncimaDe(a));
                                VolverOSalir();

                            }
                            break;
                        case 19:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “CuantosCeros” a la que le pasamos un array y nos devuelve un entero que nos dice cuántos elementos tienen el valor 0. ");
                                Console.WriteLine();
                                int tam;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                int[] a = new int[tam];
                                LeeArray(a);
                                Console.WriteLine();
                                Console.WriteLine("Tiene 0 números: " + CuantosCeros(a));
                                VolverOSalir();

                            }
                            break;

                        case 20:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine("Escribe una función “CopiaArray” a la que le pasas dos arrays por parámetro (array1 y array2, por ejemplo) del mismo tamaño (se debería comprobar dentro de la función). La función copiara el contenido del primer array al segundo array");
                                Console.WriteLine();
                                int tam, tam2;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Array original: ");
                                tam2 = tam;
                                int[] a = new int[tam]; int[] b = new int[tam2];
                                LeeArray(a);
                                Console.WriteLine();
                              
                                CopiaArray(a, b);
                                Console.WriteLine();
                                EscribeArray(b);
                                VolverOSalir();

                            }
                            break;

                        case 21:
                            {
                                LimpiaMenu(k);
                                Console.WriteLine(". Escribe una función “CopiaArrayInvertido” a la que le pasas dos arrays por parámetro y te copia el contenido del primer array al segundo array pero en orden inverso(Ej.: si el primero es[5, 6, 7, 8, 9], en el segundo se copiará[9, 8, 7, 6, 5]).");
                                Console.WriteLine();
                                int tam, tam2;
                                Console.Write("Dime el tamaño del array: ");
                                tam = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                tam2 = tam;
                                int[] a = new int[tam]; int[] b = new int[tam2];
                                LeeArray(a);                               
                                CopiaArrayInvertido(a, b);
                                EscribeArray(b);
                                VolverOSalir();

                            }
                            break;

                        case 22:
                            {

                                LimpiaMenu(k);
                                int[] a = { 1, 3, 6, 8, 9 };
                                int[] b = { 5, 6, 3, 2, 1 };
                                int[] res = new int[5];

                                SumaArrays(a, b, res);
                                EscribeArray(res);
                                VolverOSalir();





                            }
                            break;

                        case 23:
                            {
                                LimpiaMenu(k);
                                double[] a = { 1, 3, 6, 8, 9 };
                                double[] b = { 5, 6, 3, 2, 1 };
                                double[] res = new double[5];

                                RestaArrays(a, b, res);
                                EscribeArrayD(res);
                                MultiplicaArrays(a, b, res);
                                EscribeArrayD(res);
                                DivideArrays(a, b, res);
                                EscribeArrayD(res);
                                VolverOSalir();





                            }
                            break;

                        case 24:
                            {
                                LimpiaMenu(k);
                                int[] a = { 1, 2, 3, 4, 5 };
                                InvierteArray(a);
                                EscribeArray(a);
                                VolverOSalir();

                            }
                            break;


                        case 25:
                            {
                                LimpiaMenu(k);
                                int[] a = { 1, 2, 3, 4, 5 };
                                int[] b = { 1, 2, 3, 4, 5 };
                                int[] c = { 5, 4, 3, 2, 1 };
                                Console.WriteLine(ComparaArrays(a, b));
                                Console.WriteLine(ComparaArrays(a, c));
                                Console.WriteLine(ComparaArrays(b, c));
                                VolverOSalir();


                            }
                            break;

                        case 26:
                            {
                                LimpiaMenu(k);
                                double[] a = { 10, 2, 8, 4, 5 };
                                bool[] b = new bool[a.Length];

                                PonNotasArrays(a, b);
                                EscribeArrayb(b);
                                VolverOSalir();



                            }
                            break;

                        case 27:
                            {
                                LimpiaMenu(k);
                                int[] a = { 1, 2, 3, 4, 5 };
                                int[] b = { 1, 2, 3, 4, 5 };
                                int[] c = new int[10];

                                ConcatenaArrays55(a, b, c);
                                EscribeArray(c);
                                VolverOSalir();


                            }
                            break;

                        case 28:
                            {
                                LimpiaMenu(k);
                                int[] a = { 5, 6, 7, 8 };
                                int[] b = { 10, 20, 30, 40, 50, 60 };
                                int[] c = new int[a.Length + b.Length];

                                ConcatenaArrays(a, b, c);
                                EscribeArray(c);
                                VolverOSalir();


                            }
                            break;

                        case 29:
                            {
                                LimpiaMenu(k);
                                int[] a = { 1, 2, 3, 4, 5 };
                                int[] b = { 1, 2, 3, 4, 6 };
                                int n = 5;

                                Console.WriteLine(Contiene(a, n));
                                Console.WriteLine(Contiene(b, n));
                                VolverOSalir();


                            }
                            break;

                        case 30:
                            {
                                LimpiaMenu(k);
                                int[] a = { 5, 6, 7, 8 };
                                int[] b = { 10, 20, 30, 40, 50, 60 };
                                int[] c;


                                c = ConcatenaArraysPro(a, b);
                                EscribeArray(c);
                                VolverOSalir();


                            }
                            break;

                        case 31:
                            {
                                LimpiaMenu(k);
                                int[] a = { 5, 6, 7, 8 };
                                int[] b;



                                b = CopiaArrayPro(a);
                                EscribeArray(b);

                                VolverOSalir();

                            }
                            break;

                        case 32:
                            {
                                LimpiaMenu(k);
                                int[] a = { 1, 2, 3, 4, 5 };
                                int n = 23, hueco = 2;



                                InsertaEnArray(ref a, n, hueco);
                                EscribeArray(a);

                                VolverOSalir();

                            }
                            break;

                        case 33:
                            {
                                LimpiaMenu(k);
                                int[] a = { 5, 7, 2, 8, 1 };
                                int hueco = 1;
                                BorraDeArray(ref a, hueco);
                                EscribeArray(a);
                                VolverOSalir();
                            }
                            break;

                        case 34:
                            {
                                LimpiaMenu(k);
                                int[] a = { 5, 7, 2, 8, 1 };
                                int n = 8;
                                Elimina1ElementoArray(ref a, n);
                                EscribeArray(a);
                                VolverOSalir();

                            }
                            break;

                        case 35:
                            {
                                LimpiaMenu(k);
                                int[] a = { 5, 8, 2, 8, 1 };
                                int n = 8;
                                EliminaElementosArray(ref a, n);
                                EscribeArray(a);
                                VolverOSalir();
                            }
                            break;
                        case 36:
                            {
                                LimpiaMenu(k);
                                int[] a = { 6, 2, 1, 3 };
                                int[] b = { 12, 13 };
                                int hueco = 2;
                                InsertaArrayEnArray(ref a, hueco, b);
                                EscribeArray(a);
                                VolverOSalir();
                            }
                            break;

                        case 37:
                            {
                                LimpiaMenu(k);
                                int[] a = { 3, 6, 2, 8, 9 };
                                int n = 1, b = 3;
                                int[] copia;
                                copia = SubArray(a, n, b);
                                EscribeArray(copia);
                                VolverOSalir();
                            }
                            break;

                        case 38:
                            {
                                LimpiaMenu(k);
                                int[] a = { 3, 6, 2, 8, 9 };
                                int n = 1, b = 3;
                                RecortaArray(ref a, n, b);
                                EscribeArray(a);
                                VolverOSalir();
                            }
                            break;

                        case 39:
                            {
                                LimpiaMenu(k);
                                VolverOSalir();
                            }
                            break;
                        
                    }

                    //
                }
            }
        }

       static void PintaMenu(int k)
                {


                    ConsoleColor menu = ConsoleColor.White;
                    ConsoleColor cc = ConsoleColor.White;
                    ConsoleColor sel = ConsoleColor.Red;

                    Console.CursorVisible = false;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(45, 2);
                    Console.ForegroundColor = menu;
                    Console.WriteLine(" ▌ Relación de Ejercicios de Arrays");


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
                    Console.Write("1. EscribeArray5");
                    Console.SetCursorPosition(5, 7);
                    Console.ForegroundColor = k == 1 ? sel : cc;
                    Console.WriteLine("2. EscribeArray");
                    Console.SetCursorPosition(5, 9);
                    Console.ForegroundColor = k == 2 ? sel : cc;
                    Console.WriteLine("3. LeeArray5");
                    Console.SetCursorPosition(5, 11);
                    Console.ForegroundColor = k == 3 ? sel : cc;
                    Console.WriteLine("4. LeeArray");
                    Console.SetCursorPosition(5, 13);
                    Console.ForegroundColor = k == 4 ? sel : cc;
                    Console.WriteLine("5. PonCero5");
                    Console.SetCursorPosition(5, 15);
                    Console.ForegroundColor = k == 5 ? sel : cc;
                    Console.WriteLine("6. PonCero");
                    Console.SetCursorPosition(5, 17);
                    Console.ForegroundColor = k == 6 ? sel : cc;
                    Console.WriteLine("7. SumaArray5");
                    Console.SetCursorPosition(5, 19);
                    Console.ForegroundColor = k == 7 ? sel : cc;
                    Console.WriteLine("8. SumaArray");
                    Console.SetCursorPosition(5, 21);
                    Console.ForegroundColor = k == 8 ? sel : cc;
                    Console.WriteLine("9. MediaArray5");
                    Console.SetCursorPosition(5, 23);
                    Console.ForegroundColor = k == 9 ? sel : cc;
                    Console.WriteLine("10. MediaArray");
                    Console.SetCursorPosition(30, 5);
                    Console.ForegroundColor = k == 10 ? sel : cc;
                    Console.WriteLine("11. RellenaEnOrden");
                    Console.SetCursorPosition(30, 7);
                    Console.ForegroundColor = k == 11 ? sel : cc;
                    Console.WriteLine("12. RellenaEnOrdenDesc");
                    Console.SetCursorPosition(30, 9);
                    Console.ForegroundColor = k == 12 ? sel : cc;
                    Console.WriteLine("13. RellenaAleatorio");
                    Console.SetCursorPosition(30, 11);
                    Console.ForegroundColor = k == 13 ? sel : cc;
                    Console.WriteLine("14. EstaOrdenado");
                    Console.SetCursorPosition(30, 13);
                    Console.ForegroundColor = k == 14 ? sel : cc;
                    Console.WriteLine("15. NumeroImpares");
                    Console.SetCursorPosition(30, 15);
                    Console.ForegroundColor = k == 15 ? sel : cc;
                    Console.WriteLine("16. MinArray");
                    Console.SetCursorPosition(30, 17);
                    Console.ForegroundColor = k == 16 ? sel : cc;
                    Console.WriteLine("17. MaxArray");
                    Console.SetCursorPosition(30, 19);
                    Console.ForegroundColor = k == 17 ? sel : cc;
                    Console.WriteLine("18. NumeroAprobados");
                    Console.SetCursorPosition(30, 21);
                    Console.ForegroundColor = k == 18 ? sel : cc;
                    Console.WriteLine("19. PorEncimaDe");
                    Console.SetCursorPosition(30, 23);
                    Console.ForegroundColor = k == 19 ? sel : cc;
                    Console.WriteLine("20. CuantosCeros");
                    Console.SetCursorPosition(60, 5);
                    Console.ForegroundColor = k == 20 ? sel : cc;
                    Console.WriteLine("21. CopiaArray");
                    Console.SetCursorPosition(60, 7);
                    Console.ForegroundColor = k == 21 ? sel : cc;
                    Console.WriteLine("22. CopiaArrayInvertido");
                    Console.SetCursorPosition(60, 9);
                    Console.ForegroundColor = k == 22 ? sel : cc;
                    Console.WriteLine("23. SumaArrays");
                    Console.SetCursorPosition(60, 11);
                    Console.ForegroundColor = k == 23 ? sel : cc;
                    Console.WriteLine("24. RestaArrays");
                    Console.SetCursorPosition(60, 13);
                    Console.ForegroundColor = k == 24 ? sel : cc;
                    Console.WriteLine("25. InvierteArray");
                    Console.SetCursorPosition(60, 15);
                    Console.ForegroundColor = k == 25 ? sel : cc;
                    Console.WriteLine("26. ComparaArrays");
                    Console.SetCursorPosition(60, 17);
                    Console.ForegroundColor = k == 26 ? sel : cc;
                    Console.WriteLine("27. PonNotasArray");
                    Console.SetCursorPosition(60, 19);
                    Console.ForegroundColor = k == 27 ? sel : cc;
                    Console.WriteLine("28. ConcatenaArrays55");
                    Console.SetCursorPosition(60, 21);
                    Console.ForegroundColor = k == 28 ? sel : cc;
                    Console.WriteLine("29. ConcatenaArray");
                    Console.SetCursorPosition(60, 23);
                    Console.ForegroundColor = k == 29 ? sel : cc;
                    Console.WriteLine("30. Contiene");
                    Console.SetCursorPosition(90, 5);
                    Console.ForegroundColor = k == 30 ? sel : cc;
                    Console.WriteLine("31. ConcatenaArraysPro");
                    Console.SetCursorPosition(90, 7);
                    Console.ForegroundColor = k == 31 ? sel : cc;
                    Console.WriteLine("32. CopiaArrayPro");
                    Console.SetCursorPosition(90, 9);
                    Console.ForegroundColor = k == 32 ? sel : cc;
                    Console.WriteLine("33. InsertaEnArray");
                    Console.SetCursorPosition(90, 11);
                    Console.ForegroundColor = k == 33 ? sel : cc;
                    Console.WriteLine("34. BorraDeArray");
                    Console.SetCursorPosition(90, 13);
                    Console.ForegroundColor = k == 34 ? sel : cc;
                    Console.WriteLine("35. Elimina1ElementoArray");
                    Console.SetCursorPosition(90, 15);
                    Console.ForegroundColor = k == 35 ? sel : cc;
                    Console.WriteLine("36. EliminaElementosArray");
                    Console.SetCursorPosition(90, 17);
                    Console.ForegroundColor = k == 36 ? sel : cc;
                    Console.WriteLine("37. InsertaArrayEnArray");
                    Console.SetCursorPosition(90, 19);
                    Console.ForegroundColor = k == 37 ? sel : cc;
                    Console.WriteLine("38. SubArray");
                    Console.SetCursorPosition(90, 21);
                    Console.ForegroundColor = k == 38 ? sel : cc;
                    Console.WriteLine("39. RecortaArray");
                    Console.SetCursorPosition(90, 23);
                    Console.ForegroundColor = k == 39 ? sel : cc;
                    Console.WriteLine("40. OrdenaBurbuja");


                    Console.SetCursorPosition(20, 28);
                    Console.ForegroundColor = k == 40 ? sel : cc;
                    Console.WriteLine("► Salir");

                    //

                }

        static void LimpiaMenu(int k)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(2, 2);
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine(" ▌ Ejercicio " + (k+1) + ":");

            Console.SetCursorPosition(5, 5);


        }

        static void VolverOSalir()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pulsa una tecla para volver al menú...");
            Console.ReadKey();
            Console.Clear();
            Menu();
      
            
                
            
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
            Console.WriteLine();
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

                static void EscribeArrayD(double[] a)
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

                static void EscribeArrayb(bool[] a)
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
                Console.CursorVisible = true;
                Console.Write("Dime el número " + (i + 1) + ": ");
                        a[i] = int.Parse(Console.ReadLine());
                    }

                }

                static void LeeArray(int[] a)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.Write("Dime el número " + (i + 1) + ": ");
                        a[i] = int.Parse(Console.ReadLine());
                    }
                }

                static void PonCeros5(int[] a)
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

                static int SumaArray5(int[] a)
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

                static double MediaArray5(int[] a)
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

                static void RellenaEnOrden(int[] a)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = (i + 1);
                    }
                }

                static void RellenaEnOrdenDesc(int[] a)
                {
                    int max = a.Length;
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = max;
                        max--;
                    }
                }

                static void RellenaAleatorio(int[] a)
                {
                    Random r = new Random();

                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i] = r.Next(1, 11);
                    }
                }

                static bool EstaOrdenado(int[] a)
                {
                    int cont = 0;
                    LeeArray(a);

                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        if ((a[i]) > a[i + 1])
                        {
                            cont++;
                        }
                    }

                    if (cont == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }

                static int NumeroImpares(int[] a)
                {
                    int cont = 0;
                    LeeArray(a);
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] % 2 == 1)
                        {
                            cont++;
                        }
                    }

                    return cont;
                }

                static int MaxArray(int[] a)
                {
                    int max = a[0], total;
                    for (int i = 0; i < a.Length; i++)
                    {
                        total = a[i];
                        if (total > max)
                        {
                            max = total;
                        }
                    }

                    return max;
                }

                static int MinArray(int[] a)
                {
                    int min = a[0], total;
                    for (int i = 0; i < a.Length; i++)
                    {
                        total = a[i];
                        if (min > a[i])
                        {
                            min = total;
                        }
                    }

                    return min;
                }

                static int NumeroAprobados(int[] a)
                {
                    int cont = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] >= 5 && a[i] <= 10)
                        {
                            cont++;
                        }
                    }

                    return cont;
                }

                static int PorEncimaDe(int[] a)
                {
                    int limite, cont = 0;

                    Console.Write("Dime el límite: ");
                    limite = int.Parse(Console.ReadLine());

                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] >= limite)
                        {
                            cont++;
                        }
                    }

                    return cont;
                }

                static int CuantosCeros(int[] a)
                {
                    int cont = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == 0)
                        {
                            cont++;
                        }
                    }

                    return cont;
                }

                static void CopiaArray(int[] a, int[] copia)
                {
                    if (a.Length > copia.Length || a.Length < copia.Length)
                    {
                        Console.WriteLine("Invalido");

                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        copia[i] = a[i];
                    }
                }

                static void CopiaArrayInvertido(int[] a, int[] b)
                {
                    int inv = b.Length - 1;
                    if (a.Length > b.Length || a.Length < b.Length)
                    {
                        Console.WriteLine("Invalido");

                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        b[inv] = a[i];
                        inv--;
                    }

                }

                static void SumaArrays(int[] a, int[] b, int[] res)
                {
                    if (a.Length > b.Length || a.Length < b.Length)
                    {
                        Console.WriteLine("Invalido");
                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        res[i] = a[i] + b[i];
                    }
                }

                static void RestaArrays(double[] a, double[] b, double[] res)
                {
                    if (a.Length > b.Length || a.Length < b.Length)
                    {
                        Console.WriteLine("Invalido");
                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        res[i] = a[i] - b[i];
                    }
                }

                static void MultiplicaArrays(double[] a, double[] b, double[] res)
                {
                    if (a.Length > b.Length || a.Length < b.Length)
                    {
                        Console.WriteLine("Invalido");
                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        res[i] = a[i] * b[i];
                    }
                }

                static void DivideArrays(double[] a, double[] b, double[] res)
                {

                    if (a.Length > b.Length || a.Length < b.Length)
                    {
                        Console.WriteLine("Invalido");
                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        res[i] = a[i] / b[i];
                    }
                }

                static void InvierteArray(int[] a)
                {
                    int[] b = new int[a.Length];
                    CopiaArrayInvertido(a, b);
                    CopiaArray(b, a);
                }

                static bool ComparaArrays(int[] a, int[] b)
                {
                    if (a.Length == b.Length)
                    {
                        for (int i = 0; i < a.Length; i++)
                        {
                            if (a[i] != b[i])
                            {
                                return false;
                            }

                        }
                    }
                    else
                    {
                        return false;
                    }

                    return true;
                }

                static void PonNotasArrays(double[] a, bool[] b)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] <= 10 && a[i] >= 5)
                        {
                            b[i] = true;
                        }
                        else
                        {
                            b[i] = false;
                        }
                    }
                }

                static void ConcatenaArrays55(int[] a, int[] b, int[] c)
                {
                    int j = 5;
                    for (int i = 0; i < 5; i++)
                    {
                        c[i] = a[i];
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        c[j] = b[i];

                        j++;
                    }
                }

                static void ConcatenaArrays(int[] a, int[] b, int[] c)
                {
                    int j = a.Length;
                    for (int i = 0; i < a.Length; i++)
                    {
                        c[i] = a[i];
                    }

                    for (int i = 0; i < b.Length; i++)
                    {
                        c[j] = b[i];

                        j++;
                    }
                }

                static bool Contiene(int[] a, int n)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == n)
                        {
                            return true;
                        }
                    }

                    return false;
                }

                static int[] ConcatenaArraysPro(int[] a, int[] b)
                {
                    int[] c = new int[a.Length + b.Length];

                    ConcatenaArrays(a, b, c);

                    return c;

                }

                static int[] CopiaArrayPro(int[] a)
                {
                    int[] b = new int[a.Length];
                    for (int i = 0; i < a.Length; i++)
                    {
                        b[i] = a[i];
                    }

                    return b;
                }

                static void InsertaEnArray(ref int[] a, int n, int hueco)
                {
                    Array.Resize(ref a, a.Length + 1);

                    for (int i = a.Length - 1; i > hueco; i--)
                    {
                        a[i] = a[i - 1];
                    }
                    a[hueco] = n;
                }

                static void BorraDeArray(ref int[] a, int hueco)
                {
                    for (int i = hueco; i < a.Length - 1; i++)
                    {
                        a[i] = a[i + 1];
                    }

                    Array.Resize(ref a, a.Length - 1);
                }

                static void Elimina1ElementoArray(ref int[] a, int n)
                {
                    int hueco = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == n)
                        {
                            hueco = i;
                        }
                    }

                    for (int i = hueco; i < a.Length - 1; i++)
                    {
                        a[i] = a[i + 1];
                    }

                    Array.Resize(ref a, a.Length - 1);


                }

                static void EliminaElementosArray(ref int[] a, int n)
                {
                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        if (a[i] == n)
                        {
                            BorraDeArray(ref a, i);
                        }
                    }

                }

                static void InsertaArrayEnArray(ref int[] a, int hueco, int[] b)
                {
                    Array.Resize(ref a, a.Length + b.Length);

                    for (int i = 0; i < b.Length; i++)
                    {


                        for (int k = a.Length - 1; k > hueco; k--)
                        {
                            a[k] = a[k - 1];


                        }
                    }
                    for (int j = 0; j < b.Length; j++)
                    {
                        a[hueco] = b[j];
                        hueco++;

                    }

                }

                static int[] SubArray(int[] a, int n, int b)
                {
                    int[] copia = new int[b - (n - 1)];

                    for (int i = 0; i < copia.Length; i++)
                    {
                        copia[i] = a[i + n];
                    }

                    return copia;
                }

                static void RecortaArray(ref int[] a, int min, int max)
                {

                    for (int i = min; i <= max; i++)
                    {
                        for (int j = 0; j < a.Length - 1; j++)
                        {
                            a[j] = a[i];
                        }
                    }

                    Array.Resize(ref a, a.Length - (max + 1));
                }
            }
        }
    

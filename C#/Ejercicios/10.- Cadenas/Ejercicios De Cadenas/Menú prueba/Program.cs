using System;

namespace ConsoleApplication1
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
                        if (k == 20)
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
                            k = 20;
                        }
                        else
                        {
                            if (k < 20)
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
                        if (k > 29)
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

                if (k < 0) k = 20; else if (k > 20) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    Console.CursorVisible = true;
                    switch (k)
                    {
                        case 21: Environment.Exit(0); break;
                        case 1:
                            {
                                LimpiaMenu(k);
                                string cad = "Hola buenos dias";

                                Console.WriteLine(NumeroEspacios(cad));

                                VolverOSalir();
                            }
                            break;
                        case 2:
                            {
                                LimpiaMenu(k);
                                string cad = "adivina ya te opina, ya ni miles origina, ya ni cetro me domina, ya ni monarcas, a repaso ni mulato carreta, acaso nicotina, ya ni cita vecino, anima cocina, pedazo gallina, cedazo terso nos retoza de canilla goza, de pánico camina, ónice vaticina, ya ni tocino saca, a terracota luminosa pera, sacra nómina y ánimo de mortecina, ya ni giros elimina, ya ni poeta, ya ni vida";

                                Console.WriteLine(EsPalindromo(cad));

                                VolverOSalir();
                            }
                            break;

                        case 3:
                            {

                                LimpiaMenu(k);

                                char n = 'p';
                                string cad = "Hola";

                                Console.WriteLine(Contiene(n, cad));

                                VolverOSalir();
                            }
                            break;

                        case 4:
                            {
                                LimpiaMenu(k);

                                char c = 'p';
                                int n = 3;

                                Console.WriteLine(RepiteCaracter(c, n));
                                VolverOSalir();

                            }
                            break;

                        case 5:
                            {

                                LimpiaMenu(k);
                                string cad = "patata tomate y cebolla";
                                Console.WriteLine(QuitaEspacios(cad));
                                VolverOSalir();
                            }
                            break;

                        case 6:
                            {
                                LimpiaMenu(k);
                                string cad = "         patata tomate y cebolla        ";
                                Console.WriteLine(QuitaEspaciosTrim(cad) + "<");
                                VolverOSalir();

                            }
                            break;

                        case 7:
                            {
                                LimpiaMenu(k);
                                char a = 'a', b = 'b';
                                string cad = "patata tomate y cebolla";
                                Console.WriteLine(SustituyeCaracter(cad, a, b));

                                VolverOSalir();


                            }
                            break;
                        case 8:
                            {
                                LimpiaMenu(k);
                                string cad = "      patata tomate     y cebolla     ";
                                Console.WriteLine(CuentaPalabras(cad));
                                VolverOSalir();

                            }
                            break;
                        case 9:
                            {
                                LimpiaMenu(k);
                                string cad = "123456789";
                                string cad2 = "12345jk62";
                                string cad3 = "asdasdlasjld5";
                                Console.WriteLine(EsNumero(cad));
                                Console.WriteLine(EsNumero(cad2));
                                Console.WriteLine(EsNumero(cad3));
                                VolverOSalir();


                            }
                            break;
                        case 10:
                            {
                                LimpiaMenu(k);
                                string cad = "patata tomate y cebolla";
                                char a = 'a';


                                Console.WriteLine(QuitaCaracter(cad, a));
                                VolverOSalir();

                            }
                            break;

                        case 11:
                            {
                                LimpiaMenu(k);
                                string cad = "ámare pichón";



                                Console.WriteLine(QuitaAcentos(cad));
                                VolverOSalir();

                            }
                            break;
                        case 12:
                            {
                                LimpiaMenu(k);
                                string cad = "ámare pichón";



                                Console.WriteLine(InvierteCadena(cad));
                                VolverOSalir();

                            }
                            break;
                        case 13:
                            {
                                LimpiaMenu(k);
                                string cad = "patata tomate y cebolla";
                                char a = 'a';


                                Console.WriteLine(VecesCaracter(cad, a));
                                VolverOSalir();

                            }
                            break;

                        case 14:
                            {
                                LimpiaMenu(k);
                                string cad = "pepe tenia a pepe con pepe a la pepe";
                                string palabra = "pepe";


                                Console.WriteLine(VecesPalabra(cad, palabra));

                                VolverOSalir();


                            }
                            break;

                        case 15:
                            {
                                LimpiaMenu(k);
                                string cad = "pepe tenia a pepe con pepe a la pepe";



                                Console.WriteLine(MaysuculasPrimera(cad));

                                VolverOSalir();

                            }
                            break;
                        case 16:
                            {
                                LimpiaMenu(k);
                                string cad = "pepe tenia a pepe con pepe a la pepe";
                                string palabra = "pepe";
                                string sustituye = "queso";


                                Console.WriteLine(SustituyePalabra(cad, palabra, sustituye));
                                VolverOSalir();
                            }
                            break;

                        case 17:
                            {
                                
                                LimpiaMenu(k);
                                string cad = "La casa de la niña es bonita";



                                Console.WriteLine(InviertePalabra(cad));
                                VolverOSalir();

                            }
                            break;

                        case 18:
                            {
                                LimpiaMenu(k);
                                string cad = "La casa de la niña es bonita. La casa es hermosa. La casa es loca. La casa";
                                string cad2 = "La casa";



                                Console.WriteLine(MarcaSubCadena(cad, cad2));
                                VolverOSalir();

                            }
                            break;

                        case 19:
                            {
                                LimpiaMenu(k);
                                string cad = "          La casa de la niña      es bonita. La casa es     hermosa. La casa     es loca. La     casa      ";




                                Console.WriteLine(QuitaEspaciosSobrantes(cad));
                                VolverOSalir();

                            }
                            break;
                        case 20:
                            {
                                LimpiaMenu(k);
                             
                                VolverOSalir();

                            }
                            break;
                    }
                }
            }
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
            Console.Write("1. NumeroEspacios");
            Console.SetCursorPosition(5, 7);
            Console.ForegroundColor = k == 1 ? sel : cc;
            Console.WriteLine("2. NúmeroVocales");
            Console.SetCursorPosition(5, 9);
            Console.ForegroundColor = k == 2 ? sel : cc;
            Console.WriteLine("3. EsPalindromo");
            Console.SetCursorPosition(5, 11);
            Console.ForegroundColor = k == 3 ? sel : cc;
            Console.WriteLine("4. Contiene");
            Console.SetCursorPosition(5, 13);
            Console.ForegroundColor = k == 4 ? sel : cc;
            Console.WriteLine("5. RepiteCaracter");
            Console.SetCursorPosition(5, 15);
            Console.ForegroundColor = k == 5 ? sel : cc;
            Console.WriteLine("6. QuitaEspacios");
            Console.SetCursorPosition(5, 17);
            Console.ForegroundColor = k == 6 ? sel : cc;
            Console.WriteLine("7. QuitaEspaciosTrim");
            Console.SetCursorPosition(5, 19);
            Console.ForegroundColor = k == 7 ? sel : cc;
            Console.WriteLine("8. SustituyeCaracter");
            Console.SetCursorPosition(5, 21);
            Console.ForegroundColor = k == 8 ? sel : cc;
            Console.WriteLine("9. CuentaPalabras");
            Console.SetCursorPosition(5, 23);
            Console.ForegroundColor = k == 9 ? sel : cc;
            Console.WriteLine("10. EsNumero");
            Console.SetCursorPosition(30, 5);
            Console.ForegroundColor = k == 10 ? sel : cc;
            Console.WriteLine("11. QuitaCaracter");
            Console.SetCursorPosition(30, 7);
            Console.ForegroundColor = k == 11 ? sel : cc;
            Console.WriteLine("12. QuitaAcentos");
            Console.SetCursorPosition(30, 9);
            Console.ForegroundColor = k == 12 ? sel : cc;
            Console.WriteLine("13. InvierteCadena");
            Console.SetCursorPosition(30, 11);
            Console.ForegroundColor = k == 13 ? sel : cc;
            Console.WriteLine("14. VecesCaracter");
            Console.SetCursorPosition(30, 13);
            Console.ForegroundColor = k == 14 ? sel : cc;
            Console.WriteLine("15. VecesPalabra");
            Console.SetCursorPosition(30, 15);
            Console.ForegroundColor = k == 15 ? sel : cc;
            Console.WriteLine("16. MayusculasPrimera");
            Console.SetCursorPosition(30, 17);
            Console.ForegroundColor = k == 16 ? sel : cc;
            Console.WriteLine("17. SustituyePalabra");
            Console.SetCursorPosition(30, 19);
            Console.ForegroundColor = k == 17 ? sel : cc;
            Console.WriteLine("18. InviertePalabras");
            Console.SetCursorPosition(30, 21);
            Console.ForegroundColor = k == 18 ? sel : cc;
            Console.WriteLine("19. MarcaSubCadena");
            Console.SetCursorPosition(30, 23);
            Console.ForegroundColor = k == 19 ? sel : cc;
            Console.WriteLine("20. QuitaEspaciosSobrantes");
            Console.SetCursorPosition(60, 5);
          
            Console.SetCursorPosition(20, 28);
            Console.ForegroundColor = k == 20 ? sel : cc;
            Console.WriteLine("► Salir");

            //

        }

        static void LimpiaMenu(int k)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(2, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ▌ Ejercicio " + (k + 1) + ":");

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

        static int NumeroEspacios(string cad)
        {
            int n = 0;
            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == ' ')
                {
                    n++;
                }
            }

            return n;
        }

        static int NumeroVocales(string cad)
        {
            int n = 0;
            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == 'a' || cad[i] == 'e' || cad[i] == 'i' || cad[i] == 'o' || cad[i] == 'u')
                {
                    n++;
                }
            }

            return n;
        }

        static bool EsPalindromo(string cad)
        {
            int k = 0;
            string aux = "";


            bool palindromo;
            cad = cad.ToLower();

            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == ' ')
                {
                    cad = cad.Remove(i, 1);
                }
                if (cad[i] == ',')
                {
                    cad = cad.Remove(i, 1);
                }
            }

            for (int i = cad.Length - 1; i >= 0; i--)
            {
                aux = aux + cad[k];
                k++;
            }

            if (aux == cad)
            {
                palindromo = true;
            }
            else
            {
                palindromo = false;
            }

            return palindromo;


        }

        static bool Contiene(char n, string cad)
        {
            int cont = 0;
            bool contiene = false;
            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == n)
                {
                    cont++;
                }
            }

            if (cont != 0)
            {
                contiene = true;
            }
            else
            {
                contiene = false;
            }

            return contiene;
        }

        static string RepiteCaracter(char letra, int n)
        {
            string cad = "";
            for (int i = 0; i < n; i++)
            {
                cad = cad + letra;
            }

            return cad;
        }

        //static string PadLeft (string cad, int n)
        //{
        //    string aux="";
        //    for (int i = 0; i < n - cad.Length; i++)
        //    {
        //        aux = aux + ' ';
        //    }

        //    cad = aux + cad;

        //    return cad;
        //}

        //static string PadRight(string cad, int n)
        //{
        //    for (int i = 0; i <= (n+1) - cad.Length +1; i++)
        //    {
        //        cad = cad + ' ';
        //    }

        //    return cad;
        //}

        static string QuitaEspacios(string cad)
        {
            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == ' ')
                {
                    cad = cad.Remove(i, 1);
                }
            }

            return cad;
        }

        static string QuitaEspaciosTrim(string cad)
        {
            int i = 0, k = cad.Length - 1;
            while (cad[i] == ' ')
            {
                i++;
            }

            while (cad[k] == ' ')
            {
                k--;
            }

            cad = cad.Substring(i, (k - i) + 1);

            return cad;
        }

        static string SustituyeCaracter(string cad, char caracter, char sustituir)
        {
            string aux = "";

            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] != caracter)
                {
                    aux = aux + cad[i];
                }
                else
                {
                    aux = aux + sustituir;
                }
            }

            return aux;
        }

        static int CuentaPalabras(string frase)
        {
            int cont = 1;
            frase = QuitaEspaciosTrim(frase);

            for (int i = 0; i < frase.Length - 1; i++)
            {
                if (frase[i] == ' ' && frase[i + 1] != ' ')
                {
                    cont++;
                }
            }

            return cont;
        }

        static bool EsNumero(string cad)
        {
            for (int i = 0; i < cad.Length; i++)
            {
                if (!(char.IsDigit(cad[i])))
                {
                    return false;
                }
            }

            return true;
        }

        static string QuitaCaracter(string cad, char quitar)
        {
            string aux = "";

            for (int i = 0; i < cad.Length; i++)
            {
                if (!(cad[i] == quitar))
                {
                    aux = aux + cad[i];
                }
            }

            return aux;
        }

        static string QuitaAcentos(string cad)
        {
            string acentos = "áéíóú";
            string sinacentos = "aeiou";
            string aux = "";
            bool esta = true;
            for (int i = 0; i < cad.Length; i++)
            {
                for (int k = 0; k < acentos.Length; k++)
                {
                    if (cad[i] == acentos[k])
                    {
                        aux = aux + sinacentos[k];
                        esta = false;
                    }
                }
                if (esta)
                {
                    aux = aux + cad[i];
                }
                esta = true;
            }

            return aux;
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

        static int VecesCaracter(string cad, char repite)
        {
            int cont = 0;
            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == repite)
                {
                    cont++;
                }
            }

            return cont;
        }

        static int VecesPalabra(string cad, string palabra)
        {
            int cont = 0, repite = 0, j = 0;
            for (int i = 0; i < cad.Length - palabra.Length + 1; i++)
            {
                if (cad[i] == palabra[0])
                {
                    j = i;
                    for (int k = 0; k < palabra.Length; k++)
                    {

                        if (cad[j] == palabra[k])
                        {
                            cont++;
                        }
                        j++;
                    }

                    if (cont == palabra.Length)
                    {
                        repite++;
                    }


                }
                cont = 0;

            }

            return repite;
        }

        static string MaysuculasPrimera(string cad)
        {
            string aux = "";
            string[] palabras = cad.Split(" ");

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 1)
                {
                    aux = aux + char.ToUpper(palabras[i][0]) + palabras[i].Substring(1) + ' ';
                }
                else
                {
                    aux = aux + palabras[i].ToUpper() + ' ';
                }
            }
            aux = aux.Substring(0, aux.Length - 1);
            return aux;
        }

        static string SustituyePalabra(string cad, string palabra, string sustituye)
        {
            string[] separado = cad.Split(" ");

            for (int i = 0; i < separado.Length; i++)
            {
                if (separado[i] == palabra)
                {
                    separado[i] = sustituye;
                }
            }

            cad = String.Join(' ', separado);

            return cad;
        }

        static string InviertePalabra(string cad)
        {
            string aux = "";
            string[] palabras = cad.Split(" ");

            for (int i = 0; i < palabras.Length; i++)
            {
                for (int k = palabras[i].Length - 1; k >= 0; k--)
                {
                    aux = aux + palabras[i][k];
                }
                palabras[i] = aux;

                aux = "";
            }
            cad = String.Join(' ', palabras);

            return cad;
        }

        static string MarcaSubCadena(string cad, string repetida)
        {
            int cont = 0, repite = 0, j = 0;
            for (int i = 0; i < cad.Length - repetida.Length + 1; i++)
            {
                if (cad[i] == repetida[0])
                {
                    j = i;
                    for (int k = 0; k < repetida.Length; k++)
                    {

                        if (cad[j] == repetida[k])
                        {
                            cont++;
                        }
                        j++;
                    }

                    if (cont == repetida.Length)
                    {
                        cad = cad.Remove(i, 1);
                        cad = cad.Insert(i, "*");

                    }




                }
                cont = 0;

            }

            return cad;
        }

        static string QuitaEspaciosSobrantes(string cad)
        {
            string aux = "";
            cad = cad.TrimStart();
            cad = cad.TrimEnd();

            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == ' ' && cad[i + 1] != ' ' || cad[i] != ' ')
                {
                    aux = aux + cad[i];
                }

            }

            return aux;

        }

    }
}
    

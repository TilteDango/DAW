using System;

namespace Adicionales_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 14;
            switch (k)
            {
                case 1:
                    {

                        string cad = "La casa de la niña es bonita. La casa es hermosa. La casa es loca. La casa";
                        string cad2 = "La casa";



                        Console.WriteLine(MarcaSubCadena(cad, cad2));

                    }
                    break;

                case 2:
                    {
                        string cad = "Bandres Sasal Hilario Muñoz Rodriguez Paula Galvan Poley Javier";
                        EscribeNombres(cad);
                    }
                    break;

                case 3:
                    {

                        string cad = "me gustan las palomitas";
                        EscribeArray(CuentaLetras(cad));

                    }
                    break;

                case 4:
                    {
                        string cad = "a mi me gusta comer popitos.   viva el betis coño.";

                        Console.WriteLine(MayusculasMinusculas(cad,1));
                        Console.WriteLine(MayusculasMinusculas(cad, 2));
                        Console.WriteLine(MayusculasMinusculas(cad, 3));
                        Console.WriteLine(MayusculasMinusculas(cad, 4));

                    }
                    break;

                case 5:
                    {

                        string tags = "Esto es texto normal <b>y esto es texto en negrita<br>.</p>";

                        Console.WriteLine(EliminaTags(tags));
                    }
                    break;

                case 6:
                    {

                        string cad = "Esto,Es,Una,Locura,Abc,Dario,Zarigueya,AAAAA";

                        Console.WriteLine(OrdenaPalabrasComas(cad));


                    }
                    break;

                case 7:
                    {

                        Console.WriteLine(AcentosHTML("\" Buenos, & éncima, debájo Ñ, ñol, Üruguayo"));
                    }
                    break;
                default:
                    break;

                case 8:
                    {
                        string cad = "Amanda tiene tres serpientes";
                        
                        EscribeArrays(PalabrasMismaLetra(cad));
                    }
                    break;
                case 9:
                    {
                        Console.WriteLine(NumeroTexto99(22));
                        Console.WriteLine(NumeroTexto99(42));
                        Console.WriteLine(NumeroTexto99(96));
                        Console.WriteLine(NumeroTexto999(245));
                        Console.WriteLine(NumeroTexto999(589));
                        Console.WriteLine(NumeroTexto999(652));

                    }
                    break;

                case 10:
                    {
                        Console.WriteLine(LimpiaCadena("             Hola, ¿qué tal? Soy amigo     de    Poti-Poti.   "));
                    }
                    break;

                case 11:
                    {
                        Console.WriteLine(CompruebaEmail("admin@mailserver1"));
                        Console.WriteLine(CompruebaEmail(" very.common@example.com") + "        very.common@example.com");
                        Console.WriteLine(CompruebaEmail("very..common@example.com") + "       very..common@example.com");
                        Console.WriteLine(CompruebaEmail("very.common@exam@ple.com") + "       very.common@exam@ple.com");
                        Console.WriteLine(CompruebaEmail(".very.common@example.com") + "       .very.common@example.com");
                        Console.WriteLine(CompruebaEmail("very.common@example.com.") + "       very.common@example.com.");
                        Console.WriteLine(CompruebaEmail("very.com-mon@example.com") + "       very.com-mon@example.com");
                        Console.WriteLine(CompruebaEmail("very.common@example.com-") + "       very.common@example.com-");
                        Console.WriteLine(CompruebaEmail("-very..common@example.com") + "       -very..common@example.com");
                    }
                    break;

                case 12:
                    {
                        Console.WriteLine(PalabrasImpares("El perro de San Roque"));
                    }
                    break;

                case 13:
                    {
                        Console.WriteLine(CuentaDiptongos("Puede caer una bien buena"));
                    }
                    break;

                case 14:
                    {
                        string[] cad = { "patata", "c3po", "5874", "tomate", "pimineto?" };
                    EscribeArrays(FiltraArrayPalabras(cad));
                    }
                    break;
            }
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

        static void EscribeNombres (string cad)
        {
            string[] palabras = cad.Split(" ");

            for (int i = 0; i < palabras.Length -2; i = i + 3)
            {
                Console.Write(palabras[i + 2] + " " + palabras[i] + " " + palabras[i + 1 ]);
                Console.WriteLine();
            }


        }

        static int[] CuentaLetras(string cad)
        {
            int[] posiciones = new int[27];
            string abc = "abcdefghijklmnñopqrstuvwxyz";

            for (int i = 0; i < cad.Length; i++)
            {
                for (int k = 0; k < abc.Length; k++)
                {
                    if (cad[i] == abc[k])
                    {
                        posiciones[k] = posiciones[k] + 1;
                    }
                }

                
            }
            return posiciones;
        }

        static string MayusculasMinusculas(string cad, int n)
        {
            bool mayus = true;
            switch (n)
            {
                case 1:  cad = cad.ToLower(); break;
                case 2: cad = cad.ToUpper(); break;
                case 3: cad = MaysuculasPrimera(cad); break;
                case 4:
                    
                    for (int i = 0; i < cad.Length; i++)
                    {
                       
                        if (cad[i] == '.' )
                        {
                            mayus = true;
                        }

                        if (mayus && char.IsLetter(cad[i]))
                        {
                            cad = cad.Substring(0, i)+ char.ToUpper(cad[i]) + cad.Substring(i + 1);
                            mayus = false;
                        }

                       
                    }
                    break;      
            }

            return cad;



        }

        static string EliminaTags (string cad)
        {
            int pos1 = 0, pos2 = 0;
            bool pos1b = false, pos2b = false;

            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == '<')
                {
                    pos1 = i;
                    pos1b = true;
                }

                if (cad[i] == '>')
                {
                    pos2 = i;
                    pos2b = true;
                }

                if (pos1b && pos2b)
                {
                    cad = cad.Substring(0,pos1) + cad.Substring(pos2 +1);
                    i = i - (pos2 - pos1);
                    pos1b = false;
                    pos2b = false;
                }
            }

            return cad;
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

        static void EscribeArrays(string [] a)
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

        static string OrdenaPalabrasComas (string cad)
        {
            string aux;
            string[] palabras = cad.Split(",");
            
                for (int i = 0; i < palabras.Length; i++)
                  {
                for (int k = 0; k < palabras.Length - 1; k++)
                {
                    
                        if (palabras[k].CompareTo(palabras[k + 1]) > 0)
                        {
                            aux = palabras[k + 1];
                            palabras[k + 1] = palabras[k];
                            palabras[k] = aux;
                        }
                    
                }
                cad = string.Join(',', palabras);
                
            }
            return cad;
        }

        static string OrdenaPalabrasComasSeleccion (string cad)
        {
            int posMin = 0;
            
            string min;
            string[] palabras = cad.Split(","), aux = new string [palabras.Length];
          

            for (int i = 0; i < aux.Length; i++)
            {
                min = palabras[0];
                posMin = 0;
                for (int k = 0; k < palabras.Length; k++)
                {
                    if (palabras[k] != null)
                    {
                        if (min == null || min.CompareTo(palabras[k]) > 0)
                        {
                            min = palabras[k];
                            posMin = k;
                        }
                    }
                }

                aux[i] = min;
                palabras[posMin] = null;
            }

           cad = string.Join(',', aux);

            return cad;

            

           
        }

        static string AcentosHTML (string cad)
        {
            string[] mnemo = { "&lt;", "&gt;", "&amp;", "&quot", "&aacute;", "&Aacute", "aecute;", "Eacute;", "&iacute;", "&Iacute;", "&oacute;", "&Oacute,", "&uacute;", "Uacute;", "ntilde;", "&Ntilde;", "&Ntilde;", "&uuml;", "&Uuml;" };
            string aux="";          
            string signo = "<>&\"áÁéÉiÍóÓúÚñÑüÜ";
            bool encontrado = false;

            for (int i = 0; i < cad.Length; i++)
            {
                for (int k = 0; k < signo.Length; k++)
                {
                    if (cad[i] == signo[k])
                    {
                        aux = aux + mnemo[k];
                        k = signo.Length;
                        encontrado = true;
                    }

                }
                if (encontrado)
                {                   
                    encontrado = false; 
                }
                else
                {
                    aux = aux + cad[i];
                }
                
            }

            return aux;
        
        
        }

        static string[] PalabrasMismaLetra(string cad)
        {
            string[] palabras, total;
            cad = cad.ToLower();
            string aux = "";
            int cont = 0;

            for (int i = 0; i < cad.Length; i++)
            {
                if (!(char.IsLetter(cad[i])))
                {
                    aux = aux + ' ';
                }
                else
                {
                    aux = aux + cad[i];
                }
            }

            palabras = cad.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i][0] == palabras[i][palabras[i].Length - 1])
                {
                    cont++;
                }
            }

            total = new string[cont];
            cont = 0;
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i][0] == palabras[i][palabras[i].Length - 1])
                {
                    total[cont] = palabras[i];
                    cont++;
                }
            }

            return total;
        }

        static string NumeroTexto9 (int n)
        {
            string numero ="";

            switch (n)
            {
                case 1: numero = "uno"; break;
                case 2: numero = "dos"; break;
                case 3: numero = "tres"; break;
                case 4: numero = "cuatro"; break;
                case 5: numero = "cinco"; break;
                case 6: numero = "seis"; break;
                case 7: numero = "siete"; break;
                case 8: numero = "ocho"; break;
                case 9: numero = "nueve"; break;
                case 0: numero = "cero"; break;
            }

            return numero;
        }

        static string NumeroTexto99 (int n)
        {
            string cad = "";

            if (n > 99 || n < 0)
            {
                return cad;
            }
            else
            {



                if (n < 10)
                {
                    cad = NumeroTexto9(n);
                }

                if (n <= 15)
                {
                    switch (n)
                    {
                        case 10: cad = "diez"; break;
                        case 11: cad = "once"; break;
                        case 12: cad = "doce"; break;
                        case 13: cad = "trece"; break;
                        case 14: cad = "catorce"; break;
                        case 15: cad = "quince"; break;
                    }
                }
                else
                {
                    if (n < 20)
                    {
                        cad = "dieci" + NumeroTexto9(n % 10);
                    }
                    else
                    {
                        switch (n / 10)
                        {
                            case 2: cad = "veinte"; break;
                            case 3: cad = "treinta"; break;
                            case 4: cad = "cuarenta"; break;
                            case 5: cad = "cincuenta"; break;
                            case 6: cad = "sesenta"; break;
                            case 7: cad = "setenta"; break;
                            case 8: cad = "ochenta"; break;
                            case 9: cad = "noventa"; break;
                        }

                        if(n % 10 > 0 && n / 10 > 2)
                        {
                            cad = cad + " y " + NumeroTexto9(n % 10);
                        }
                        else
                        {
                            cad = "veinti" + NumeroTexto9(n % 10);
                        }
                    }
                }
            }

            return cad;



        }

        static string NumeroTexto999 (int n)
        {
            string cad ="";
            if (n > 1000)
            {
                return cad;
            }
            if (n < 100)
            {
                NumeroTexto99(n);
            }
            if (n == 100)
            {
                cad = "cien";
            }
            else
            {
                switch (n / 100)
                {
                    case 1: cad = "ciento "; break;
                    case 2: cad = "doscientos "; break;
                    case 3: cad = "trescientos "; break;
                    case 4: cad = "cuatrocientos "; break;
                    case 5: cad = "quinientos "; break;
                    case 6: cad = "seiscientos "; break;
                    case 7: cad = "setecientos "; break;
                    case 8: cad = "ochocientos "; break;
                    case 9: cad = "novecientos "; break;
                }

                if (n % 10 > 0)
                {
                    cad = cad + NumeroTexto99(n % 100);
                }
            }

            return cad;
        }

        static string LimpiaCadena (string cad)
        {
            string aux ="";

            for (int i = 0; i < cad.Length; i++)
            {
                if (!(char.IsLetter(cad[i]))) 
                {
                    aux = aux + ' ';
                }
                else
                {
                    aux = aux + cad[i];
                }
            }

            cad = "";
            for (int i = 0; i < aux.Length - 1; i++)
            {
                if (aux[i] == ' ' && aux[i +1] != ' ' || aux[i] != ' ')
                {
                    cad = cad + aux[i]; 
                }
            }
            cad = cad.TrimStart();
            cad = cad.TrimEnd();

            return cad;
        }

        static bool CompruebaEmail (string cad)
        {
            string[] partes;
            int cont = 0;
            string imposible = "ñÑáéíóúÁÉÍÓÚ";

            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == '@' && cad[i] != 0 && cad[i] != cad.Length - 1)
                {
                    cont++;
                }
            }

            if (cont != 1)
            {
                return false;
            }

            partes = cad.Split("@");

            for (int i = 0; i < partes.Length; i++)
            {
                for (int j = 0; j < partes[i].Length; j++)
                {
                    for (int k = 0; k < imposible.Length; k++)
                    {
                        if (partes[i][j] == imposible[k])
                        {
                            return false; 
                        }                       
                    }
                }
            }

            for (int i = 0; i < partes.Length; i++)
            {
                if (partes[i][0] == '-' || partes[i][partes[i].Length -1 ] == '-' ||partes[i][0] == '.' || partes[i][partes[i].Length -1] == '.')
                {
                    return false;
                }

                for (int k = 0; k < partes[i].Length - 1; k++)
                {
                    if (partes[i][k] == '.' && partes[i][k + 1] == '.')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static string PalabrasImpares ( string cad)
        {
            cad = LimpiaCadena(cad);
            string[] palabras;
            string aux = "";

            palabras = cad.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length % 2 == 1)
                {
                    aux = aux + palabras[i] + " ";
                }
            }

            return aux;
        }

        static int CuentaDiptongos (string cad)
        {
            int cont = 0;
            string[] diptongos = {"uo","uó", "ue","ui","üi", "üe", "ué", "ua", "uá", "iu", "io", "ie", "ia", "ou", "oi", "eu", "ei", "au", "ai", "ió", "oy", "iá", "ah","eh","ih","oh","uh", "ay", "ey", "uy"};
            
            cad = cad.ToLower();

            for (int i = 0; i < cad.Length -1; i++)
            {
                for (int k = 0; k < diptongos.Length; k++)
                {
                    if (cad[i] == diptongos[k][0] && 
                        cad[i+1] == diptongos[k][1])
                    {
                        cont++; 
                    }

                }
            }

            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == 'q' || cad[i] == 'g')
                {

                }
            }

            return cont;
        }

        static string[] FiltraArrayPalabras (string[] palabras)
        {
            int cont = 0, j = 0;
            string[] aux = new string [0];

            for (int i = 0; i < palabras.Length; i++)
            {
                cont = 0;
                for (int k = 0; k < palabras[i].Length; k++)
                {
                    if (char.IsLetter(palabras[i][k]))
                    {
                        cont++;
                    }
                }

                if (cont == palabras[i].Length)
                {
                    Array.Resize(ref aux, aux.Length + 1);
                    aux[j] = palabras[i];
                    j++;
                }               
            }

            return aux;

        }
    }
}

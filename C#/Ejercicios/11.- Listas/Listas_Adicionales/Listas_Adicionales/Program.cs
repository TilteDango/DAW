using System;
using System.Collections.Generic;
using System.Linq;
namespace Listas_Adicionales
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
                        List<int> l = new List<int> { 5, 5, 1, 2, 8, 3, 0, 3, 2, 2, 5, 7, 5 };

                        OrdenaRepetidos(l);
                        EscribeList(l);
                    }
                    break;

                case 2:
                    {
                        List<int> l = new List<int> { 5, 5, 1, 2, 8, 3, 0, 3, 2, 2, 5, 7, 5 };
                        List<int> aux = new List<int>();

                       aux = ElementosUnicos(l);
                        EscribeList(aux);
                        aux = ElementosRepetidos(l);
                        EscribeList(aux);

                    }
                    break;

                case 3:
                    {

                        List<int> l = new List<int> { 1,1,2,6,0,0,5,4};
                        List<int> aux = new List<int>();

                        aux = ListaDominoDobles(l);
                        EscribeList(aux);
                        
                    }
                    break;

                case 4:
                    {
                        List<string> palabras = new List<string>();
                        string frase = "Amanda tiene tres serpientes";

                         palabras = PalabrasMismaLetra(frase);
                        EscribeLists(palabras);
                    }
                    break;

                case 5:
                    {
                        List<string> palabras = new List<string>();
                        string frase = "Mi mamá me mima";
                        int letras = 4;
                        palabras = ListaPalabrasLargas(frase, letras);
                        EscribeLists(palabras);
                    }
                    break;

                case 6:
                    {
                        List<string> localidades = new List<string> {"Jerez" , "Tarifa", "Barbate" };
                        List<double> temperatura = new List<double> { 18.9, 14.1, 18.6};

                        HaceCalor(localidades, temperatura);

                        EscribeLists(localidades);
                        EscribeListl(temperatura);

                    }
                    break;
                default:
                    break;
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

        static void EscribeLists(List<string> l)
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

        static void EscribeListl(List<double> l)
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
                    Console.Write(l[i] + " ");
                }
            }

            Console.WriteLine(">");


        }


        static void OrdenaRepetidos (List<int> l)
        {
            List<int> aux = new List<int>();
            int max = 0, cont = 0, maxvalue = 0, vecesrepite;
            while (l.Count != 0)
            {

                max = 0;
                for (int i = 0; i < l.Count; i++)
                {
                    cont = 0;
                    for (int k = 0; k < l.Count; k++)
                    {
                        if (l[i] == l[k])
                        {
                            cont++;
                        }
                    }

                    if (cont > max)
                    {
                        maxvalue = l[i];
                        max = cont;
                    }                    
                }

                for (int i = 0; i < max; i++)
                {
                    aux.Add(maxvalue);
                }

                l.RemoveAll(p => p == maxvalue);  
                
            }

            l.AddRange(aux);

        }

        static List<int> ElementosUnicos (List<int> l)
        {
            List<int> aux = new List<int>();
            int cont = 0;

            for (int i = 0; i < l.Count; i++)
            {
                cont = 0;

                for (int k = 0; k < l.Count; k++)
                {
                    if (l[i] == l[k])
                    {
                        cont++;
                    }
                }

                if (cont == 1)
                {
                    aux.Add(l[i]);
                }
            }
            return aux;
        }

        static List<int> ElementosRepetidos (List<int> l)
        {
            List<int> aux = new List<int>();
            int cont = 0;

            for (int i = 0; i < l.Count; i++)
            {
                cont = 0;

                for (int k = 0; k < l.Count; k++)
                {
                    if (l[i] == l[k])
                    {
                        cont++;
                    }
                }

                if (cont != 1)
                {
                    aux.Add(l[i]);

                }
            }

            for (int i = 0; i < aux.Count; i++)
            {
                cont = 0;
                for (int k = 0; k < aux.Count; k++)
                {
                    if (aux[i] == aux[k])
                    {
                        cont++;
                    }
                }

                if (cont != 1)
                {
                    aux.Remove(aux[i]);
                    i--;
                }
            }
            return aux;
        }

        static List<int> ListaDominoDobles (List<int> fichas)
        {
            List<int> error = new List<int>();
            List<int> repetidas = new List<int>();
            if (fichas.Count % 2 != 0)
            {
                Console.WriteLine("ERROR");
                return error;
            }

            for (int i = 0; i < fichas.Count; i++)
            {
                if (fichas[i] > 6 || fichas[i] < 0)
                {
                    Console.WriteLine("ERROR");
                    return error;
                }
            }

            for (int i = 0; i < fichas.Count; i++)
            {
                if (i % 2 == 0)
                {


                    if (fichas[i] == fichas[i + 1])
                    {
                        repetidas.Add(fichas[i]);
                        repetidas.Add(fichas[i]);
                    }
                }
            }

            return repetidas;
        }

        static List<string> PalabrasMismaLetra (string frase)
        {
            List<string> palabras = new List<string>();
            string[] separadas;
            frase = frase.ToLower();
            separadas = frase.Split(' ');


            for (int i = 0; i < separadas.Length; i++)
            {

                if (separadas[i][0] == separadas[i][separadas[i].Length -1])
                {
                    palabras.Add(separadas[i]);
                }
            }

            return palabras;
        }

        static List<string> ListaPalabrasLargas(string frase, int letras) 
        {
            frase = frase.ToLower();
            List<string> l = new List<string>();
            string[] palabras;

            palabras = frase.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length >= letras)
                {
                    l.Add(palabras[i]);
                }
            }

            return l;
        }

        static void HaceCalor (List<string> localidades, List<double> temperatura)        {

            double media = 0;
            if (localidades.Count != temperatura.Count)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                for (int i = 0; i < temperatura.Count; i++)
                {
                    media = media + temperatura[i];
                }

                media = media / temperatura.Count;

                for (int i = 0; i < temperatura.Count; i++)
                {
                    if (temperatura[i] < media)
                    {
                        temperatura.RemoveAt(i);
                        localidades.RemoveAt(i);
                        i--;
                    }
                }

            }


        }


    }
}

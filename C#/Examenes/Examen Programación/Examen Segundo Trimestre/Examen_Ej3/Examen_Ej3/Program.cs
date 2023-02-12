using System;
using System.IO;

namespace Examen_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            InvierteMayusculas("texto.txt", "copia.txt");
        }

        static void InvierteMayusculas (string fichero, string copia)
        {
            string aux="", aux2 ="";
            StreamWriter sw = new StreamWriter(copia);
            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                aux = aux + sr.ReadLine();
            }

            for (int i = 0; i < aux.Length; i++)
            {
                if (char.IsLetter(aux[i]))
                {
                    if (char.IsUpper(aux[i]))
                    {
                        aux2 = aux2 + char.ToLower(aux[i]);
                    }
                    else
                    {
                        aux2 = aux2 + char.ToUpper(aux[i]);
                    }
                }
                else
                {
                    aux2 = aux2 + aux[i];
                }

                
            }
            sw.WriteLine(aux2);

            sw.Close();
            sr.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Objetos_Ejercicio__7____Profesores_y_Tribunal
{
    class Tribunal
    {
        private List<Profesor> listaProfesores = new List<Profesor>();

        public Tribunal(string fichero)
        {
            listaProfesores.AddRange(LeeFichero(fichero));
        }



        private List<Profesor> LeeFichero(string fichero)
        {
            List<Profesor> aux = new List<Profesor>();
            string nombre = "", dni = "";
            int iaux;
            TipoGenero genero;
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                nombre = br.ReadString();
                dni = br.ReadString();
                iaux = br.ReadInt32();

                if (iaux == 0)
                {
                    genero = TipoGenero.Hombre;
                }
                else
                {
                    if (iaux == 1)
                    {
                        genero = TipoGenero.Mujer;
                    }
                    else
                    {
                        throw new Exception("El fichero no esta bien escrito");
                    }
                }

                Profesor profesor = new Profesor(nombre, dni, genero);
                aux.Add(profesor);
            }

            br.Close();
            fs.Close();

            return aux;
        }

        public void EligeTribunal()
        {
            Random r = new Random();
            int contm = 0, conth = 0;
            for (int i = 0; i < listaProfesores.Count; i++)
            {
                Console.WriteLine(listaProfesores[i]);
            }

            Console.WriteLine();
            int n = (r.Next(listaProfesores.Count));
            Console.WriteLine("En el sorteo ha salido la posición: " + (n+1));
            Console.WriteLine();
            Console.WriteLine("Vocales elegidos en el sorteo: ");

            while (contm != 2 || conth != 2)
            {
                if (contm < 2 && listaProfesores[n].Genero == TipoGenero.Mujer)
                {
                    Console.WriteLine(listaProfesores[n]);
                    contm++;
                }

                if (conth < 2 && listaProfesores[n].Genero == TipoGenero.Hombre)
                {
                    Console.WriteLine(listaProfesores[n]);
                    conth++;
                }

                if (n == listaProfesores.Count - 1)
                {
                    n = -1;
                }
                    n++;     
            }             
        }

        public void EligeTribunalPro()
        {
            listaProfesores.Sort();
            EligeTribunal();
        }
    }
}

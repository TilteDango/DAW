using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Examen_Programacion_Ej1
{
    class ColeccionOnline
    {
        private List<Videojuego> listaVideojuegos = new List<Videojuego>();

        public ColeccionOnline()
        {
            string ext = ".txt";
            string cf = Directory.GetCurrentDirectory();
            string[] ficheros = Directory.GetFiles(cf);

            for (int i = 0; i < ficheros.Length; i++)
            {
                FileInfo f = new FileInfo(ficheros[i]);

                if (f.Extension == ext)
                {
                    listaVideojuegos.Add(LeeVideojuego(ficheros[i]));
                }

            }
        }

        private Videojuego LeeVideojuego(string fichero)
        {
            string name = "", annostring = "";
            int anno = 0;
            TipoPlataforma tp = TipoPlataforma.Steam;
            List<TipoPlataforma> l = new List<TipoPlataforma>();
            StreamReader sr = new StreamReader(fichero);

            while (!sr.EndOfStream)
            {
                string[] linea = sr.ReadLine().Split('(');
                for (int i = 0; i < linea[0].Length - 1; i++)
                {
                    name += linea[0][i];
                }

                for (int i = 0; i < linea[1].Length - 1; i++)
                {
                    annostring += linea[1][i];
                }

                anno = int.Parse(annostring);

                for (int i = 0; i < 5; i++)
                {
                    linea = sr.ReadLine().Split(' ');

                    switch (i)
                    {
                        case 0: tp = TipoPlataforma.Steam; break;
                        case 1: tp = TipoPlataforma.Epic; break;
                        case 2: tp = TipoPlataforma.GOG; break;
                        case 3: tp = TipoPlataforma.Humble; break;
                        case 4: tp = TipoPlataforma.Amazon; break;
                    }

                    if (linea[1] == "Yes")
                    {
                        l.Add(tp);
                    }

                }

            }
            sr.Close();
            return new Videojuego(name, l, anno);
        }

        //    public override string ToString()
        //    {
        //        string s = "";
        //        for (int i = 0; i < listaVideojuegos.Count; i++)
        //        {
        //            s += listaVideojuegos[i] + "\n";
        //        }
        //        return s;
        //    }
        //}

        public void ImprimeLista(TipoPlataforma tp)
        {
            for (int i = 0; i < listaVideojuegos.Count; i++)
            {
                if (listaVideojuegos[i].Plataformas.Contains(tp))
                {
                    Console.WriteLine(listaVideojuegos[i]);
                }
            }
        }

    }
}

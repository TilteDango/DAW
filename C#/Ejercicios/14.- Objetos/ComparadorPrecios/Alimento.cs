using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ComparadorPrecios
{
    internal class Alimento
    {
        private int price;
        private int decimals;
        private string url;

        public Alimento()
        {

            GetPrice("Prueba.txt");
        }

        private string GetURLAlcampo(string search)
        {
            return "https://www.alcampo.es/compra-online/search/?department=&text=" + search;
        }

       

        private static void DownloadFile()
        {
            WebClient wc = new WebClient();
            wc.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            wc.DownloadFile("https://www.carrefour.es/supermercado/pechuga-de-pavo-en-lonchas-finas-bajo-contenido-en-grasas-y-reducido-en-sal-carefour-sin-gluten-pack-de-2-unidades-de-200-g/R-VC4AECOMM-472699/p", "Prueba.txt");

        }

        public static int GetPrice(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string page = sr.ReadToEnd();
            int price, start, end, cont =  0;

            bool write = false;

            start = page.IndexOf("buybox__price");
            end = page.IndexOf(">", start);
            page = page.Substring(start, end - start);
            string pricestring = "";    

            for (int i = 0; i < page.Length; i++)
            {
                if (page[i] == '>')
                {
                    if (page[i] == '>' && cont == 1)
                    {
                        write = true;
                    }
                    else
                    {
                        cont++;
                    }
                              
                }
                else
                {
                    if (write)
                    {
                        if (char.IsDigit(page[i]))
                        {
                            pricestring += page[i];
                        }
                    }
                }
            }

            price = int.Parse(pricestring);

            return price;


        }

        public override string ToString()
        {
            return price.ToString();
        }

    }
}

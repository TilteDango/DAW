using System;
using System.Collections.Generic;
using System.IO;

namespace Examen_Ej1
{
    class Program
    {
        public class Ips
        {
            public int p1;
            public int p2;
            public int p3;
        }
        static void Main(string[] args)
        {
            GeneraServidorDHCP("GeneraServidorDHCP.txt", 1000);
        }

        static void GeneraServidorDHCP (string fichero, int n)
        {
            int[] ips = new int[3];

            bool esta = false;
            List<Ips> usadas = new List<Ips>();

            StreamWriter sw = new StreamWriter(fichero);
            Random r = new Random();
            sw.WriteLine("subnet 10.0.0.0 netmask 255.0.0.0 {");

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < ips.Length; k++)
                {
                    ips[k] = r.Next(0, 255);
                }

                for (int k = 0; k < usadas.Count; k++)
                {
                    if (ips[0] == usadas[k].p1 && ips[1] == usadas[k].p2 && ips[0] == usadas[k].p3)
                    {
                        esta = true;
                    }
                }

                if (!esta)
                {
                    sw.WriteLine("   range "+ 10 + "." + ips[0] + "." + ips[1] + "." + ips[2] + ";");
                    Ips us = new Ips();
                    us.p1 = ips[0];
                    us.p2 = ips[1];
                    us.p3 = ips[2];
                    usadas.Add(us);
                    esta = false;
                }
                
                
            }


            sw.WriteLine("}");
            sw.Close();
           
        }
    }
}

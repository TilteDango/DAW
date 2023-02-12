using System;

namespace Relacion3_Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //Console.WriteLine("¿Cuántos días tiene el mes que tu quieres? (1/12)");
            //n = int.Parse(Console.ReadLine());

            //Console.WriteLine(DiasMes(n));

            Console.WriteLine(SegundosTranscurridos1980(28,10,2021,2,43,15));
        }

        static int DiasMes(int mes)
        {
            if (mes == 1 || (mes == 3) || (mes == 5) || (mes == 7) || mes == 8 || mes == 10 || mes == 12)
            {
                return 31;
            }

            else
            {
                if (mes == 2)
                {

                    return 28;

                }
                else
                {
                    return 30;
                }
            }
        }

        static bool Bisiesto(int n)
        {
            if (n % 4 == 0)
            {
                if (n % 100 == 0)
                {
                    if (n % 400 == 0)
                    {
                        return true;
                    }

                    return false;
                }

                return true;
            }

            else
            {
                return false;
            }
        }

        static int DiasMes2(int mes, int anno)
        {
            if (mes == 2 && Bisiesto(anno))
            {
                return 29;
            }
            else
            {
                int d = DiasMes(mes);
                return d;
            }
        }

        static int DiasTranscurridos(int dia, int mes, int anno)
        {
            int total = 0;

            if (mes >= 2)
            {
                for (int i = 1; i < mes; i++)
                {
                    total = total + DiasMes(i);
                }
                if (Bisiesto(anno))
                {
                    total = total + 1;
                }

                total = total + dia;
            }
            else
            {
                if (mes == 1)
                {
                    mes = 0;
                }

                total = mes + dia;
            }

            return total;
        }

        static int DiasTranscurridos1980(int dia, int mes, int anno)
        {
            int total = 0;
            for (int i = 1980; i < anno; i++)
            {
                if (Bisiesto(i))
                {
                    total = total + 366;
                }
                else
                {
                    total = total + 365;
                }
            }

            total = total + DiasTranscurridos(dia, mes, anno);

            return total;
        }

        static int DiasEntreFechas(int dia, int mes, int anno, int dia2, int mes2, int anno2)
        {
            int total;
            total = DiasTranscurridos1980(dia2, mes2, anno2) - DiasTranscurridos1980(dia, mes, anno);
            return total;
        }

        static int DiaSemanaFecha(int dia, int mes, int anno)
        {
            int i, total;
            total = DiasTranscurridos1980(dia, mes, anno);

            while (total >= 7)
            {
                total = total - 7;
            }

            total = total + 1;

            return total;

        }

        static int HoraASegundos(int hora, int min, int seg)
        {
            int total;
            total = (hora * 3600) + (min * 60) + seg;

            return total;
        }

        static void EscribeHoraBonita(int hora, int min, int seg)
        {
            if (hora < 10)
            {
                Console.Write("0" + hora + ":");
            }
            else
            {
                Console.Write(hora + ":");
            }

            if (min < 10)
            {
                Console.Write("0" + min + ":");
            }
            else
            {
                Console.Write(min + ":");
            }

            if (seg < 10)
            {
                Console.Write("0" + seg);
            }
            else
            {

                Console.Write(seg);
            }

            Console.WriteLine();
        }
                  
        static void EscribeSegundosBonitos (int seg)
        {
            int total = seg, horas = 0, min = 0;
            while (total >= 3600)
            {
                total = total - 3600;
                horas++;
            }

            while (total >= 60)
            {
                total = total - 60;
                min++;
            }
       
            EscribeHoraBonita(horas, min, total);
        }

        static int SegundosTranscurridos ( int hora, int min, int seg, int hora2, int min2, int seg2)
        {
            int total;

            total = HoraASegundos(hora2, min2, seg2) - HoraASegundos(hora, min, seg);

            return total;
        }
   
        static int SegundosTranscurridos1980 ( int dia, int mes, int anno, int hora, int min, int seg)
        {
            int totald, vuelta;

            totald = DiasTranscurridos1980(dia, mes, anno);

            totald = totald * 24 + hora;



            vuelta = HoraASegundos(totald, min, seg);

            return vuelta; 
        }
    
    }

}

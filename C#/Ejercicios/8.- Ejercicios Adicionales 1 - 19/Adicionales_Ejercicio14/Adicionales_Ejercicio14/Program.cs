using System;

namespace Adicionales_Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anno;
            Console.WriteLine("Dime el día");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el mes");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el año");
            anno = int.Parse(Console.ReadLine());
            if (DiasMes2(mes, anno) < dia)
            {
                Console.WriteLine("Fecha no válida");
            }
            else
            {
                EscribeFechaBonita(dia, mes, anno);
            }

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

        static string MesEnTexto(int n)
        {
            string mes;
            switch (n)
            {
                case 1:
                    mes = "Enero";
                    break;
                case 12:
                    mes = "Diciembre";
                    break;
                case 2:
                    mes = "Febrero";
                    break;
                case 3:
                    mes = "Marzo";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Mayo";
                    break;
                case 6:
                    mes = "Junio";
                    break;
                case 7:
                    mes = "Julio";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Septiembre";
                    break;
                case 10:
                    mes = "Octubre";
                    break;
                case 11:
                    mes = "Noviembre";
                    break;
                default:
                    Console.WriteLine("Mes no válido, vuelva a introducirlo");
                    Console.WriteLine();
                    mes = "Mes no existente";
                    break;
            }
            return mes;

        }

        static void EscribeFechaBonita (int dia, int mes, int anno)
        {
            Console.WriteLine();
            Console.WriteLine(dia + "/" + MesEnTexto(mes) + "/" + anno);
        }

    }
}

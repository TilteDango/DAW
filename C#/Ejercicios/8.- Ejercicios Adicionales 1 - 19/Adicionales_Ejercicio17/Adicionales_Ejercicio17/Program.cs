using System;

namespace Adicionales_Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anno;
            Console.WriteLine("Vamos a ver si la fecha es válida");
            Console.WriteLine();
            Console.Write("Dime el día: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Dime el mes: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Dime el año: ");
            anno = int.Parse(Console.ReadLine());

            if(FechaCorrecta(dia, mes, anno))
            {
                Console.WriteLine("La fecha es válida");
            }
            else
            {
                Console.WriteLine("La fecha es inválida");
            }
        }

        static bool FechaCorrecta (int dia, int mes, int anno)
        {          
            if (dia > DiasMes2(mes,anno) || anno > 2100 || anno < 1980 || mes > 12 || mes < 0)
            {
                return false; 
            }
            else
            {
                return true;
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
    }
}

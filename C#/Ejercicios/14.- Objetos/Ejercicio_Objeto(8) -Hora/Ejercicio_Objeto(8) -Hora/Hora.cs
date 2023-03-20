using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Objeto_8___Hora
{
    class Hora
    {
        private int segundos;

        public Hora(int segundos)
        {
            if (segundos >= 0)
            {
                this.segundos = segundos;
            }
            else
            {
                throw new Exception("Los segundos deben ser positivos");
            }
        }

        public Hora(int hora, int minutos, int segundos)
        {
            if (segundos < 60 && segundos >= 0)
            {
                if (minutos < 60 && segundos >= 0)
                {
                    this.segundos = segundos + (minutos * 60) + (hora * 3600);
                }
                else
                {
                    throw new Exception("Los minutos no estan entre 0 y 59");
                }
            }
            else
            {
                throw new Exception("Los segundos no estan entre 0 y 59");
            }
        }

        public int SegundosTotales { get => segundos; 
            set
            {
                if (value >= 0)
                {
                    this.segundos = value;
                }
                else
                {
                    throw new Exception("Los segundos no pueden ser negativos");
                }
            }
           
            }

        public int Horas
        {
            get
            {
                int horas = this.segundos / 3600;
                return horas;
            }
            set
            {
                if (value >= 0)
                {
                    this.segundos = value * 3600 + Minutos * 60 + Segundos;
                }
                else
                {
                    throw new Exception("Las horas no son válidas");
                }
                
            }
        }

        public int Minutos
        {
            get
            {
                int minutos = (this.segundos % 3600) / 60;
                return minutos;
            }

            set
            {
                if (value >= 0 && value < 60)
                {
                    this.segundos = Horas * 3600 + value * 60 + Segundos;
                }
                else
                {
                    throw new Exception("Los minutos estan mal");
                }
            }
        }

        public int Segundos
        {
            get
            {
                int segundos = ((this.segundos % 3600) % 60);
                return segundos;
            }

            set
            {
                if (value >= 0 && value < 60)
                {
                    this.segundos = Horas * 3600 + Minutos * 60 + value;
                }
                else
                {
                    throw new Exception("Los segundos estan mal");
                }
            }
        }

        public void SumaHoras (int horas)
        {
            this.segundos += horas * 3600;
        }

        public void SumaMinutos (int minutos)
        {
            this.segundos += minutos * 60;
        }

        public void SumaSegundos (int segundos)
        {
            this.segundos += segundos;
        }

        public static Hora operator +(Hora h1, Hora h2)
        {
            return new Hora(h1.segundos + h2.segundos);
        }

        public static Hora operator -(Hora h1, Hora h2)
        {
            return new Hora(h1.segundos - h2.segundos);
        }

        public override string ToString()
        {
            string s = "";

            if (Horas < 10)
            {
                s += "0" + Horas;
            }
            else
            {
                s += Horas;
            }

            s += ":";

            if (Minutos < 10)
            {
                s += "0" + Minutos;
            }
            else
            {
                s += Minutos;
            }

            s += ":";

            if (Segundos < 10)
            {
                s += "0" + Segundos;
            }
            else
            {
                s += Segundos;
            }
            return s;
        }
    }
}

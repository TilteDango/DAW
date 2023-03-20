using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Objetos__10__Venta_De_Coches
{
    class Coche
    {
        private string matricula;
        private DateTime fechaMatriculacion;
        private string marca;
        private string modelo;
        private double precio;


        public Coche(string matricula, DateTime fechaMatriculacion, string marca, string modelo, double precio)
        {
            if (MatriculaVálida(matricula))
            {
                this.matricula = matricula; 
            }
            else
            {
                throw new Exception("La matricula no es válida");
            }

            if (fechaMatriculacion <= DateTime.Now.AddYears(-1))
            {
                this.fechaMatriculacion = fechaMatriculacion;
            }
            else
            {
                throw new Exception("La fecha de matriculación no es válida");
            }

            if (marca != null && modelo != null)
            {
                this.marca = marca;
                this.modelo = modelo;
            }
            else
            {
                throw new Exception("La marca o el modelo no pueden estar vacías");
            }

            this.Precio = precio;

           
        }

        public string Matricula { get => matricula; }
        public DateTime FechaMatriculacion { get => fechaMatriculacion;}
        public string Marca { get => marca;}
        public string Modelo { get => modelo;}
        public double Precio
        {
            get => precio;
            set
            {
                if (value <= 400)
                {
                    throw new Exception("El precio no es válido");
                }
                else
                {
                    this.precio = value;
                }
            }
        }

        private  bool MatriculaVálida(string matricula)
        {
            bool valido = true;
            if (matricula.Length == 7)
            {
                for (int i = 0; i < matricula.Length; i++)
                {
                    if (i < 4)
                    {
                        if (!char.IsDigit(matricula[i]))
                        {
                            valido = false; 
                        }
                    }
                    else
                    {
                        if (!char.IsLetter(matricula[i]))
                        {
                            valido = false;
                        }
                    }
                }
            }
            else
            {
                valido = false;
            }

            return valido;
           
        }

        public override string ToString()
        {
            return Marca.PadLeft(15) + " " + Modelo + "\n" +
                    "".PadLeft(30, '-') + "\n" +
                    "Matricula: " + Matricula + "\n" +
                    "Precio: " + Precio + "\n" +
                    "Fecha de Matriculación: " + fechaMatriculacion.ToShortDateString();
        }
    }
}

using System;

namespace Ejercicio_Clases_2__Grupo_Alumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo g = new Grupo();

            g.LeeFicheroBinario("Prueba.bin");
            

            Console.WriteLine(g);
        }
    }
}

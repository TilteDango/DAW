using System;

namespace Ejercicio_Objetos_6__Clinica_Y_Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            string[] raza2;
            ClinicaVeterinaria cv = new ClinicaVeterinaria();
            string nombre, comentarios, chip;
            int dia, mes, anno, opcion, l;
            double peso;
            bool cantor_venenoso;


            while (n != 0)
            {
                Console.WriteLine("Clinica veterinaria");
                Console.WriteLine("1. Añadir Perro");
                Console.WriteLine("2. Añadir Gato");
                Console.WriteLine("3. Añadir Pajaro");
                Console.WriteLine("4. Añadir Reptil");
                Console.WriteLine("5. Añadir Comentario");
                Console.WriteLine("6. Lista de animales");
                Console.WriteLine("¿Qué quieres hacer?");
                n = int.Parse(Console.ReadLine());



                switch (n)
                {
                    case 1:
                        Console.Write("Dime el nombre del perro: ");
                        nombre = Console.ReadLine();
                        Console.Write("Dime el año de nacimiento: ");
                        anno = int.Parse(Console.ReadLine());
                        Console.Write("DIme el mes de nacimiento: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Dime el día de nacimiento: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Dime el peso del perro: ");
                        peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Comentarios sobre el perro: ");
                        comentarios = Console.ReadLine();
                        Console.WriteLine("Dime la raza del perro: ");
                        raza2 = Enum.GetNames(typeof(RazaPerro));
                        for (int i = 0; i < raza2.Length; i++)
                        {
                            Console.WriteLine((i+1) + ". " + raza2[i]);
                        }
                        opcion = int.Parse(Console.ReadLine());
                        Console.Write("Dime el microchip del perro: ");
                        chip = Console.ReadLine();

                        Perro p = new Perro(nombre, new DateTime(anno, mes, dia), 7.5, ((RazaPerro)opcion - 1), chip);
                        cv.InsertaAnimal(p);

                        break;
                    case 2:
                        Console.Write("Dime el nombre del gato: ");
                        nombre = Console.ReadLine();
                        Console.Write("Dime el año de nacimiento: ");
                        anno = int.Parse(Console.ReadLine());
                        Console.Write("DIme el mes de nacimiento: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Dime el día de nacimiento: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Dime el peso del gato: ");
                        peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Comentarios sobre el gato: ");
                        comentarios = Console.ReadLine();
                        Console.WriteLine("Dime la raza del gato: ");
                        raza2 = Enum.GetNames(typeof(RazaGato));
                        for (int i = 0; i < raza2.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + raza2[i]);
                        }
                        opcion = int.Parse(Console.ReadLine());
                        Console.Write("Dime el microchip del gato: ");
                        chip = Console.ReadLine();

                        Gato g = new Gato(nombre, new DateTime(anno, mes, dia), 7.5, ((RazaGato)opcion - 1), chip);
                        cv.InsertaAnimal(g);

                        break;
                    case 3:
                        Console.Write("Dime el nombre del pajaro: ");
                        nombre = Console.ReadLine();
                        Console.Write("Dime el año de nacimiento: ");
                        anno = int.Parse(Console.ReadLine());
                        Console.Write("DIme el mes de nacimiento: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Dime el día de nacimiento: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Dime el peso del pajaro: ");
                        peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Comentarios sobre el pajaro: ");
                        comentarios = Console.ReadLine();
                        Console.WriteLine("Dime la raza del pajaro: ");
                        raza2 = Enum.GetNames(typeof(EspeciePajaro));
                        for (int i = 0; i < raza2.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + raza2[i]);
                        }
                        opcion = int.Parse(Console.ReadLine());
                        Console.WriteLine("El pajaro es cantor: ");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No ");
                        l = int.Parse(Console.ReadLine());

                        if (l == 1)
                        {
                            cantor_venenoso = true;
                        }
                        else
                        {
                            cantor_venenoso = false;
                        }

                        Pajaro paj = new Pajaro(nombre, new DateTime(anno, mes, dia), 7.5, ((EspeciePajaro)opcion - 1), cantor_venenoso);
                        cv.InsertaAnimal(paj);

                        break;
                    case 4:
                        Console.Write("Dime el nombre del reptil: ");
                        nombre = Console.ReadLine();
                        Console.Write("Dime el año de nacimiento: ");
                        anno = int.Parse(Console.ReadLine());
                        Console.Write("DIme el mes de nacimiento: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Dime el día de nacimiento: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Dime el peso del reptil: ");
                        peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Comentarios sobre el reptil: ");
                        comentarios = Console.ReadLine();
                        Console.WriteLine("Dime la raza del reptil: ");
                        raza2 = Enum.GetNames(typeof(EspecieReptil));
                        for (int i = 0; i < raza2.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + raza2[i]);
                        }
                        opcion = int.Parse(Console.ReadLine());
                        Console.WriteLine("El reptil es venenoso: ");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No ");
                        l = int.Parse(Console.ReadLine());

                        if (l == 1)
                        {
                            cantor_venenoso = true;
                        }
                        else
                        {
                            cantor_venenoso = false;
                        }

                        Reptil rep = new Reptil(nombre, new DateTime(anno, mes, dia), 7.5, ((EspecieReptil)opcion - 1), cantor_venenoso);
                        cv.InsertaAnimal(rep);

                        break;
                    case 5:

                        Console.Write("DIme el  nombre del animal: ");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Modifica el comentario");
                        comentarios = Console.ReadLine();
                        cv.ModificaComentarioAnimal(nombre, comentarios);
                        
                        
                        break;
                    case 6:

                        Console.WriteLine(cv); break;
                }
            }

            
        }
    }
}

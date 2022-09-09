using System;

namespace EjercicioArrayUnidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int numPersonas;

            //Pedimos al usuario el ingreso de la información
            Console.Write("Ingrese la cantidad de personas a registrar: ");
            numPersonas = Convert.ToInt32(Console.ReadLine());

            //Creamos los array
            string[] nombre = new string[numPersonas];
            string[] apellidoPaterno = new string[numPersonas];
            string[] apellidoMaterno = new string[numPersonas];
            string[] ciudad = new string[numPersonas];
            string[] region = new string[numPersonas];

            //Llenar el array
            for (int i = 0; i < numPersonas; i++)
            {
                //El usuario ingresa los datos
                Console.WriteLine("Ingrese los datos de la Persona {0}" , i+1);
                Console.WriteLine("\n");
                Console.Write("Nombre: ");
                nombre[i] = Console.ReadLine();
                Console.Write("Apellido Paterno: ");
                apellidoPaterno[i] = Console.ReadLine();
                Console.Write("Apellido Materno: ");
                apellidoMaterno[i] = Console.ReadLine();
                Console.Write("Ciudad: ");
                ciudad[i] = Console.ReadLine();
                Console.Write("Región: ");
                region[i] = Console.ReadLine();
              
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }

            //Mostrando la información
            for (int i = 0; i < numPersonas; i++)
            {
                Console.WriteLine("**** Registro Persona {0} ****", i+1);
                Console.WriteLine("\n");
                Console.WriteLine("Nombre:  {0}     Apellido Paterno:   {1}     Apellido Materno:   {2}     Ciudad:     {3}     Región:     {4}", nombre[i], apellidoPaterno[i], apellidoMaterno[i], ciudad[i], region[i]);
            }


        }
    }
}

using System;
using System.IO;

namespace Peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;

            do
            {
                mostrarMenu();

                entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "A":
                    case "a":
                        escribirArchivo();
                        break;

                    case "B":
                    case "b":
                        leerArchivo();
                        break;

                    default:
                        mostrarError();
                        break;
                }


            } while (entrada != "X" && entrada != "X");

            Console.ReadKey();
        }

        static void mostrarMenu()
        {
           
            Console.WriteLine("======== REGISTRO DE PELICULAS ==========\n");
            Console.WriteLine("A. Registrar Peliula");
            Console.WriteLine("B. Mostrar el listado de toda la pelicula");
            Console.WriteLine("\n=========================================");
            Console.WriteLine("Ingrese la opcion deseada: ");
        }

        static void escribirArchivo()
        {

            Console.Clear();

            int i;
            string texto = "";
            string ruta = @"D:\mi_archivo.txt";

            Console.WriteLine("Ingrese el texto a grabar: ");
            texto = Console.ReadLine();

            StreamWriter writer = File.AppendText(ruta);
            writer.WriteLine(texto);

            for (i = 1; i < 5; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("\nTitulo de la pelicula: ");
                    texto = Console.ReadLine();
                    writer.WriteLine(texto);
                }
                else if (i == 2)
                {
                    Console.WriteLine("\nDirector de la pelicula: ");
                    texto = Console.ReadLine();
                    writer.WriteLine(texto);
                }
                else if (i == 3)
                {Console.WriteLine("\nAño de la publicacion de la pelicula: ");
                    texto = Console.ReadLine();
                    writer.WriteLine(texto);
                }
                else
                {
                    Console.WriteLine("\nGenero de la pelicula: ");
                    texto = Console.ReadLine();
                    writer.WriteLine(texto);
                }
            }

            writer.Close();

            Console.Clear();
        }

        static void leerArchivo()
        {
            
            string ruta = @"D:\mi_archivo.txt";
            string linea = "";

            StreamReader file = new StreamReader(ruta);

            while ((linea = file.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }

            file.Close();
            Console.ReadKey();
        }

        static void mostrarError()
        {
            Console.Clear();
            Console.WriteLine("Opcion INVALIDA, pruebe con otra: ");
            Console.ReadKey();
        }
    }
}

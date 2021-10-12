using System;

namespace Temperaturas
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
                        mostrarQuincenal();
                        break;

                    case "B":
                    case "b":
                        mostrarMensual();
                        break;

                    case "C":
                    case "c":
                        Console.Clear();
                        Console.WriteLine("Programa terminado, hasta luego!");
                        break;

                    default:
                        mostrarError();
                        break;
                }


            } while (entrada != "C" && entrada != "c");

            Console.ReadKey();
        }

        static void mostrarMenu()
        {
            Console.WriteLine("======== T E M P E R A T U R A S ========");
            Console.WriteLine("A. Quincenal");
            Console.WriteLine("B. Mensual");
            Console.WriteLine("C. Salir");
            Console.WriteLine("=========================================");
            Console.WriteLine("Ingrese la opcion deseada: ");
        }

            static void mostrarQuincenal()
            {
            Console.Clear();

                int dia = 1;
                int i;

                float minimo = 15.0f;
                float maximo = 30.0f;

                float suma = 0.0f;
                
                Console.WriteLine("Usted eligio la opcion QUINCENAL!\n");
                float[] quincenal = new float[15];
                for (i = 0; i < 15; i++)
                {
                    Console.WriteLine("Ingrese la tempuratura del dia: {0}",dia);
                    dia = dia + 1;
                   
                    string valor = Console.ReadLine();
                    quincenal[i] = Convert.ToSingle(valor);
                }
                for (int n = 0; n < 15; n++)
                {
                    suma += quincenal[i];
                    
                }

                float promedio = suma / 15;
                
                for (i = 0; i < 15; i++)
                {
                if (quincenal[i] > maximo)
                    {
                        maximo = quincenal[i];
                    }
                }
                for (i = 0; i < 15; i++)
                {
                    if (quincenal[i] < minimo)
                    {
                        minimo = quincenal[i];
                    }
                }

                Console.Clear();
                Console.WriteLine("La temperatura minima es: {0}", minimo);
                Console.WriteLine("La temperatura maxima es: {0}", maximo);
                Console.WriteLine("El promedio de la temperatura es: {0}", Math.Round(promedio, 2));

            }

        static void mostrarMensual()
        {

            Console.Clear();

            int dia = 1;
            int i;

            float minimo = 15.0f;
            float maximo = 30.0f;

            float suma = 0.0f;

            Console.WriteLine("Usted eligio la opcion MENSUAL!\n");
            float[] mensual = new float[31];
            for(i = 0; i < 31; i++)
            {
                Console.WriteLine("Ingrese la temperatura del dia {0}",dia);
                dia++;
                string entrada = Console.ReadLine();
                mensual[i] = Convert.ToSingle(entrada);
            }
            for(int n = 0; n < 31; n++)
            {
                suma = suma + mensual[i];
            }
            float promedio = suma / 31;
            for (i = 0; i < 31; i++)
            {
                if (mensual[i] > maximo)
                {
                    maximo = mensual[i];
                }
                for (i = 0; i < 31; i++)
                {
                    if (mensual[i] < minimo)
                    {
                        minimo = mensual[i];
                    }
                }

                Console.Clear();
                Console.WriteLine("La temperatura minima es: {0}", minimo);
                Console.WriteLine("La temperatura maxima es: {0}", maximo);
                Console.WriteLine("El promedio de la temperatura es: {0}", Math.Round(promedio, 2));
            }

        }

        static void mostrarError()
        {
            Console.Clear();
            Console.WriteLine("Opcion incorrecta, pruebe con otra");
            Console.ReadKey();
        }

    }
}


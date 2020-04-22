using System;

namespace CarlProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string entrada;
            int edad;
            do
            {
                Console.WriteLine("favor de ingresar tu edad");
                entrada = Console.ReadLine();
                edad = Convert.ToInt32(entrada);
                NewMethod(edad);
                Console.WriteLine("Preciona G para continuar");
                entrada = Console.ReadLine();
            } while (entrada != "g");
        }

        private static void NewMethod(int edad)
        {
            if (edad >= 0 && edad <= 3)
            {
                Console.WriteLine("infante");
            }
            else if (edad >= 4 && edad <= 11)
            {
                Console.WriteLine("niño");
            }
            else if (edad >= 12 && edad <= 15)
            {
                Console.WriteLine(" pubertad");
            }
            else if (edad >= 16 && edad < 20)
            {
                Console.WriteLine("adolecencia");

            }
            else if (edad >= 21 && edad <= 35)
            {
                Console.WriteLine("juventud");
            }
            else if (edad >= 36 && edad <= 50)
            {
                Console.WriteLine("adulto");

            }
            else if (edad >= 50)
            {
                Console.WriteLine("adulto mayor");
            }
            else
            {}
        }
    }
    }




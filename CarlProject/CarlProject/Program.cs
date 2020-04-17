using System;

namespace CarlProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string entrada;
            int A,B;
            int r;

            Console.WriteLine("pon el valor de  A");
            entrada = Console.ReadLine();
            A = Convert.ToInt32(entrada);
            Console.WriteLine("pon el valor de B ");
            entrada = Console.ReadLine();
            B = Convert.ToInt32(entrada);
            r = A + B;
            

            Console.WriteLine("el resultado de:"+ r);
            Console.WriteLine("precione enter para continuar");
            entrada = Console.ReadLine();

        }
    }           
}

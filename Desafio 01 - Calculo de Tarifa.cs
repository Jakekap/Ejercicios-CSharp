using System;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Selector de Tarifa

            Console.WriteLine("Ingrese su SMMLV para calcular su tarifa >> ");
            double dinero = double.Parse(Console.ReadLine());

            double smmlv = dinero / 828116; 

            //Condiciones

            if (smmlv < 2)
            {
                Console.WriteLine("> Tarifa A <");
            }
            else if (smmlv >= 2 & smmlv < 4)
            {
                Console.WriteLine("> Tarifa B <");
            }
            else
            {
                Console.WriteLine("> Tarifa C <");
            }
        }
    }
}

using System;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Selector de Tarifa

            Console.WriteLine("Ingrese su SMMLV para calcular su tarifa y cuota moderadora para citas\ngenerales>> ");
            double dinero = double.Parse(Console.ReadLine());

            double smmlv = dinero / 828116; 

            //Condiciones

            if (smmlv < 2)
            {
                Console.WriteLine("> Tarifa A <");
                Console.WriteLine("Cuota moderadora >> $3.200");
            }
            else if (smmlv >= 2 & smmlv < 5)
            {
                Console.WriteLine("> Tarifa B <");
                Console.WriteLine("Cuota moderadora >> $12.700");
            }
            else
            {
                Console.WriteLine("> Tarifa C <");
                Console.WriteLine("Cuota moderadora >> $33.500");
            }
        }
    }
}

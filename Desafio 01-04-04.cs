using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01_04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de datos

            Console.WriteLine("Inserte el valor de (W) >>");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el valor de (T) >>");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el valor de (C) >>");
            double c = double.Parse(Console.ReadLine());

            //Calculo matematico

            double e = 180 - c;
            double d = Math.Round(Math.Asin(t * (Math.Sin(Math.PI * e / 180)) / 5) * (180 / Math.PI));
            double b = 180 - d - e;
            double x = Math.Round((Math.Sin(b * Math.PI / 180) * 3.61) / Math.Sin(d * Math.PI / 180));

            //Salida de datos

            Console.WriteLine("El valor de (X) es >> " + x);

        }
    }
}

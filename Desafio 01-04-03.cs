using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01_04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de datos

            Console.WriteLine("Ingrese el valor de (W) >>");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de (X) >>");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de (D) >>");
            double d = double.Parse(Console.ReadLine());

            //Calculos matematicos

            double t = Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(w, 2) - (2 * x * w * Math.Cos(Math.PI * d / 180))),2);
            double b = Math.Round(Math.Asin((2 * Math.Sin(Math.PI * d / 180)) / t) * (180 / Math.PI),2);
            double e = 180 - d - b;
            double c = 180 - e;
            double y = Math.Round(t * Math.Cos(Math.PI * c / 180),2);

            // Salida de datos

            Console.WriteLine("El valor de (Y) es >> " + y);


        }
    }
}

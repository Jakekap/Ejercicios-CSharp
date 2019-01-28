using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01_04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrse el valor de angulo externo superior >>");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrse el valor del cateto mayor >>");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del cateto menor >>");
            double y = double.Parse(Console.ReadLine());

            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));
            double x = Math.Round(t * Math.Sin(b),2);

            Console.WriteLine("El valor de X es >> " + x);

        }
    }
}

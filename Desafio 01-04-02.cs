using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01_04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el angulo inferior externo del triangulo (d) >>");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el angulo superior externo del triangulo (b) >>");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del cateto inferior interno de triangulo (y) >>");
            double y = double.Parse(Console.ReadLine());

            double e = 180 - d - b;
            double c = 180 - e;
            double z = Math.Round(y * Math.Tan(c * Math.PI / 180),2);

            Console.WriteLine("El valor del otro cateto del triangulo (z) interno es >> " + z);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Ingreso de datos
            Console.WriteLine("Ingrese del valor de cateto menor del triangulo rectangulo >>");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese del valor de cateto mayor del triangulo rectangulo >>");
            double z = double.Parse(Console.ReadLine());

            if (y < z)
            {
                // Operaciones Matematicas
                double t = Math.Round(Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2)), 2);
                double c = Math.Round(Math.Atan(z / y) * (180 / Math.PI), 2);
                double a = Math.Round(Math.Atan(y / z) * (180 / Math.PI), 2);


                // Salida de datos
                Console.WriteLine("La hipotenusa del Triangulo Rectangulo es >> " + t);
                Console.WriteLine("El angulo que forma el cateto menor con la hipotenusa es >> " + c);
                Console.WriteLine("El angulo que forma el cateto mayor con la hipotenusa es >> " + a);
            }
            else
            {
                Console.WriteLine("El cateto menor no puede ser el mayor!");
            }

        }
    }
}

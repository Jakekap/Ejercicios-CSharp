using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_04___2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor elija la entrada de acuerdo a los datos que conoce >>\nEntrada 1: b,z,y | Salida: x \nEntrada 2: d,b,y | Salida: z\nEntrada 3: w,d,x | Salida: y\nEntrada 4: w,t,c | Salida: x");
            int entrada = int.Parse(Console.ReadLine());

            if (entrada == 1)
            {
                Console.WriteLine("Ingrse el angulo (b) >>");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrse el valor de (z) >>");
                double z = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de (y) >>");
                double y = double.Parse(Console.ReadLine());

                double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));
                double x = Math.Round(t * Math.Sin(b));

                Console.WriteLine("El valor de (x) es >> " + x);
            }
            if (entrada == 2)
            {
                Console.WriteLine("Ingrese el angulo (d) >>");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el angulo (b) >>");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de (y) >>");
                double y = double.Parse(Console.ReadLine());

                double e = 180 - d - b;
                double c = 180 - e;
                double z = Math.Round(y * Math.Tan(c * Math.PI / 180), 2);

                Console.WriteLine("El valor de (z) es >> " + z);
            }
            if(entrada == 3)
            {
                // Entrada de datos

                Console.WriteLine("Ingrese el valor de (w) >>");
                double w = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de (x) >>");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el angulo (d) >>");
                double d = double.Parse(Console.ReadLine());

                //Calculos matematicos

                double t = Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(w, 2) - (2 * x * w * Math.Cos(Math.PI * d / 180))), 2);
                double b = Math.Round(Math.Asin((2 * Math.Sin(Math.PI * d / 180)) / t) * (180 / Math.PI), 2);
                double e = 180 - d - b;
                double c = 180 - e;
                double y = Math.Round(t * Math.Cos(Math.PI * c / 180), 2);

                // Salida de datos

                Console.WriteLine("El valor de (y) es >> " + y);
            }
            if(entrada == 4)
            {
                //Entrada de datos

                Console.WriteLine("Inserte el valor de (w) >>");
                double w = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserte el valor de (t) >>");
                double t = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserte el angulo (c) >>");
                double c = double.Parse(Console.ReadLine());

                //Calculo matematico

                double e = 180 - c;
                double d = Math.Round(Math.Asin(t * (Math.Sin(Math.PI * e / 180)) / 5) * (180 / Math.PI));
                double b = 180 - d - e;
                double x = Math.Round((Math.Sin(b * Math.PI / 180) * 3.61) / Math.Sin(d * Math.PI / 180));

                //Salida de datos

                Console.WriteLine("El valor de (x) es >> " + x);
                
            }
            else if(entrada != 1 & entrada != 2 & entrada != 3 & entrada != 4)
            {
                Console.WriteLine("La Entrada " + entrada + " no es valida");
            }
            
                
            
        }
    }
}

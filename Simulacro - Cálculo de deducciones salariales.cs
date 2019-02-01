using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de su salario mensual >>  ");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Elija su tipo de contrato:\n1. Dependiente\n2. Independiente");
            int contrato = int.Parse(Console.ReadLine());
            double prima = sal;
            double sald = sal;
            sal *= 0.4;

            if (sal < 828116)
            {
                sal = 828116;
            }

            if (contrato == 1)
            {
                double pension = sal * 0.04;
                double eps = pension;
                double alr = 0;
                double deduccion = pension + eps + alr;
                double anual = prima * 13;
                sald = sald - deduccion;
                Console.WriteLine("Su salario real mensual es: " + sald);
                Console.WriteLine("Su anual es: " + anual);

            }
            if (contrato == 2)
            {
                Console.WriteLine("Ingrese un numero del 1 al 5 equivalente a la clase de riesgo");
                int riesgo = int.Parse(Console.ReadLine());
                double arl = 0;
                double deduccion;
                if (riesgo == 1)
                {
                    arl = sal * 0.00522;
                }
                else if (riesgo == 2)
                {
                    arl = sal * 0.01044;
                }
                else if (riesgo == 3)
                {
                    arl = sal * 0.02436;
                }
                else if (riesgo == 4)
                {
                    arl = sal * 0.04350;
                }
                else if (riesgo == 5)
                {
                    arl = sal * 0.06960;
                }
                //Deduccion
                double pension = sal * 0.16;
                double eps = sal * 0.125;
                deduccion = pension + eps + arl;
                double anual = prima * 12;
                sald = sald - deduccion;
                

                Console.WriteLine("Su salario real mensual es: " + sald);
                Console.WriteLine("Su anual es: " + anual);
            } 
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int n1=0, n2=0, n3=0, solucion =1, n4=0,vidas=3;
            
            while (n4 != solucion)
            {
                if (vidas == 0) break;
                n1 = aleatorio.Next(1, 99);
                n2 = aleatorio.Next(1, 99);
                n3 = aleatorio.Next(1, 99);
                solucion = n1 + n2 + n3;
                Console.WriteLine("Ingrese el resultado de la suma>> ");
                Console.Write(n1 + " + " + n2 + " + " + n3 + " = ");
                n4 = int.Parse(Console.ReadLine());
                if(n4 != solucion) Console.WriteLine("Respuesta Incorrecta!");
                vidas -= 1;
            }
            if(vidas != 0)Console.WriteLine("Correcto!");
        }
    }
}

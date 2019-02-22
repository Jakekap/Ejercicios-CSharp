using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Azar_Pro_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, uno = 0, vidas = 3, dadoAnterior = 0;

            while (true)
            {
                dado = aleatorio.Next(1, 7);
                Console.WriteLine("Dado: " + dado);
                total += dado;
                if (dado == 1)
                {
                    uno += 1;
                    if (uno > 1)
                    {
                        vidas -= 1;
                        uno = 0;
                        total -= 10;
                        Console.WriteLine("-1 Vida D: : Vidas: " + vidas);
                        if (vidas == 0) break;
                    }
                }
                if (dado == 6 && dadoAnterior == dado && vidas < 3){
                    vidas += 1;
                    Console.WriteLine("+1 Vida! : Vidas:" + vidas);
                }

                Console.WriteLine("TOTAL: " + total);
                Console.WriteLine("Tirar de nuevo? (y/n) ");
                if (Console.ReadLine() != "y") break;
                dadoAnterior = dado;
            }
            Console.WriteLine("Su total fue de: " + total);
        }
    }
}


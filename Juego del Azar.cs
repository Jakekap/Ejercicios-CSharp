using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_del_Azar
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0, contador = 0, tiradas=0, dobles=0;
            double media = 0;
            string continuar = "y";
            while (continuar == "y" && (dado1 + dado2 != 2) ){
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                Console.WriteLine("Dados :" + dado1 + " : " + dado2);
                tiradas += 1;
                if (dado1 == 1 && dado2 == 1){
                    total = 0;
                    Console.WriteLine("Eliminado!");  
                }
                else{
                    total += dado1 + dado2;
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("Desea continiar? (y/n): ");
                    continuar = Console.ReadLine();  
                }
                if (dado1 + dado2 >= 6){
                    contador += 1; 
                }
                if (dado1 == dado2){
                    dobles += 1;
                    if (dobles == 3){
                        continuar = "n";
                        Console.WriteLine("Ganaste, sacaste 3 pares seguidos!!!");
                    }
                }
                else dobles = 0;
                
                if(total >= 100){
                    Console.WriteLine("Ganaste!");
                    continuar = "n";
                }
               }
            media = ((double)(contador) / tiradas) * 100;
            Console.WriteLine("Su total fue: " + total + " puntos");
            Console.WriteLine("Su porcentaje de tiradas mayores a 6 es del: " + Math.Round(media, 2) + "%");
        }
    }
}

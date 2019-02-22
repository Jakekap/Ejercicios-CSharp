using System;

namespace Juego_Azar_Pro
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, cont = 0, casi = 0;
            string continuar = "y";
            while ((continuar == "y" && (dado % 2 == 0)) || (cont <= 3 && continuar == "y"))
            {
                dado = aleatorio.Next(1, 13);
                Console.WriteLine("Dado: " + dado);
                total += dado;
                cont += 1;
                if (total >= 100)
                {
                    Console.WriteLine("Ganaste!");
                    continuar = "n";

                }
                if (casi == 10 && dado == 12)
                {
                    Console.WriteLine("Ganaste!");
                    continuar = "n";
                    casi = 60;
                }

                if (dado % 2 != 0 && cont > 3)
                {
                    Console.WriteLine("Eliminado!\nPerdiste todos tus puntos! :(");
                    total = 0;
                }
                else if(total < 100 && casi != 60) {

                    Console.WriteLine("TOTAL: " + total);
                    Console.WriteLine("Tirar de nuevo? (y/n) ");
                    continuar = Console.ReadLine();
                }

                casi = dado;
            }
            Console.WriteLine("Su total fue de: " + total);
        }
    }
}

using System;

namespace Juego_de_Azar_Simulacro_P2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0, contador = 0, turno = 0, vidas = 3;
            while (true)
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                turno++;
                contador++;
                if (turno == 3)
                {
                    Console.WriteLine("Dado 1: " + dado1 + "Dado 2: " + dado2);
                    total += dado1 + dado2;
                }
                else
                {
                    total += dado1;
                    Console.WriteLine("Dado: " + dado1);
                }
                if (contador == 2) { 
                    vidas--;
                    Console.WriteLine("-1 Vidas! : Vidas:" + vidas);
                    contador = 0;
                }
                if (turno == 3 && dado1 == dado2)
                {
                    vidas += 1;
                    Console.WriteLine("+1 Vidas! : Vidas:" + vidas);
                }
                if(vidas == 0){
                    Console.WriteLine("Perdiste!");
                    break;
                }

                Console.WriteLine("TOTAL: " + total);
                Console.WriteLine("Tirar de nuevo? (y/n) ");
                if (Console.ReadLine() != "y") break;
            }
            Console.WriteLine("Su total fue de: " + total);
        }
    }
}

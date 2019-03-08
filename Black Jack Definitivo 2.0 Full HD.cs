using System;

namespace BlackJack_Modificado
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1, carta2, total = 0, n = 0, jugador = 1, i = 0; 
            string letra = "";
            string[] especiales = { "K", "Q", "J","A"};
            Console.WriteLine("Ingrese el numero de jugadores: ");
            n = int.Parse(Console.ReadLine());
            int[] puestos = new int[n+1];
            while (jugador <= n) 
            {
                total = 0;
                Console.WriteLine("Bienvenido jugador: " + jugador);
                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                total = carta1 + carta2;
                Console.WriteLine("Sacaste: " + carta1 + " - " + carta2 + "\nTotal: " + total);
                while(true)
                {
                    Console.WriteLine("Desea otra carta? (y/n): ");
                    if (Console.ReadLine() == "y")
                    {
                        carta1 = aleatorio.Next(1, 15);
                        if (carta1 >= 12)
                        {
                            if (carta1 == 12) letra = especiales[0];
                            if (carta1 == 13) letra = especiales[1];
                            if (carta1 == 14) letra = especiales[2];
                            carta1 = 10;
                        }
                        if (carta1 == 11)
                        {
                            Console.Write("Sacaste A, que valor desea para el Ace? ");
                            carta1 = int.Parse(Console.ReadLine());
                        }
                        total += carta1;
                        if (carta1 > 11) Console.WriteLine("Sacaste: " + letra + "\nTota: " + total);
                        else Console.WriteLine("Sacaste: " + carta1 + "\nTotal: " + total);

                        if (total > 21){
                            Console.WriteLine("\nPerdiste!\n\n");
                            break;
                        }
                        if (total == 21){
                            Console.WriteLine("\nBlack Jack!\n\n");
                            break;
                        }
                    }
                    else break;
                }
                puestos[jugador] = total;
                jugador++;

            }
            for (i = 1; i < n+1; i++)
            {
                if (puestos[i] > 21) Console.WriteLine("El jugador " + i + " perdio!");
                if (puestos[i] == 21) Console.WriteLine("El jugador " + i + " gano por Black Jack!");
                if (puestos[i] < 21) Console.WriteLine("El jugador " + i + " se retiró con " + puestos[i]);
            }
        }
    }
}

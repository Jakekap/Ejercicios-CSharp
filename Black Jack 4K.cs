using System;

namespace BlackJack_Modificado
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1, carta2, total = 0, n = 0, jugador = 0, contador = 0;
            string letra = "";
            string[] especiales = { "K", "Q", "J", "A" };
            Console.WriteLine("Ingrese el numero de jugadores: ");
            n = int.Parse(Console.ReadLine());
            string[] players = new string[n];
            string[] tempplayers = new string[n];
            int[] puestos = new int[n];
            int[] temppuntaje = new int[n];
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Ingrese el nombre del jugador: ");
                players[i] = Console.ReadLine();
            }
            for(int i=0; i<n; i++)
            {
                total = 0;
                Console.WriteLine("Bienvenido jugador: " + players[i]);
                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                total = carta1 + carta2;
                Console.WriteLine("Sacaste: " + carta1 + " - " + carta2 + "\nTotal: " + total);
                while (true)
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
                            contador = 10;
                        }
                        if (carta1 == 11)
                        {
                            Console.Write("Sacaste A, que valor desea para el Ace? ");
                            carta1 = int.Parse(Console.ReadLine());
                        }
                        total += carta1;
                        if (contador == 10)
                        {
                            Console.WriteLine("Sacaste: " + letra + "\nTota: " + total);
                            contador = 0;
                        }
                        else Console.WriteLine("Sacaste: " + carta1 + "\nTotal: " + total);

                        if (total > 21)
                        {
                            Console.WriteLine("\nPerdiste!\n\n");
                            total = 0;
                            break;
                        }
                        if (total == 21)
                        {
                            Console.WriteLine("\nBlack Jack!\n\n");
                            break;
                        }
                    }
                    else break;
                }
                puestos[i] = total;
                jugador++;
            }

            for (int j = 0; j < n -1; j++)
            {
                for (int i = 0; i < n -1; i++)
                {
                    if (puestos[i] < puestos[i + 1])
                    {

                        temppuntaje[i] = puestos[i];
                        puestos[i] = puestos[i + 1];
                        puestos[i + 1] = temppuntaje[i];

                        tempplayers[i] = players[i];
                        players[i] = players[i + 1];
                        players[i + 1] = tempplayers[i];
                    }

                }
            }


            Console.WriteLine("Ordenados");
            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine(players[i] + puestos[i]);
            }
        }
    }
}
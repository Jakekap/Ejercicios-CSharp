using System;

namespace Black_Jack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            string  letra="K", nuev="Y";

            while (nuev == "Y")
            {
                int carta1 = 0, carta2 = 0, total = 0;
                string continuar = "Y";

                carta1 = random.Next(1, 11);
                carta2 = random.Next(1, 11);
                total = carta1 + carta2;
                Console.Write("Sacaste > " + carta1 + " - " + carta2 + "\tTOTAL: " + total);
                while (total < 21 && continuar == "Y")
                {
                    Console.WriteLine("\nDesea otra carta? (Y/N) ");
                    continuar = Console.ReadLine();
                    if (continuar == "Y" || continuar=="y")
                    {
                        carta1 = random.Next(1, 15);
                        if (carta1 == 12)
                        {
                            letra = "J";
                            carta1 = 10;
                        }
                        if (carta1 == 13)
                        {
                            letra = "Q";
                            carta1 = 10;
                        }
                        if (carta1 == 14)
                        {
                            letra = "K";
                            carta1 = 10;
                        }
                        if (carta1 == 11)
                        {
                            Console.WriteLine("Sacaste (A)\tQue valor desea para el Ace?" + "\tTOTAL: " + total);
                            carta1 = int.Parse(Console.ReadLine());
                        }
                        total += carta1;

                        if (carta1 > 11) { Console.WriteLine("Sacaste > " + letra + "\tTOTAL: " + total); }
                        else Console.WriteLine("Sacaste > " + carta1 + "\tTOTAL: " + total);


                        if (total > 21) Console.WriteLine("Perdiste!");
                        else if (total == 21) Console.WriteLine("Black Jack!");

                    }
                    if (continuar == "N")
                    {
                        Console.WriteLine("Fin del Juego!\nTOTAL: " + total);

                       
                    }

             
                   }
                if(total >= 21 || continuar == "N") {
                    Console.WriteLine("Jugar de nuevo? (Y/N) ");
                    nuev = Console.ReadLine();

                }

            }

            }
        
        }
    }


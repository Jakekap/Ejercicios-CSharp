using System;

namespace Desafio01_Operadores_y_Elecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            double porMayor;
            int vPartido1, vPartido2, vBlancos, vAnulados, poblacion, vTotal, dif, votantes;

            Console.WriteLine("Ingrese los votos del Patido 1 >> ");
            vPartido1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los votos del Patido 2 >> ");
            vPartido2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los votos en blanco >> ");
            vBlancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los votos anulados >> ");
            vAnulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la poblacion total >> ");
            poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de mayores de edad >> ");
            porMayor = double.Parse(Console.ReadLine());


            vTotal = vPartido1 + vPartido2 + vBlancos + vAnulados;
            dif = Math.Abs(vPartido1 - vPartido2);
            votantes = (int)(poblacion * porMayor / 100);
            if ((vTotal > votantes || (dif < vTotal * 0.1)) && (votantes < poblacion * 0.3)) Console.WriteLine("La votacion debe ejecutarse de nuevo");
            else if (vPartido1 > vPartido2)
            {
                Console.WriteLine("El ganador es A");
                Console.WriteLine("Votos A: " + vPartido1 + "\nVotos B: " + vPartido2 + "\nVotos Blancos: " + vBlancos + "\nVotos Nulos: " + vAnulados + "\nPoblacion Total: " + poblacion + "\nMayores de edad: " + porMayor + "%");
            }
            else if (vPartido1 < vPartido2)
            {
                Console.WriteLine("El ganador es B");
                Console.WriteLine("Votos A: " + vPartido1 + "\nVotos B: " + vPartido2 + "\nVotos Blancos: " + vBlancos + "\nVotos Nulos: " + vAnulados + "\nPoblacion Total: " + poblacion + "\nMayores de edad: " + porMayor + "%");
            }
        }
    }
}

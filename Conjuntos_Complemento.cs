using System;

namespace Conjuntos_Complemento
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int k, i, j;
            Console.WriteLine("Ingrese el tamaño del Universo: ");
            int n = int.Parse(Console.ReadLine());
            int[] U = new int[n];
            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];

            Console.WriteLine("Ingrese los valores del conjunto A(Presione n para terminar): ");
            for (k = 0; k < n; k++)
            {

                A[k] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese los valores del conjunto B(Presione n para terminar): ");
            for (k = 0; k < n; k++)
            {

                B[k] = int.Parse(Console.ReadLine());
            }
            for(i=0; i < n; i++)
            {
                U[i] = i+1;
            }
            for (j = 0; j < n; j++) // Cada elemento del conjunto A se compara con el Universo, si hay repetidos se pone -1.

            {
                for (i = 0; i < n; i++) 
                {
                    if (U[j] == A[i] || U[j] == B[i])
                    {
                        U[j] = -1;
                    }
                }

            }
            for (k = 0; k < n; k++)
            {
                if (U[k] != -1) Console.WriteLine(">> " + U[k]);  //Se imprimen unicamente los que son diferentes a -1.
            }
        }
    }
}

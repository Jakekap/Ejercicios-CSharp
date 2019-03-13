using System;

namespace Conjuntos_Interseccion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int k, i, j, v = 0, temp;
            Console.WriteLine("Ingrese el tamaño del Universo: ");
            int n = int.Parse(Console.ReadLine());
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
            for (j = 0; j < n; j++) // Cada elemento del conjunto A se compara con cada elemto del conjunto B, si hay repetidos se copian en C.

            {
                for (i = 0; i < n; i++) //A 1 1 2 2    B -1 -1 -1 -1   C 1 2 2 2
                {
                    if (A[j] == B[i])
                    {
                        C[v++] = A[j];
                        B[i] = -1; // Para evitar que se salga de los limites del arreglo, se remplaza B[] por un -1, para evitar copiarlo mas de una vez.
                    }
                }

            }
            for (i = 0; i < n; i++)       // Los elementos repetidos de C se convierten en -1
            {
                temp = C[i];
                for (j = i + 1; j < n ; j++)
                {
                    if (temp == C[j])
                    {
                        C[j] = -1;
                    }
                }
            }
            for (k = 0; k < n; k++)
            {
                if (C[k] != -1) Console.WriteLine(">> " + C[k]);  //Se imprimen unicamente los que son diferentes a -1
            }
        }
    }
}

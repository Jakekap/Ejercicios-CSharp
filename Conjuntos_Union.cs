using System;

namespace Conjuntos_Union
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int k,i,j,v=0,temp;
            Console.WriteLine("Ingrese el tamaño del Universo: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n*2]; //El arreglo del conjunto C es el doble que el del universo, en caso de que todos los numeros sean diferentes.

            Console.WriteLine("Ingrese los valores del conjunto A(Presione n para terminar): "); // Ingreso de datos del conjunto.
            for (k = 0; k < n; k++)
            {

                    A[k] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Ingrese los valores del conjunto B(Presione n para terminar): "); // Ingreso de datos del conjunto.
            for (k = 0; k < n; k++)
            {

                B[k] = int.Parse(Console.ReadLine());
            }

            for (j = 0; j< n; j++) // Cada elemento del conjunto A se compara con cada elemto del conjunto B, si hay repetidos se cambia por un -1
                                    
            {
                for (i = 0; i < n; i++)
                {
                    if (A[j] == B[i])
                    {
                        B[i] = -1;
                    }
                }
                C[v++] = A[j];

            }
            for (i = 0; i < n; i++)     // al final el programa copia los elementos de B diferentes a -1, en C.
            {
                if(B[i]!= -1)
                {
                    C[v++] = B[i];
                }
            }
                for (i = 0; i < 2*n; i++)       // Los elementos repetidos de C se convierten en -1
                {
                    temp = C[i];
                    for (j = i + 1; j < 2*n; j++)
                    {
                        if (temp == C[j])
                        {
                            C[j] = -1;
                        }
                    }
                }
                for (k = 0; k < (n*2); k++) 
            {
                if (C[k] != -1) Console.WriteLine(">> "+C[k]);  //Se imprimen unicamente los que son diferentes a -1
            }
        }
    }
}
﻿using System;

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
            int[] C = new int[n*2];

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

            for (j = 0; j< n; j++)
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
            for (i = 0; i < n; i++)
            {
                if(B[i]!= -1)
                {
                    C[v++] = B[i];
                }
            }
                for (i = 0; i < 2*n; i++)
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
                if (C[k] != -1) Console.WriteLine(">> "+C[k]);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Matrices
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			string[] valores = { "-", "-", "O", "X" };
			int n = 10;
			int m = 15;
			int contadorx = 0, contadoro = 0, contador_ =0,total,porx, poro, por_;

			string[,] tablero = new string[n, m];
			string[,] salida = new string[n, m];
			for (int i = 0; i < tablero.GetLength(0); i++)
			{
				for (int j = 0; j < tablero.GetLength(1); j++)
				{
					int indice = random.Next(0, valores.Length);
					tablero[i, j] = valores[indice];
					salida[i, j] = "-";
				}
			}
			Console.WriteLine("ENTRADA: ");
			for (int i = 0; i < tablero.GetLength(0); i++)
			{
				for (int j = 0; j < tablero.GetLength(1); j++)
				{
					Console.Write("|" + tablero[i, j]);
				}
				Console.Write("|\n");
			}

			for(int i = 0; i < tablero.GetLength(0); i++)
			{
				for(int j = 0; j < tablero.GetLength(1)-2; j++)
				{
					if((tablero[i,j] == tablero[i, j+1] && tablero[i, j] == tablero[i, j + 2]) && tablero[i,j] == "X")
					{
						salida[i, j] = "1";
						salida[i, j+1] = "1";
						salida[i, j+2] = "1";
						
					}
				}
			}
			for (int i = 0; i < tablero.GetLength(0)-2; i++)
			{
				for (int j = 0; j < tablero.GetLength(1); j++)
				{
					if ((tablero[i, j] == tablero[i+1, j] && tablero[i, j] == tablero[i+2, j]) && tablero[i, j] == "X")
					{
						salida[i, j] = "1";
						salida[i+1, j] = "1";
						salida[i+2, j] = "1";
						
					}
				}
			}
			for (int i = 0; i < tablero.GetLength(0); i++)
			{
				for (int j = 0; j < tablero.GetLength(1) - 2; j++)
				{
					if ((tablero[i, j] == tablero[i, j + 1] && tablero[i, j] == tablero[i, j + 2]) && tablero[i, j] == "O")
					{
						salida[i, j] = "2";
						salida[i, j + 1] = "2";
						salida[i, j + 2] = "2";
					}
				}
			}
			for (int i = 0; i < tablero.GetLength(0) - 2; i++)
			{
				for (int j = 0; j < tablero.GetLength(1); j++)
				{
					if ((tablero[i, j] == tablero[i + 1, j] && tablero[i, j] == tablero[i + 2, j]) && tablero[i, j] == "O")
					{
						salida[i, j] = "2";
						salida[i + 1, j] = "2";
						salida[i + 2, j] = "2";
					}
				}
			}
			for (int i = 0; i < tablero.GetLength(0); i++)
			{
				for (int j = 0; j < tablero.GetLength(1); j++)
				{
					if(tablero[i,j] == "X")
					{
						contadorx++;
					}
					if (tablero[i, j] == "O")
					{
						contadoro++;
					}
					if(tablero[i,j] == "-")
					{
						contador_++;
					}
				}
				
			}
			total = contador_ + contadoro + contadorx;
			porx = contadorx * 100 / total;
			poro = contadoro * 100 / total;
			por_ = contador_ * 100 / total;

			Console.WriteLine("\nSALIDA: ");
			for (int i = 0; i < tablero.GetLength(0); i++)
			{
				for (int j = 0; j < tablero.GetLength(1); j++)
				{
					Console.Write("|" + salida[i, j]);
				}
				Console.Write("|\n");
			}
			Console.Write("\n");
		}
	}
}

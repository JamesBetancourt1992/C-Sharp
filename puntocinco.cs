//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;

namespace Punto5
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double edad, suma, promedio, k, n;
			Console.WriteLine("        PROMEDIO DE EDADES       ");
			Console.Write("Ingrese el numero de personas:");
			n = double.Parse(Console.ReadLine());
			Console.Write("Ingresa edades");
			suma = 0;
			for (k = 1; k <= n; k = k + 1)
			{
				Console.Write("Persona___" + k + ": ");
				edad  = double.Parse(Console.ReadLine());
				suma = suma + edad;
			}
			promedio = suma / n;
			Console.WriteLine("El promedio de Edades es:" + promedio);
			Console.WriteLine("Enter para Salir . . . ");
			Console.ReadLine();

		}
	}
}

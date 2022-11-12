//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
	class Program
	{
		private static int a;
		private static int az;

		public static int Op { get; private set; }

		static void Main(string[] args)
		{
			do
			{
				int op;
				Console.WriteLine("Seleccione una Operacion");
				Console.WriteLine("1 Ejercicio No. Escribir un programa que presente todos los números primos entre 2 y 100.");
				Console.WriteLine("2 Ejercicio No. Programa que realice las operaciones aritméticas de sumar, restar y multiplicar con 3 datos digitados por el usuario.");
				Console.WriteLine("3 Ejercicio No. Programa que realice el cambio monetario entre pesos colombianos, dólares y euros.");
				Console.WriteLine("4 Programa que solicite un número entre 1 y 7, e informe el día de la semana al que corresponde.");
				Console.WriteLine("5 Programa que calcule el promedio de edad de un grupo de personas, e indique cuál es la edad mayor y cuál es la edad menor.");
				Console.WriteLine("6 Salir");
				op = int.Parse(Console.ReadLine());
				switch (op)
				{
					case 1:
						
						CONTENIDO PUNTO UNO

						break;

					case 2: 
						
						CONTENIDO PUNTO DOS

						break;

					case 3:

						CONTENIDO PUNTO TRES

						break;

					case 4:

						CONTENIDO PUNTO CUATRO

						break;

					case 5:
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
								edad = double.Parse(Console.ReadLine());
								suma = suma + edad;
							}
							promedio = suma / n;
							Console.WriteLine("El promedio de Edades es:" + promedio);
						}
						break;

					case 6:
                        Console.WriteLine("salir");
						Console.ReadKey();
						Environment.Exit(0);
						break;
				}

			} while (Op > 0 || Op < 7);

		}
	}
}


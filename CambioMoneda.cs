//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Tipo de moneda: 1 = peso, 2 = dolar y 3 euro");
			Console.WriteLine("Por favor ingrese el tipo de moneda");
			string str = Console.ReadLine();
			Console.WriteLine("Por favor ingrese el valor a cambiar");
			int x = int.Parse(Console.ReadLine());
			double y = 0;
			double z = 0;
			double n = 0;
			double c = 0.00036;
			double d = 0.000316;
			const double a = 0.94;
			const double b = 1.06;
			switch (str)
			{
				case "1":
					y = x * c;
					z = x * d;
					Console.WriteLine("Su valor en Dolares es {0}", y);
					Console.WriteLine("Su valor en  Euros es {0}", z);
					break;
				case "2":
					n = x * 2976;
					z = x * a;
					Console.WriteLine("Su valor en Pesos es {0}", n);
					Console.WriteLine("Su valor en  Euros es {0}", z);
					break;
				case "3":
					n = x * 3161;
					z = x * b;
					Console.WriteLine("Su valor en Pesos es {0}", n);
					Console.WriteLine("Su valor en Dolares es {0}", z);
					break;
				default:
					Console.WriteLine("Valor erroneo");
					break;
			}
			Console.WriteLine("Gracias usar nuestro programa");
			Console.ReadKey();
		}
	}
}
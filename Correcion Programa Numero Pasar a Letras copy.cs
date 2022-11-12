//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace programa 
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] unidades =
			{"cero", "uno", "dos" ,"tres" ,"cuatro" ,"cinco" ,
				"seis" ,"siete" ,"ocho" ,"nueve","diez"};
			string[] especiales =
			{"once", "doce","trece","catorce", "quince",
				"diezciseis", "diecisiete", "dieciocho", "diecinueve"};
			string[] decenas =
			{"veinte", "treinta","cuarenta","cincuenta",
				"sesenta", "setenta", "ochenta", "noventa"};

			Console.WriteLine("Ingrese un numero que este 0=>99, no toma valores mayores de 99: ");
			int num = Convert.ToInt32(Console.ReadLine());

			if (num >= 0 && num < 11)
				Console.WriteLine('\n' + unidades[num]);
			else if (num < 20)
				Console.WriteLine('\n' + especiales[num - 11]);
			else if (num < 100)
			{
				int unid = num % 10;
				int dec = num / 10;
				if (unid == 0)
					Console.WriteLine('\n' + decenas[dec - 2]);
				else
					Console.WriteLine('\n' + decenas[dec - 2] + " y " + unidades[unid]);
			}
			else
				Console.WriteLine("El numero debe ser menor a 100");

			Console.ReadLine();

		}
	}
}
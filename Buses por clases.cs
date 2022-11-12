//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_de__buses
{
	class Program

	{
		static void Main(string[] args)
		{
			Console.WriteLine("SELECCIONE  EL TIPO  DE  EMPRESA  A VIAJAR");
			Console.WriteLine("1. Empresa  A  valor km 1000");
			Console.WriteLine("2. Empresa  B valor km 2000");
			Console.WriteLine("3. Empresa  C  valor km 3000");
			Console.WriteLine("4. Salir");
			int a = Convert.ToInt32(Console.ReadLine());
			if (a > 0) { }
			switch (a)
			{
				case 1:
					int f = 0;
					int h;
					Console.WriteLine("digite cantidad personas");
					int c = Convert.ToInt32(Console.ReadLine());
					for (int i = 0; i <= c; i++)
					{
						Console.WriteLine("digite el kilometraje");
						int b = int.Parse(Console.ReadLine());

						f = f + b;
						h = 1000;

						bus1 bus;
						bus = new bus1();
						int v;

						v = bus.calcular(f, h);
						Console.WriteLine("valor recaudado por kilometro {0} ", +v);
						Console.WriteLine("promedio  total personas {0} ", f / c);

					}


					break;

				case 2:
					f = 0;
					Console.WriteLine("digite cantidad personas");
					int p = Convert.ToInt32(Console.ReadLine());
					for (int i = 0; i <= p; i++)
					{
						Console.WriteLine("digite el kilometraje");
						int b = Convert.ToInt32(Console.ReadLine());

						f = f + b;
						h = 2000;

						bus1 bus;
						bus = new bus1();
						int v;

						v = bus.calcular(f, h);
						Console.WriteLine("valor recaudado por kilometro : " + v);

					}
					break;

				case 3:
					f = 0;
					Console.WriteLine("digite cantidad personas");
					int G = Convert.ToInt32(Console.ReadLine());
					for (int i = 0; i <= G; i++)
					{
						Console.WriteLine("digite el kilometraje");
						int b = Convert.ToInt32(Console.ReadLine());

						f = f + b;
						h = 3000;

						bus1 bus;
						bus = new bus1();
						int v;

						v = bus.calcular(f, h);
						Console.WriteLine("valor recaudado por kilometro : " + v);

					}
					break;
				case 4:

					Console.WriteLine("salir ");
					Console.ReadKey();
					break;


			}
		}
	}
}
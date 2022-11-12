//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Convertira_a_Romano
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Unidad = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            String[] Decena = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            String[] Centena = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            Console.WriteLine("Ingresa numero entre 1 y 999");
            int N = Convert.ToInt32(Console.ReadLine());
            int u = N % 10;
            int d = (N / 10) % 10;
            int c = N / 100;
            if (N >= 100)
            {
                Console.WriteLine(Centena[c] + Decena[d] + Unidad[u]);
            }
            else
            {
                if (N >= 10)
                {
                    Console.WriteLine(Decena[d] + Unidad[u]);
                }
                else
                {
                    Console.WriteLine(Unidad[N]);
                }
            }
            Console.ReadLine();
        }
    }
}
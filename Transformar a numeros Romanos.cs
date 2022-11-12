//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace codigoBlog
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] unidades =
            {"cero", "I", "II" ,"III" ,"IV" ,"V" ,
                "VI" ,"VII" ,"VIII" ,"IX","X"};
            string[] especiales =
            {"XI", "XII","XIII","XIV", "XV",
                "XVI", "XVII", "XVIII", "XIX"};
            string[] decenas =
            {"XX", "XXX","XL","L",
                "LX", "LXX", "LXXX", "XC"};


            Console.WriteLine("***Harol Alexander Vargas Baquero ");
            Console.WriteLine("****cod 1030616813****** ");
            Console.WriteLine("***Introduccion a la programacion*** ");
            Console.WriteLine('\n' + "Ingrese un numero entre 0-99: ");
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
                    Console.WriteLine('\n' + decenas[dec - 2]  + unidades[unid]);
            }
            else
                Console.WriteLine("El numero debe ser menor a 100");

            Console.ReadLine();

        }
    }
}
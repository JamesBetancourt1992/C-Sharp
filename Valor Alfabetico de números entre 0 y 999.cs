//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program

    {
        static void Main(string[] args)
        {

            
            int num, a, ax, b, bx, uni;
            string u = "", d = "", c = "";            
            Console.WriteLine("Cordial saludo");
            Console.WriteLine("Programa par saber el valor alfabetico de un Número");
            inicio:
            Console.WriteLine("Por Favor Digite un Número entre 0 y 999");
            num = int.Parse(Console.ReadLine());           
            if ((num >= 0) && (num <= 099))
            { 
                a = num / 100;
            ax = num % 100;
            b = ax / 10;
            bx = ax % 10;
            uni = bx;
            switch (uni)
            {
                case 1: u = "Uno"; break;
                case 2: u = "Dos"; break;
                case 3: u = "Tres"; break;
                case 4: u = "Cuatro"; break;
                case 5: u = "Cinco"; break;
                case 6: u = "Seis"; break;
                case 7: u = "Siete"; break;
                case 8: u = "Ocho"; break;
                case 9: u = "Nueve"; break;
            }
            switch (b)
            {
                case 1:
                    switch (uni)
                    {
                        case 0: u = "Diez"; break;
                        case 1: u = "Once"; break;
                        case 2: u = "Doce"; break;
                        case 3: u = "Trece"; break;
                        case 4: u = "Catorce"; break;
                        case 5: u = "Quince"; break;
                        default: u = "Dieci" + u; break;
                    }
                    break;
            }
            switch (b)
            {
                case 2: if (uni == 0) d = "Veinte"; else d = "Veinti "; break;
                case 3: if (uni == 0) d = "Treinta"; else d = "Treinta y "; break;
                case 4: if (uni == 0) d = "Cuarenta"; else d = "Cuarenta y "; break;
                case 5: if (uni == 0) d = "Cincuenta"; else d = "Cincuenta y "; break;
                case 6: if (uni == 0) d = "Sesenta"; else d = "Sesenta y "; break;
                case 7: if (uni == 0) d = "Setenta"; else d = "Setenta y "; break;
                case 8: if (uni == 0) d = "Ochenta"; else d = "Ochenta y "; break;
                case 9: if (uni == 0) d = "Noventa"; else d = "Noventa y "; break;
            }
            switch (a)
            {
                case 1: if (uni == 0) c = "Cien"; else c = "Ciento";
                    break;
                case 2: c = "Docientos"; break;
                case 3: c = "Trecientos"; break;
                case 4: c = "Cuatrocientos"; break;
                case 5: c = "Quinientos"; break;
                case 6: c = "Seiscientos"; break;
                case 7: c = "Setecientos"; break;
                case 8: c = "Ochosientos"; break;
                case 9: c = "Novecientos"; break;
            }
            Console.WriteLine("El Equivalente Alfabetico es: {0}", c + d + u);
            Console.WriteLine("Gracias por su Atención");
            Console.ReadLine();
                Environment.Exit(0); }
            else Console.WriteLine("Valor equivocado");
            goto inicio;
            
        }
    }
}

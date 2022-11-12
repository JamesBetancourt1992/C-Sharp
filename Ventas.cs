//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPrincipal
{
    class Ventas
    {

        static double[] vendedor = new double[2];
        static double ventas = 0;
        public static void productos()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            int op = 1;

            while (op != 0)
            {
                Console.Clear();

                int numV = 0;

                double producTotal = 0;
                double[] producInd = new double[5] { 0, 0, 0, 0, 0 };

                double venTotal = 0;
                double[] venInd = new double[5] { 0, 0, 0, 0, 0 };

                double[,] masVen = new double[1, 2] { { 1, 1 } };
                double[,] menosVen = new double[1, 2] { { 1, 1 } };



                Console.WriteLine("Escriba el numero de vendedores");
                numV = int.Parse(Console.ReadLine());

                double[,] vend = new double[numV, 5];

                double[,] vendMasVentas = new double[numV, 2];


                for (int i = 0; i < numV; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        vendMasVentas[i, j] = 0;
                    }
                }

                
                for (int i = 0; i < numV; i++)
                {
                    Console.Clear();

                    Console.Write(Environment.NewLine + "Vendedor #" + (i + 1) + Environment.NewLine);

                    for (int j = 0; j < 5; j++)
                    {


                        tipoProduc(j);
                        
                        vend[i, j] = double.Parse(Console.ReadLine());


                        if (j == 0) { venInd[0] += 1000 * vend[i, j]; }
                        if (j == 1) { venInd[1] += 2345 * vend[i, j]; }
                        if (j == 2) { venInd[2] += 3876 * vend[i, j]; }
                        if (j == 3) { venInd[3] += 1235 * vend[i, j]; }
                        if (j == 4) { venInd[4] += 550 * vend[i, j]; }
                        venConMasVentas(j, vend[i, j]);
                    }

                    venta(i);

                }

                Console.Clear();

                //--------------------------

                for (int i = 0; i < numV; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {


                        producTotal += vend[i, j];
                        producInd[j] += vend[i, j];

                    }

                }
        
                for (int i = 0; i < 5; i++)
                {
                    if (i == 0) { masVen[0, 0] = menosVen[0, 0] = producInd[0]; masVen[0, 1] = menosVen[0, 1] = 0; }
                    else
                    {

                        if (producInd[i] > masVen[0, 0]) { masVen[0, 0] = producInd[i]; masVen[0, 1] = i; }
                        if (producInd[i] < menosVen[0, 0]) { menosVen[0, 0] = producInd[i]; menosVen[0, 1] = i; }
                    }
                    venTotal += venInd[i];
                }

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Total de productos A vendidos " + producInd[0] + " ventas del producto: $" + venInd[0]);
                Console.WriteLine();
                Console.WriteLine("Total de productos B vendidos " + producInd[1] + " ventas del producto: $" + venInd[1]);
                Console.WriteLine();
                Console.WriteLine("Total de productos C vendidos " + producInd[2] + " ventas del producto: $" + venInd[2]);
                Console.WriteLine();
                Console.WriteLine("Total de productos D vendidos " + producInd[3] + " ventas del producto: $" + venInd[3]);
                Console.WriteLine();
                Console.WriteLine("Total de productos F vendidos " + producInd[4] + " ventas del producto: $" + venInd[4]);
                Console.WriteLine();
                Console.WriteLine("Total de productos vendidos: " + producTotal);
                Console.WriteLine();
                Console.WriteLine("Total de dinero de las ventas realizadas: $" + venTotal);
                Console.WriteLine();
                Console.WriteLine("Promedio de ventas por producto: $" + venTotal / producTotal);
                Console.WriteLine();
                Console.WriteLine("el vendeor #" + (vendedor[1] + 1) + " fue el que más ventas realizo con: $" + vendedor[0]);
                Console.ResetColor();

                vendedor[0] = vendedor[1] = 0;
                ventas = 0;
                menu();
                op = int.Parse(Console.ReadLine());


            }
           
            
           
        }
        static void tipoProduc(double j)
        {
            Console.Write("Escriba cuantos productos ");
            Console.Write(producto(j));
            Console.Write(" vendio el vendedor: ");

        }

        static string producto(double j)
        {
            string tipo = "";
            if (j == 0) { tipo = "A"; }
            if (j == 1) { tipo = "B"; }
            if (j == 2) { tipo = "C"; }
            if (j == 3) { tipo ="D"; }
            if (j == 4) { tipo = "F"; }
            return tipo;
        }
        static void venConMasVentas(double j, double num)
        {
          
            if (j == 0) { ventas +=  1000 * num; }
            if (j == 1) { ventas += 2345 * num; }
            if (j == 2) { ventas += 3876 * num; }
            if (j == 3) { ventas += 1235 * num; }
            if (j == 4) { ventas += 550 * num; }
        }
        static void venta(int ven)
        {
            if ( vendedor[0] < ventas)
            {
                vendedor[0] = ventas;
                vendedor[1] = ven;
            }
            ventas = 0;
        }
        public static void menu()
        {

            Console.WriteLine(Environment.NewLine + 1 + ". Seguir en el programa");
            Console.WriteLine(0 + ". Salir");

        }
    }
}

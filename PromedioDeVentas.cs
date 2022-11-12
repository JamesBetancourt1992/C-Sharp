//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            float nipb=0;
            float nipc=0;
        float nipd=0;
            float nipa=0;
        float nipe=0;
        float ntp=0;
        float vtpa=0;
        float vtpb=0;
        float vtpc=0;
        float vtpd=0;
        float vtpe=0;
        float ptv=0;
        float a=0;
        float suma=0;
        int n;
        int b;
        int c;
        int d;
        int e;
        int f;
        

        Console.WriteLine("digite el numero de vendedores que desea analizar");
        n = int.Parse(Console.ReadLine());
            for (a=1;a<=n;a++)
            {
                Console.WriteLine("vendedor" + a);
                Console.WriteLine("cantidad del producto a vendia?");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("cantidad del producto b vendia?");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("cantidad del producto c vendia?");
                d = int.Parse(Console.ReadLine());
                Console.WriteLine("cantidad del producto d vendia?");
                e = int.Parse(Console.ReadLine());
                Console.WriteLine("cantidad del producto e vendia?");
                f = int.Parse(Console.ReadLine());

                nipa = suma + b;
                nipb = suma + c;
                nipc = suma + d;
                nipd = suma + e;
                nipe = suma + f;
                ntp = suma + b + c + d + e + f;
                vtpa = 100 * b;
                vtpb = 2345 * c;
                vtpc = 3876 * d;
                vtpd = 1235 * e;
                vtpe = 55 * f;
                ptv = (vtpa + vtpb + vtpc + vtpe) / 5;
                
                if (nipa>nipb && nipa>nipc && nipa>nipd && nipa>nipe) 
                {
        Console.WriteLine("el producto mas vendido es el a");

                }
                else {

            if (nipb>nipa && nipb>nipc && nipb>nipd && nipb>nipe) 
            {
            Console.WriteLine("el producto mas vendido es el b");
            }
            else 
            {
            if (nipc>nipa && nipc>nipb && nipc>nipd && nipc>nipe) 
            {
            Console.WriteLine("el producto mas vendido es el c");
            } 
            else 
            {
            if (nipd>nipa && nipd>nipb && nipd>nipc && nipd>nipe) 
            {
            Console.WriteLine("el producto mas vendido es el d");
            } 
            else 
            {
            if (nipe>nipa && nipe>nipb && nipe>nipc && nipe>nipd)
            {
                Console.WriteLine("el producto mas vendido es el e");
            }
            }
            }
            }
            }
            if (nipa<nipb && nipa<nipc && nipa<nipd && nipa<nipe)
            {
            Console.WriteLine("el producto menos vendido es el a");

            } 
            else
            {
            if (nipb<nipa && nipb<nipc && nipb<nipd && nipb<nipe) 
            {
            Console.WriteLine("el producto mas vendido es el b");
            } 
            else
            {
            if (nipc<nipa && nipc<nipb && nipc<nipd && nipc<nipe)
            {
            Console.WriteLine("el producto mas vendido es el c");
            } 
            else 
            {
            if (nipd<nipa && nipd<nipb && nipd<nipc && nipd<nipe) 
            {
            Console.WriteLine("el producto mas vendido es el d");
            } 
            else
            {
            if (nipe<nipa && nipe<nipb && nipe<nipc && nipe<nipd) 
            {
            Console.WriteLine("el producto mas vendido es el e");
            }
            }
            }
            }
            }
            }
            Console.WriteLine("el numero de productos a vendidos es: "+nipa);
            Console.WriteLine("el numero de productos b vendidos es: "+nipb);
            Console.WriteLine("el numero de productos c vendidos es:"+nipc);
            Console.WriteLine("el numero de productos d vendidos es:"+nipd);
            Console.WriteLine("el numero de productos e vendidos es:"+nipe);
            Console.WriteLine("el numero total de productos e vendidos es:"+ntp);
            Console.WriteLine("las ventas totales por producto a es:"+vtpa);
            Console.WriteLine("las ventas totales por producto b es:"+vtpb);
            Console.WriteLine("las ventas totales por producto b es:"+vtpb);
            Console.WriteLine("las ventas totales por producto c es:"+vtpc);
            Console.WriteLine("las ventas totales por producto d es:"+vtpd);
            Console.WriteLine("las ventas totales por producto e es:"+vtpe);
            Console.WriteLine("el promedio total de ventas es:"+ptv);

            Console.ReadKey();
            
            }

        
            }
        }
    


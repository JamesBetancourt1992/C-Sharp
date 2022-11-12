//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal

    class ProgramaPrincipal
    {

        public static void Main(string[] args)
        {
           //Permite utlizar los formatos de cultura utilizados en Estados Unidos
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            int op = 1 ;



            while (op != 0)
            {
                Console.Clear();

                texto();

                Console.WriteLine("Seleccione el programa que desea utilizar" + Environment.NewLine);
                menu();
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        signo_zodiacal.horoscopo();
                        break;
                    case 2:
                        ecuaciones.areas();
                        break;

                    case 3:
                        nota_minima_examen.nota();
                        break;

                    case 4:
                        calculadora.calcular();
                        break;

                    case 5:
                        reconocimiento.info();
                        break;

                    default:
                        break;

                }
            }
          
            //fin del programa
        }



        public static void menu()
        {
            Console.WriteLine(1 + ". Horoscopo");
            Console.WriteLine(2 + ". Calcular Areas");
            Console.WriteLine(3 + ". Nota para el Examen Final de Algoritmos");
            Console.WriteLine(4 + ". Calculadora");
            Console.WriteLine(5 + ". Reconocmimiento");
            Console.WriteLine(0 + ". Salir");
        }
        public static void texto()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Nombre del Autor: Julian Andres Morales");
            Console.WriteLine("Fecha: 03/11/2016");
            Console.WriteLine("Doy fe que este ejercicio es de mi autoría, en");
            Console.WriteLine("caso  de encontrar plagio la nota de todo mi");
            Console.WriteLine("trabajo debe ser de CERO además de las");
            Console.WriteLine("respectivas sanciones a que haya lugar" + Environment.NewLine + Environment.NewLine);
 
            Console.ResetColor();

        }
    }


}



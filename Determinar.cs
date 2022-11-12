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
    class Determinar
    {

        public static void numero()
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            double num;
            int op = 1;

            while (op != 0)
            {
                Console.Clear();

                centrarTexto("Determinación de Numeros" + Environment.NewLine + Environment.NewLine);


                Console.WriteLine("Por favor escriba un numero de maximo 3 digitos: ");
                num = validar(3);

                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("El numero " + num + Environment.NewLine);
                Console.WriteLine("Es par: " + (esPar(num) ? "Verdadero" : "Falso"));
                Console.WriteLine("Es primo: " + (esPrimo(num) ? "Verdadero" : "Falso"));
                Console.ResetColor();

           
                
                menu();
                op = int.Parse(Console.ReadLine());

            }

        }

        static double contarDigitos(double num)
        {
           
            double result;
            result = Math.Floor(Math.Log10(Math.Abs(num))) + 1;
        
            return result;
           
        }
        static void centrarTexto(string text)
        {

            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);

        }

        static double validar(double max)
        {
            double num;
            double digitos;

            num = double.Parse(Console.ReadLine());
            digitos = contarDigitos(num);
           
            while (digitos > max)
            {
                Console.WriteLine(Environment.NewLine + "Error. Por favor escriba un con maximo " + max + " digitos");
                num = double.Parse(Console.ReadLine());
                digitos = contarDigitos(num);
            }
           
            return num;
        }
        static bool esPrimo(double num)
        {
            int i = 2;

            bool primo = false;

            if (num <= 0 || num == 1 || num - Math.Floor(num) != 0)
            {
                primo = false;
            }
            else if (num == 2)
            {
                primo = true;
            }
            else
            {
                while ((num % i != 0) && (i != num - 1))
                {
                    i = i + 1;
                 
                    primo = (num % i == 0) ? false : true;
                }

            }
     
            return primo;

        }
      
        static bool esPar(double num)
        {

           return (num % 2 == 0) ? true : false;

        }
        static void menu()
        {
            Console.WriteLine(Environment.NewLine + 1 + ". Seguir en el programa");
            Console.WriteLine(0 + ". Salir");
        }

    }
}

//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class calculadora
    {

        static double operacion(double num1, string operador, double num2)
        {
            double resultado = 0;
            if (operador.Equals("+"))
            {
                resultado = num1 + num2;
            }
            if (operador.Equals("-"))
            {
                resultado = num1 - num2;
            }
            if (operador.Equals("*"))
            {
                resultado = num1 * num2;
            }
            if (operador.Equals("/"))
            {
                resultado = num1 / num2;
            }
            if (operador.Equals("mod"))
            {
                resultado = num1 % num2;
            }
            if (operador.Equals("sen"))
            {
                resultado = Math.Sin(num1);
            }
            if (operador.Equals("cos"))
            {
                resultado = Math.Cos(num1);
            }
            if (operador.Equals("tan"))
            {
                resultado = Math.Tan(num1);
            }
            return resultado;
        }

        // Muestra el menú 
        // y devuelve el primer número dado por el usuario
        static double inicio()
        {
            double num1;
            Console.WriteLine("                       Calculadora");
            Console.WriteLine("");
            Console.WriteLine("Digite el primer un numero");
            num1 = Double.Parse(Console.ReadLine());
            return num1;
        }

        // Muestra las operaciones
        // Devuelve  el operador dado por el usuario
        static string opciones()
        {
            string operador;
            Console.WriteLine(" ");
            Console.WriteLine("Nota: Ingrese = (igual) en la operación para terminar el proceso");
            Console.WriteLine(" ");
            Console.WriteLine("Digite la operación (+, - , * , /, mod, sen, cos, tan.)");
            operador = Console.ReadLine();
            return operador;
        }

        public static void calcular()
        {
            Console.Clear();


            int op;
            string operador;
            double num1 ;
            double num2 ;
            double resultado = 0;
           
            do
            {
                Console.Clear();

                num1 = 0;
                num2 = 0;
                resultado = 0;
                num1 = inicio();
                operador = opciones();
                // Mientras que el operador dado por el usuario
                // sea diferente a igual hacer las operaciones
                while (!operador.Equals("="))
                {
                    if ((!operador.Equals("sen")) && (!operador.Equals("cos")) && (!operador.Equals("tan")))
                    {
                        Console.WriteLine(Environment.NewLine + "Digite el segundo numero");
                        num2 = Double.Parse(Console.ReadLine());
                        resultado = operacion(num1, operador, num2);
                    }
                    else
                    {
                        resultado = operacion(num1, operador, 0);
                    }
                    num1 = resultado;
                    Console.Clear();

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Resultado: " + resultado);
                    Console.ResetColor();

                    operador = opciones();
                }
                // Asigna el resultado final 
                // al acumulado de operaciones que el usuario ha hecho
                if (operador.Equals("="))
                {
                    resultado = num1;
                }
                // Escribe el resultado final

                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(Environment.NewLine + "El resultado final es: " + resultado);
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();


                menu();
                op = int.Parse(Console.ReadLine());
            } while (op != 0);
            
          
        }
        public static void menu()
        {

            Console.WriteLine(Environment.NewLine + 1 + ". Seguir en el programa");
            Console.WriteLine(0 + ". Salir");

        }
    }

}

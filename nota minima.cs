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

    class nota_minima_examen
    {

        static double verificar(double nota_max, string act)
        {
            double nota_usuario;
            double resultado = 0;
            Console.WriteLine("");
            Console.WriteLine("Por favor escriba la calificación que obtuvo entre 0 a " + nota_max);
            do
            {
                nota_usuario = Double.Parse(Console.ReadLine());
                if ((nota_usuario <= nota_max) && (nota_usuario >= 0))
                {
                    resultado = nota_usuario;
                }
                else
                {
                    Console.WriteLine("La nota de la Actividad " + act + " debe ser un puntaje de 0 a " + nota_max);
                }
            } while (!((nota_usuario <= nota_max) && (nota_usuario >= 0)));
            Console.Clear();
            return resultado;
        }

        public static void nota()
        {
            Console.Clear();
            int op = 1;
            double nota_1;
            double nota_2;
            double nota_3;
            double nota_4;
            double nota_actual;
            double nota_necesaria;
            double nota_rec;

            // Se definen las notas a que hay a lo largo del curso;
            do
            {
                Console.Clear();

                Console.WriteLine("Nota mínima para el examen final");
                Console.WriteLine("");


                // Se llama la función que verifica el rango de las notas
                Console.WriteLine("En la Actividad de Reconocimiento");
                nota_rec = verificar(25, "Reconocimiento");
                Console.WriteLine("En la Actividad 1");
                nota_1 = verificar(125, "1");
                Console.WriteLine("En la Actividad 2");
                nota_2 = verificar(50, "2");
                Console.WriteLine("En la Actividad 3");
                nota_3 = verificar(125, "3");
                Console.WriteLine("En la Actividad 4");
                nota_4 = verificar(50, "4");
                Console.ResetColor();



                // Se suma las notas para general una nota actual
                nota_actual = nota_rec + nota_1 + nota_2 + nota_3 + nota_4;

                // Se le da la información al estudiando según su nota actual

                Console.BackgroundColor = ConsoleColor.Blue;
                if (nota_actual >= 300)
                {

                    Console.WriteLine("Felicidades su puntaje es " + nota_actual + " ya tiene el puntaje minimo para pasar la materia");
                }
                else
                {
                    if (nota_actual < 300 && nota_actual >= 175)
                    {
                        nota_necesaria = 300 - nota_actual;
                        Console.WriteLine("Necesita " + nota_necesaria + " puntos para poder pasar la materia");
                    }
                    if (nota_actual < 174)
                    {
                        Console.WriteLine("Lo siento, su puntaje es " + nota_actual + " no tiene oportunidades de pasar la materia");
                    }
                }
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

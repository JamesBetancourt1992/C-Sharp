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
    public class ecuaciones
    {

        static void menu()
        {
            Console.WriteLine("Ingrese la opción la cual desea elegir");
            Console.WriteLine(" " + 1 + ". Área de un triángulo");
            Console.WriteLine(" " + 2 + ". Área de un cuadrado");
            Console.WriteLine(" " + 3 + ". Área de un círculo");
            Console.WriteLine(" " + 4 + ". Área de un rectángulo");
            Console.WriteLine(" " + 5 + ". Área de un paralelogramo");
            Console.WriteLine(" " + 0 + ". Salir");
        }

        // Valida el número ingresado
        static int validar(int num, int max)
        {
            int resultado;
            while ((num > max) || (num < 0))
            {
                Console.WriteLine("Ingrese un numero de 0 a " + max);
                num = int.Parse(Console.ReadLine());
            }
            resultado = num;
            return resultado;
        }

        // Area de un triangulo
        static string a_triangulo()
        {
           

            double a;
            double b;
            double h;

           
            Console.WriteLine("Area de un Triangulo"+ Environment.NewLine);

            Console.WriteLine("Ingrese la base del triangulo");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo");
            h = Double.Parse(Console.ReadLine());
            a = (b * h) / 2;
            return "El area del triangulo es: " + a + " cm^2";
        }

        // Area de un cuadrado
        static string a_cuadrado()
        {
            double a;
            double l;

            Console.WriteLine("Area de un Cuadrado" + Environment.NewLine);

            Console.WriteLine("Ingrese la longitud de un lado del cuadrado");
            l = Double.Parse(Console.ReadLine());
            a = Math.Pow(l, 2);
          return "La area del cuadrado es: " + a + " cm^2";
        }

        static string a_circulo()
        {
            double a;
            double r;

            Console.WriteLine("Area de un Circulo" + Environment.NewLine);

            Console.WriteLine("Ingrese el radio del círculo");
            r = Double.Parse(Console.ReadLine());
            a = Math.PI * (Math.Pow(r, 2));

            return "El area del círculo es: " + a + " cm^2";
        }

        // Area de un rectángulo
        static string a_rectangulo()
        {
            double a;
            double b;
            double h;

            Console.WriteLine("Area de un Rectangulo" + Environment.NewLine);

            Console.WriteLine("Ingrese la base del rectangulo");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo");
            h = Double.Parse(Console.ReadLine());
            a = (b * h);
            return "El area del rectangulo es: " + a + " cm^2";
        }

        // Area de un paralelogramo
        static string a_paralelogramo()
        {
            double a;
            double b;
            double h;

            Console.WriteLine("Area de un Paralelogramo" + Environment.NewLine);

            Console.WriteLine("Ingrese la base del paralelogramo");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del paralelogramo");
            h = Double.Parse(Console.ReadLine());
            a = (b * h);
            return "El area del paralelogramo es: " + a + " cm^2";
        }

        public static void areas()
        {
            Console.Clear();

            int op;
            string resultado = "";

            Console.WriteLine("Areas");
            Console.WriteLine("");
            menu();
            op = int.Parse(Console.ReadLine());
            op = validar(op, 5);
            // Repetir las opciones hasta ingresar el numero 0
            while ((op != 0))
            {
                // Llamar a las funciones de acuerdo al valor ingresado
                Console.Clear();

                switch (op)
                {
                    case 1:
                       resultado = a_triangulo();
                        break;
                    case 2:
                       resultado = a_cuadrado();
                        break;
                    case 3:
                       resultado = a_circulo();
                        break;
                    case 4:
                      resultado = a_rectangulo();
                        break;
                    case 5:
                       resultado = a_paralelogramo();
                        break;
                }
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(Environment.NewLine + resultado + Environment.NewLine);
                Console.ResetColor();


                Console.WriteLine(Environment.NewLine + "Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                // Dar la opción de salir o continuar al usuario
                menu();
                op = int.Parse(Console.ReadLine());
                op = validar(op, 5);
            }
        }

    }
}

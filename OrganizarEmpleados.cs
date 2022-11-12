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
    class OrganizarEmpleados
    {

        public static void empleados()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            string categoria;
            double horas;
            double salario;

            int op = 1;

            while (op != 0)
            {
                Console.Clear();


                Console.WriteLine("Organización de Empleados por Categoria" + Environment.NewLine);


                Console.WriteLine(Environment.NewLine + "Categoria del empleado (A1, B2, C3, B4)");
                categoria = Console.ReadLine();

                Console.WriteLine(Environment. NewLine + "Numero de horas trabajadas por el empleado");
                horas = double.Parse(Console.ReadLine());

                salario = salarioMensual(categoria, horas);

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(Environment.NewLine + "Al empleado se le paga: " + salario);
                Console.ResetColor();

                menu();
                op = int.Parse(Console.ReadLine());
            }
              
            
        }

        static double salarioMensual(string categoria, double horas)
        {
           double resultado = 0;
           double subsidio = 0;
            bool existe = false;

            if (categoria == "A1" || categoria == "a1") { resultado = (horas * 20000); existe = true; }
            if (categoria == "B2" || categoria == "b2") { resultado = (horas * 15000); existe = true; }
            if (categoria == "C3" || categoria == "c3") { resultado = (horas * 10000); existe = true; }
            if (categoria == "B4" || categoria == "b4") { resultado = (horas * 7500); existe = true; }

            if (existe == false)
            {
                Console.WriteLine(Environment.NewLine + "La categoria no es valida");
            }


           if(resultado < 1000000 && existe == true)
            {
                subsidio = resultado * 15 / 100;
                Console.WriteLine(Environment.NewLine + "Al empleado se le da un subsidio del 15%");
            }

            resultado = resultado - (resultado * 7.2 / 100 );


            resultado = resultado + subsidio;
         


         

            return resultado;
        }
        public static void menu()
        {

            Console.WriteLine(Environment.NewLine + 1 + ". Seguir en el programa");
            Console.WriteLine(0 + ". Salir");

        }
    }
}

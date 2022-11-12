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
    class FechaTranscurso
    {

        public static void identificar()
        {
            int op = 1;

            while (op != 0)
            {
                Console.Clear();

                int dd, mm, yyyy;
                string fecha;

                Console.WriteLine("Días transcurridos a partir de una fecha digitada hasta la fecha actual");

                dd = verificar(1, 31, "Escriba un día:");


                mm = verificar(1, 12, "Escriba un mes");


                yyyy = verificar(1989, 2099, "Escriba un año");



                fecha = Convert.ToString(dd + "/" + mm + "/" + yyyy);


                DateTime fechaValida;

                if (DateTime.TryParse(fecha, out fechaValida))
                {

                    Console.BackgroundColor = ConsoleColor.Blue;
                    fechaValida = DateTime.Parse(fecha);
                    Console.WriteLine("Los días transcurridos desde la fecha " + fecha + " hasta hoy:");
                    Console.WriteLine(Math.Floor((DateTime.Now - fechaValida).TotalDays) + " días");
                    Console.ResetColor();

                }
                else
                {
                    Console.WriteLine("Error :( no es una fecha validad, ingrese una fecha valida:");
                }

                menu();
               op = int.Parse(Console.ReadLine());
            }
                
        }

        public static void diaTranscurrido()
        {
            int dd, mm, yyyy;
            string fecha;

            int op = 1;

            while (op != 0)
            {
                Console.Clear();

                Console.WriteLine("Fecha del Siguiente Día a Partir de una Fecha Digitada");

                dd = verificar(1, 31, "Escriba un día:");


                mm = verificar(1, 12, "Escriba un mes");


                yyyy = verificar(1989, 2099, "Escriba un año");

                fecha = Convert.ToString(dd + "/" + mm + "/" + yyyy);

                DateTime fechaValida;

                if (DateTime.TryParse(fecha, out fechaValida))
                {
                    fechaValida = DateTime.Parse(fecha);
                    fechaValida = fechaValida.AddDays(1);

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El siguiente día corresponte a la fecha " + fecha +  " es (día, mes y año): ");
                    Console.WriteLine(fechaValida.ToString("dddd dd/MM/yyyy"));
                    Console.ResetColor();

                }
                else
                {
                    Console.WriteLine("Error :( no es una fecha validad");
                }
                menu();
                op = int.Parse(Console.ReadLine());
            }
                

         

        }


        static int verificar(int min ,int max, string tipo)
        {
            int fecha;
            int resultado = 0;
          
            Console.WriteLine( Environment.NewLine + tipo);
            do
            {
               fecha = int.Parse(Console.ReadLine());
                if ((fecha <= max) && (fecha >= min))
                {
                    resultado = fecha;
                }
                else
                {
                    Console.WriteLine("Error, escriba una una fecha validad de " + min  + " hasta " + max);
                }
            } while (((fecha > max) || (fecha < min)));
            Console.Clear();
            return resultado;
        }

        public static void menu()
        {

            Console.WriteLine(Environment.NewLine + 1 + ". Seguir en el programa");
            Console.WriteLine(0 + ". Salir");

        }
    }
}

//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;


namespace ProgramaPrincipal
{
    class Reloj
    {

        static int i = 0;
       static Timer timer = new Timer();
       
        
        public static void tiempo()
        {
            


           
                Console.Clear();
                string opReloj;



                configTiempo(1000, true);



                menuReloj();
                opReloj = Console.ReadLine();

                while (opReloj != "0")
                {

                    asigContador(opReloj);

                    timer.Start();

                    Console.WriteLine("Cargando...");
                    Console.ReadKey();
                    Console.Clear();


                    timer.Stop();

                    reiniciarValores();




                    menuReloj();
                    opReloj = Console.ReadLine();

                }


            
           
         //  timer.Dispose();

        }
        static void menuReloj()
        {
            Console.WriteLine(1 + ". Ver Reloj");
            Console.WriteLine(2 + ". Empezar Conometro en Segundos");
            Console.WriteLine(0 + ". Salir");
        }

        static void reloj(object source, ElapsedEventArgs e)
        {

            Console.Clear();
            
            Console.WriteLine("Reloj" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss tt") + Environment.NewLine);
            Console.ResetColor();
            Console.WriteLine("Presione una tecla para dejar de ver el reloj");
           
        }

        static void conometro(object source, ElapsedEventArgs e)
        {

            Console.Clear();

            Console.WriteLine("Conometro" + Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(i + " s" + Environment.NewLine);
            Console.ResetColor();
            
            i += 1;

            Console.WriteLine("Presione una tecla para dejar de ver conometro");
        }

        static void reiniciarValores()
        {
          
            timer.Elapsed -= reloj;
            timer.Elapsed -= conometro;
            i = 0;
           
            timer.Enabled = false;

        }

        static void configTiempo(double intervalo, bool repetir)
        {
            timer.Interval = 1000;
            timer.AutoReset = true;
        }

        static void asigContador(string opReloj)
        {
          switch (opReloj)
            {
                case "1":
                    timer.Elapsed += reloj;
                    break;
                case "2":
                    timer.Elapsed += conometro;
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        public static void menu()
        {

            Console.WriteLine(Environment.NewLine + 1 + ". Seguir en el programa");
            Console.WriteLine(0 + ". Salir");

        }


    }
   
}

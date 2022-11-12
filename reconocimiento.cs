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
    class reconocimiento
    {
 
        static void menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine(" ");
            Console.WriteLine(" " + 1 + ". Nombres");
            Console.WriteLine(" " + 2 + ". Lugar de Residencia");
            Console.WriteLine(" " + 3 + ". Contactos");
            Console.WriteLine(" " + 4 + ". Libro Preferido");
            Console.WriteLine(" " + 5 + ". Pelicula Preferida");
            Console.WriteLine(" " + 6 + ". Deporte que práctica");
            Console.WriteLine(" " + 7 + ". Otros aspectos");
            Console.WriteLine(" " + 8 + ". Despedida");
            Console.WriteLine(" " + 0 + ". Salir");
        }

        // Valida que el número dado por el usuario
        // Este entre uno y un número máximo
        static int validar(int num, int max)
        {
            int resultado = 0;
            while ((num > max) || (num < 0))
            {
                Console.WriteLine("Ingrese una numero de 0 a " + max);
                num = int.Parse(Console.ReadLine());
            }
            resultado = num;
            return resultado;
        }

        public static void info()
        {

            Console.Clear();

            int num;
            // Muestra por  primera vez el menú 
            // y lee la opción del usuario
            menu();
            num = int.Parse(Console.ReadLine());
            num = validar(num, 8);
            while (num != 0)
            {
                Console.Clear();
                // Mustra la información solicitada 
                // por el usaurio
                Console.BackgroundColor = ConsoleColor.Blue;
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Mi Nombre es Julian Morales.");
                        break;
                    case 2:
                        Console.WriteLine("Vivo en Bogotá Colombia.");
                        break;
                    case 3:
                        Console.WriteLine("Correo: julianttm@gmail.com");
                        Console.WriteLine("Skype: julianm.un");
                        break;
                    case 4:
                        Console.WriteLine("Las mil y una noches.");
                        break;
                    case 5:
                        Console.WriteLine("Princesa Mononoke");
                        break;
                    case 6:
                        Console.WriteLine("Baloncesto.");
                        break;
                    case 7:
                        Console.WriteLine("Me gusta programar.");
                        break;
                    case 8:
                        Console.WriteLine("Gracias por leer. Les dejo un chiste");
                        Console.WriteLine("-¿Tienes internet? ¿Me das la clave?");
                        Console.WriteLine("-Dedicación y trabajo.");
                        break;
                    default:
                        Console.WriteLine("Error :(");
                        break;
                }
                Console.ResetColor();

            
                Console.WriteLine(Environment.NewLine + "Presione una tacla para continuar");
                Console.ReadKey();
                Console.Clear();
                // Vuelve a mostrar el menú el usuario
                // Ya sea para buscar más información o para salir
                menu();
                num = int.Parse(Console.ReadLine());
                num = validar(num, 8);
            }
        }

    }
}

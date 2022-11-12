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
 
    class signo_zodiacal
    {
        static int validar(int num, int max)
        {
            int resultado = 0;
            while ((num > max) || (num <= 0))
            {
                Console.WriteLine("Ingrese una fecha de 1 a " + max.ToString());
                num = int.Parse(Console.ReadLine());
          
            }
            resultado = num;
            return resultado;
        }

        // Comprueba el mes y el dia
        static string horoscopo(int dd, int mm)
        {
            string resultado = "";
            // Si está en el rango adecuado de mes y día
            // Muestra el horóscopo correspondiente
            if (mm >= 1 && mm <= 2)
            {
                if ((mm == 1 && dd >= 20) || (mm == 2 && dd <= 18))
                {
                    resultado = "Acuario. Tendra encuentros inesperados en su vida";
                }
            }
            if (mm >= 2 && mm <= 3)
            {
                if ((mm == 2 && dd >= 19) || (mm == 3 && dd <= 20))
                {
                    resultado = "Piscis. Nadara en el mar en este año";
                }
            }
            if (mm >= 3 && mm <= 4)
            {
                if ((mm == 3 && dd >= 21) || (mm == 4 && dd <= 19))
                {
                    resultado = "Aries. Aprendera ingles de manera facil y rapida";
                }
            }
            if (mm >= 4 && mm <= 5)
            {
                if ((mm == 4 && dd >= 20) || (mm == 5 && dd <= 20))
                {
                    resultado = "Tauro. Es fuerte y tiene muchos amigos";
                }
            }
            if (mm >= 5 && mm <= 6)
            {
                if ((mm == 5 && dd >= 21) || (mm == 6 && dd <= 20))
                {
                    resultado = "Génesis. Es necesario practicar para pruebas cognitivas que se prescentaran en el futuro";
                }
            }
            if (mm >= 6 && mm <= 7)
            {
                if ((mm == 6 && dd >= 21) || (mm == 7 && dd <= 22))
                {
                    resultado = "Cáncer. Debe ahorrar dinero para el futuro";
                }
            }
            if (mm >= 7 && mm <= 8)
            {
                if ((mm == 7 && dd >= 23) || (mm == 8 && dd <= 22))
                {
                    resultado = "Leo. Conguira un mascota que sera muy fiel";
                }
            }
            if (mm >= 8 && mm <= 9)
            {
                if ((mm == 8 && dd >= 23) || (mm == 9 && dd <= 22))
                {
                    resultado = "Virgo. Tendra nuevas ideas que le seran util para un mejor futuro";
                }
            }
            if (mm >= 9 && mm <= 10)
            {
                if ((mm == 9 && dd >= 23) || (mm == 10 && dd <= 22))
                {
                    resultado = "Libra. Viajara a un pais de otro continente";
                }
            }
            if (mm >= 10 && mm <= 11)
            {
                if ((mm == 10 && dd >= 23) || (mm == 11 && dd <= 21))
                {
                    resultado = "Escorpio. Debe tener cuidado con estafas y engaños";
                }
            }
            if (mm >= 11 && mm <= 12)
            {
                if ((mm == 11 && dd >= 22) || (mm == 12 && dd <= 21))
                {
                    resultado = "Sagitario. Tendras diferentes oportunidades de cambiar de estilo de vida";
                }
            }
            if (mm == 12 || mm == 1)
            {
                if ((mm == 12 && dd >= 22) || (mm == 1 && dd <= 19))
                {
                    resultado = "Capricornio. Empezaras a cosumir comida más saludable";
                }
            }
            return resultado;
        }

        public static void horoscopo()
        {
            Console.Clear();

            string resultado;
            int dd;
            int mm;
            int op=1;

            // Se definen las variables de día y mes
            Console.WriteLine("Horoscopo");
            Console.WriteLine("");
            do
            {
                Console.WriteLine("Escriba el dia de su nacimiento");
                dd = int.Parse(Console.ReadLine());

                // Se validan los valores de dia y mes
                dd = validar(dd, 31);
                Console.Clear();
                Console.WriteLine("Escriba el mes de su nacimiento");
                mm = int.Parse(Console.ReadLine());
                mm = validar(mm, 12);

                // Se da el horosco correpondiente a la fecha
                resultado = horoscopo(dd, mm);

                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(Environment.NewLine + resultado + Environment.NewLine);
                Console.ResetColor();

                Console.WriteLine(Environment.NewLine + "Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();

                menu();
                op = int.Parse(Console.ReadLine());
            }
            while (op != 0);
           

        }
        public static void menu()
        {
        
            Console.WriteLine(Environment.NewLine +  1 + ". Seguir en el programa");
            Console.WriteLine(0 + ". Salir");
         
        } 

    }
}

//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class atletasarreglo
    {
        //inicia la aplicacion
        static void Main(string[] args)
        {
            //se crean las variables
            int n = 0; //variable para controlar el ciclo atletas
            int i = 0;//varialble control de ciclo tiempos
            string valor = "";

            //Variables para hallar el promedio
            float suma = 0.0f;
            float promedio = 0.0f;

            Console.WriteLine("******************************");
            Console.WriteLine("*UNAD COMPETENCIA ATLETISMO***");
            Console.WriteLine("***Harol Alexander Vargas*****");
            Console.WriteLine("******COD. 1030616813*********");
            Console.ReadLine();

            //se crea arreglo para sacar las sumas y los promedios
            float[] promediof = new float[3];
            float[] sumaf = new float[3];
            //se crea el arreglo para 3 participantes
            float[,] tiempos = new float[4,3];

            //rutina i para capturar la informacion de los cuatro tiempos
            for (i=0; i<3; i++)
            {
                suma = 0.0f;//reinicia la variable suma
                promedio = 0.0f;//reinica la variable promedio
                //inicia n para capturar la informacion de los 4 atletas
                for (n = 0; n < 4; n++)
                {
                    System.Console.Clear();//borra la pantalla
                    Console.WriteLine(" Por favor ingrese el tiempo  " + (n + 1) + "  atleta " + (i + 1) + ":");
                    valor = Console.ReadLine();
                    tiempos[n, i] = Convert.ToSingle(valor);
                }

                //Encontrar promedio primera vez
                for (n = 0; n < 4; n++)
                {
                    suma += tiempos[n, i];
                }
                promedio = suma / 4;
                System.Console.Clear();//borra la pantalla
                Console.WriteLine("el promedio de los tiempos es:" + promedio);
                Console.ReadLine();

            }

            sumaf[0] = tiempos[0, 0] + tiempos[1, 0] + tiempos[2, 0] + tiempos[3, 0];
            sumaf[1] = tiempos[0, 1] + tiempos[0, 1] + tiempos[2, 1] + tiempos[3, 1];
            sumaf[2] = tiempos[0, 2] + tiempos[0, 2] + tiempos[2, 2] + tiempos[3, 2];

            Console.WriteLine("****************************");
            Console.WriteLine("la suma del tiempo 1 es:" + sumaf[0]);
            Console.WriteLine("la suma del tiempo 2 es:" + sumaf[1]);
            Console.WriteLine("la suma del tiempo 3 es:" + sumaf[2]);
            Console.WriteLine("****************************");

            promediof[0] = sumaf[0] / 4;
            promediof[1] = sumaf[1] / 4;
            promediof[2] = sumaf[2] / 4;

            Console.WriteLine("****************************");
            Console.WriteLine("el promedio del tiempo 1 es" + promediof[0]);
            Console.WriteLine("el promedio del tiempo 2 es" + promediof[1]);
            Console.WriteLine("el promedio del tiempo 3 es" + promediof[2]);
            Console.WriteLine("****************************");
            Console.ReadLine();


        }
    }
}

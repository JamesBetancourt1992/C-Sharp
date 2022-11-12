//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_Atletismo
{
    class Run
    {
        private string[] atletas;
        private int[,] tiempos;
        private int[] tiemposprom;

        public void Inicio()

        {
            atletas = new String[4];
            tiempos = new int[4, 3];
            for (int f = 0; f < atletas.Length; f++)
            {
                Console.Write("Ingrese el nombre del Atleta " + (f + 1) + ": ");
                atletas[f] = Console.ReadLine();
                for (int c = 0; c < tiempos.GetLength(1); c++)
                {
                    Console.Write("Ingrese tiempo Carrera " + (c + 1) + ": ");
                    string linea;
                    linea = Console.ReadLine();
                    tiempos[f, c] = int.Parse(linea);
                }
            }

        }

        public void Promedio()
        {
            tiemposprom = new int[4];
            for (int f = 0; f < tiempos.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < tiempos.GetLength(1); c++)
                {
                    suma = suma + tiempos[f, c];
                }
                tiemposprom[f] = suma / 3;
            }
        }


        public void Ganador()
        {
            int time = tiemposprom[0];
            string name = atletas[0];
            for (int f = 0; f < tiemposprom.Length; f++)
            {
                if (tiemposprom[f] < time)
                {
                    time = tiemposprom[f];
                    name = atletas[f];
                }
            }
            Console.WriteLine("El atleta ganador es " + name + " con tiempo promedio de " + time);
            Console.WriteLine("Congratulations");

        }

            static void Main(string[] args)

            {
                Run Run1 = new Run();
                Run1.Inicio();
                Run1.Promedio();
                Run1.Ganador();
                Console.ReadKey();



        }

        } } 
    

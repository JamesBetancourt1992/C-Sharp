//James Betancourt
//Curso de Programaci�n C#
//Ingenieria Electronica 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo_caso_Bubble
{
    class Bubble {
        static void Main()
        {
            int[] nums ={99, -10, 100123, 18, -978, 5623, 463, -9, 287, 40};
            int a, b, t;
            int tamaño;
            //Establece la cantidad de elementos a organizar
            tamaño = 10;

            //muestra arreglo original
            Console.Write("El arreglo original es :");
            for (int i = 0; i < tamaño; i++)
                Console.Write(" " + nums[i]);
            Console.WriteLine();
            //Esta es la organización bubble.
            for (a = 1; a < tamaño; a++)
                for (b = tamaño - 1; b >= a; b--) {
                    if (nums[b - 1] > nums[b])
                    {
                        //Intercambia los elementos organizados.
                        t = nums[b - 1];
                        nums[b - 1] = nums[b];
                        nums[b] = t;
                    }
                }
            //Muestra el arreglo organizado 
            Console.Write("El arreglo organizado es: ");
            for (int i = 0; i < tamaño; i++)
                Console.Write(" " + nums[i]);
            Console.WriteLine();
            Console.ReadKey();
        }
    } }

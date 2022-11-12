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
        string a,b,c,d;
        double e,f,g,h,i,j,k,l,m,n,o,p,q, r, s, t;


        public void Inicio()
        {
            Console.WriteLine("Bienvenidos a la Triatlon Anual");
            Console.WriteLine("Por favor Ingresar nombre de partipante N° 1");
            a = (Console.ReadLine());
            Console.WriteLine("Por favor Ingresar nombre de partipante N° 2");
            b = (Console.ReadLine());
            Console.WriteLine("Por favor Ingresar nombre de partipante N° 3");
            c = (Console.ReadLine());
            Console.WriteLine("Por favor Ingresar nombre de partipante N° 4");
            d =(Console.ReadLine());
            Console.Clear();

        }

        public void Atletismo()
        {
            Console.WriteLine("Carrera Atletismo");
            Console.WriteLine("Por Favor ingrese tiempo de Cada participante");
            Console.WriteLine("Tiempo Carrera Atletismo partipante N° 1");
            e = System.Double.Parse(Console.ReadLine());
            Console.WriteLine("Tiempo Carrera Atletismo partipante N° 2");
            f = System.Double.Parse(Console.ReadLine());
            Console.WriteLine("Tiempo Carrera Atletismo partipante N° 3");
            g = System.Double.Parse(Console.ReadLine());
            Console.WriteLine("Tiempo Carrera Atletismo partipante° 4");
            h = System.Double.Parse(Console.ReadLine());
            Console.Clear();

        }
        public void Ciclismo()
        {
            Console.WriteLine("Carrera Ciclismo");
            Console.WriteLine("Por Favor ingrese tiempo de Cada participante");
            Console.WriteLine("Tiempo Carrera Ciclismo partipante N° 1");
            i = System.Double.Parse(Console.ReadLine());
            Console.WriteLine("Tiempo Carrera Ciclismo partipante N° 2");
            j = System.Double.Parse(Console.ReadLine());
            Console.WriteLine("Tiempo Carrera Ciclismo partipante N° 3");
            k = System.Double.Parse(Console.ReadLine());
            Console.WriteLine("Tiempo Carrera Ciclismo partipante° 4");
            l = System.Double.Parse(Console.ReadLine());
            Console.Clear();

        }
        public void Natación()
        {
            Console.WriteLine("Carrera Natación");
            Console.WriteLine("Por Favor ingrese tiempo de Cada participante");
            Console.WriteLine("Tiempo Carrera Natación partipante N° 1");
            m = System.Double.Parse(Console.ReadLine());
            Console.WriteLine("Tiempo Carrera Natación partipante N° 2");
            n = System.Double.Parse(Console.ReadLine());
            Console.WriteLine("Tiempo Carrera Natación partipante N° 3");
            o = System.Double.Parse(Console.ReadLine());
            Console.WriteLine("Tiempo Carrera Natación partipante° 4");
            p = System.Double.Parse(Console.ReadLine());
            Console.Clear();

        }
        public void Resultados()

        {
            q = ( e + i + m) / 3;
            r=  (f + j + n) / 3;
            s = (g + k + o) / 3;
            t = (h + l + p) / 3;
            Console.WriteLine("Resultado Finales");
            Console.WriteLine("Resultado Participante N° 1:\n" +
                "\n1.Nombre: {0}" +
                "\n2.Atlestismo: {1}" +
                "\n3.Ciclismo: {2}" +
                "\n4.Natación: {3}" +
                "\n5.Promedio: {4}",a,e,i,m,q);
            Console.WriteLine("Resultado Participante N° 2:\n" +
                "\n1.Nombre: {0}" +
                "\n2.Atlestismo: {1}" +
                "\n3.Ciclismo: {2}" +
                "\n4.Natación: {3}" +
                "\n5.Promedio: {4}", b,f,j,n,r);
            Console.WriteLine("Resultado Participante N° 3:\n" +
                "\n1.Nombre: {0}" +
                "\n2.Atlestismo: {1}" +
                "\n3.Ciclismo: {2}" +
                "\n4.Natación: {3}" +
                "\n5.Promedio: {4}", c,g,k,o,s);
            Console.WriteLine("Resultado Participante N° 4:\n" +
                "\n1.Nombre: {0}" +
                "\n2.Atlestismo: {1}" +
                "\n3.Ciclismo: {2}" +
                "\n4.Natación: {3}" +
                "\n5.Promedio: {4}", d,h,l,p,t);
            Console.ReadLine();
            Console.Clear();

        }
        public void Ganador()
        {   if (q < r && q < s && q < t)
                Console.WriteLine("El Ganador es Nombre: {0}; Tiempo Promedio: {1}", a, q);
            if (r < q && r < s && r < t)
                Console.WriteLine("El Ganador es Nombre: {0}; Tiempo Promedio: {1}", b, r);
            if (s < q && s < r && s < t)
                Console.WriteLine("El Ganador es Nombre: {0}; Tiempo Promedio: {1}", c, s);
            if (t < q && t < r && t < s)
                Console.WriteLine("El Ganador es Nombre: {0}; Tiempo Promedio: {1}", d, t);
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}

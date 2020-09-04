using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CALIFICACIONES_ARREGLO_DOBLE_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]materia={"MATEMATICAS","ESPAÑOL","INGLES"};
            int i;
           
            double[]calificaciones=new double[3];
            string nombre,semestre;
            Console.WriteLine("NOMBRE");
            nombre=Console.ReadLine();
            Console.WriteLine("SEMESTRE");
            semestre = Console.ReadLine();
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} ", materia[i]);
               calificaciones[i]=double.Parse(Console.ReadLine());
            }
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("NOMBRE:{0}", nombre);
                Console.WriteLine("SEMESTRE:{0}", semestre);
            }
            Console.WriteLine("{0}:{1}", materia[i], calificaciones[i]);
            Console.ReadLine();




        }
    }
}

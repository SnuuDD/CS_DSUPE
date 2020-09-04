using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz_Maestro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letrero = { "Nombre: ", "Materia: ", "Grado y Grupo: ", "Horas a la semana: " };
            string[,] Horas = new string [4,45];
            int i,j;
            Console.WriteLine("Introduce los datos solicitados");
            for (j=0;j<45;j++)
                for (i=0;i<4;i++)
                {
                     Console.Write("{0}", letrero[i]);
                    Horas[i, j] = Console.ReadLine();
                }
            Console.WriteLine("Los datos son: ");
            for (j=0;j<45;j++)
                for (i=0;i<4;i++)
                {
                    Console.WriteLine("{0}:{1}", letrero[i], Horas[i, j]);
                }
            Console.ReadKey();
                                   
        }
    }
}

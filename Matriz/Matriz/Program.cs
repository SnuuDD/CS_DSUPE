using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letrero = { "Nombre", "Calificacion" };
            string[,] alumnos = new string[2, 10];
            int i, j;
            Console.WriteLine("Introduce la informacion solicitada");
            for (j = 0; j < 10; j++)
            for (i = 0; i < 2; i++)
            {Console.Write("{0}: ", letrero[i]);
                alumnos[i,j] = Console.ReadLine();
            }
                    Console.WriteLine("Los datos son: ");
            for (j = 0; j < 10; j++)
            for (i = 0; i < 2; i++)
            {
                    Console.WriteLine("{0}:{1}",letrero[i], alumnos[i,j]);
                }
            Console.ReadKey();


                
            }
        }
    }


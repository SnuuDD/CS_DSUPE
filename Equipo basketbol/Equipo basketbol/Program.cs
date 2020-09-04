using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equipo_basketbol
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = new string[5];
            string[] p = { "Centro", "Ala derecha", "Ala izquierda", "Poste derecho", "Poste Izquiero" };
            int i;
            for (i = 0; i <= 5; i++)
            {
                Console.Write(" {0}", p[i]);
                n[i]=Console.ReadLine();
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} : {1}", n[i], p[i]);

            }
            



        }

    }
    }

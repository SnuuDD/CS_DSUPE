using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rango
{
    class Program
    {
        static void Main()
        {
            float edad;
            Console.WriteLine("Ingresa tu edad");
            edad = float.Parse(Console.ReadLine());
            if (edad >= 3 && edad <= 5)
            {
                Console.WriteLine("Estas en prescolar");
               
            }else
            {Console.WriteLine();
                }

            }



        }
    }
}

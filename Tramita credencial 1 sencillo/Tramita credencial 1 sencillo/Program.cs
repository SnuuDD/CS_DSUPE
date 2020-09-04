using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tramita_credencial_1_sencillo
{
    class Program
    {
        static void Main()
        {
            
           double edad, r;
            
            do
            {
            Console.WriteLine("Introduce tu edad");
            edad = double.Parse(Console.ReadLine());
            if (edad == 18); 
            Console.WriteLine("Tramita tu credencial");
            Console.WriteLine("Deseas volver a evaluar otro num presiona 1");
            r = double.Parse(Console.ReadLine());
            } while (r == 1);






        }
    }
}

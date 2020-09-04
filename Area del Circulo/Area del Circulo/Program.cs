4using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Area_del_Circulo
{
    class Program
    {
        static void Main()
        {
            float radio;
            double pi=3.1416, area;
            Console.WriteLine("Inserta la medida del Radio");
            radio = float.Parse(Console.ReadLine());
            area = pi*(radio*radio);
            Console.WriteLine("El area es {0}",area);
            Console.WriteLine("Inserta una tecla para avanzar");
            Console.ReadLine();
              
        }
    }
}

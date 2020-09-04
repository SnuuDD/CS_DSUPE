using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cuadrado
{
    class Cuadrado
    {
        static void Main()
        {
            float area, lado;
                Console.WriteLine("Digita la medida del lado");
            lado = float.Parse(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El area del cuadrado es {0}",area);
            Console.ReadLine();

        }
    }
}

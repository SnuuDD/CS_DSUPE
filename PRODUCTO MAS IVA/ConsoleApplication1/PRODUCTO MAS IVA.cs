using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            float precio;
            double iva = 0.16,total;
            Console.WriteLine("INTRODUCE EL PRECIO DE EL PRODUCTO");
            precio = float.Parse(Console.ReadLine());
            total = precio + (precio * iva);
            Console.WriteLine("EL PRECIO DE EL PRODUCTO ES {0}", total);
            Console.WriteLine("PRESIONA UNA TECLA PARA CONTINUAR");
            Console.ReadLine();
        }
    }
}

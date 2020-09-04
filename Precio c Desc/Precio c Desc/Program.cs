using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Precio_c_Desc
{
    class Program
    {
        static void Main(string[] args)
        {
            float d2, p1, p2, d1, t, td;
            Console.WriteLine("Inserta ambos precios ☺");
            p1 = float.Parse(Console.ReadLine());
            p2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce los descuentos en valor decimal");
            d1 = float.Parse(Console.ReadLine());
            d2 = float.Parse(Console.ReadLine());
            td = (p1 - (p1 * d1)) + (p2 - (p2 * d2));
            t = p1 + p2;
            Console.WriteLine("Precio 1 = ${0}", p1);
            Console.WriteLine("Precio 2 = ${0}", p2);
            Console.WriteLine("Total = ${0}", t);
            Console.WriteLine("Descuento 1 = {0}%", d1*100);
            Console.WriteLine("Descuento 2 = {0}%", d2*100);
            Console.WriteLine("Total a Pagar = ${0}", td);
            Console.WriteLine("☻");
            Console.ReadLine();
        }
    }
}

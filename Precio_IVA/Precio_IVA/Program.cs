using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Precio_IVA
{
    class Program
    {
        static void Main()
        {float precio;
        double iva = 0.16, total;
        Console.WriteLine("Inserta el precio del producto");
                precio = float.Parse(Console.ReadLine());
                total = precio + (precio * iva);
                Console.WriteLine("El precio con IVA es {0}", total);
                Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IVA_For
{
    class Program
    {
        static void Main(string[] args)
        {
            float precio, total = 0;
            double iva, x;
            int i;
            for (i = 1; i <= 3; i++)
            {
                Console.Write("Digita el precio del Objeto {0}: ", i);
                precio = float.Parse(Console.ReadLine());
                total = total + precio;
                Console.WriteLine("Precio {0} = {1}!♦", i, precio);
                Console.WriteLine();
            }
            iva = total * 0.16;
            x = total + iva;
            Console.WriteLine();
            Console.WriteLine("El total es = ${0}", total);
            Console.WriteLine();
            Console.WriteLine("El IVA es = ${0}", iva);
            Console.WriteLine(); 
            Console.WriteLine("El total a pagar es = ${0}", x);
            Console.WriteLine(); 
            Console.WriteLine("☻ Presiona una tecla para salir ♣");
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Producto_de_2_numeros
{
    class Program
    {
        static void Main()
        {float producto ,numero1, numero2;
            int r;
                do
            {
            
            Console.WriteLine("introduce 2 numeros");
            numero1 = float.Parse(Console.ReadLine());
            numero2 = float.Parse(Console.ReadLine());
            producto = numero1*numero2;
            Console.WriteLine("El producto de los numeros es {0}", producto);
            Console.WriteLine("¿Deseas continuar?");
              r = int.Parse(Console.ReadLine());

            } while (r == 1);
            



        }
    }
}

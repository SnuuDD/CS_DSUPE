using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Total_de_2_Productos
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, z;
            Console.WriteLine("Inserta el precio de ambos productos");
                x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
            z = y+x;
            Console.WriteLine("El total a pagar es {0} ♠", z);
            Console.ReadLine();
        }
    }
}

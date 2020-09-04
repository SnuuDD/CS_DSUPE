using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cubo_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            float cubo, num;
            Console.WriteLine("Inserta un numero");
            num = float.Parse(Console.ReadLine());
            cubo = num * num * num;
            Console.WriteLine("El cubo del numero {0}, es: {1} ♠",num, cubo);
            Console.ReadLine();

        }
    }
}

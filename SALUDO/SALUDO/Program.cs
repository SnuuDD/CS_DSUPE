using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SALUDO
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("INTRODUCE TU NOMBRE");
            nombre = System.Console.ReadLine();
            Console.WriteLine("BIENVENIDO {0}", nombre);
            Console.WriteLine("PRESIONA UNA TECLA PARA CONTINUAR");
            Console.ReadLine();

        }
    }
}

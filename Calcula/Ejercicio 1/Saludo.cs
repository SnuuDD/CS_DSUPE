using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_1
{
    class Saludo
    {
       public static void Main()
        {
            string nombre;
           int edad,fech_a, fech_act = 2015;
           Console.WriteLine("Escribe tu nombre");
           nombre = System.Console.ReadLine();
           Console.WriteLine("Escribe tu año de nacimiento");
           fech_a = int.Parse(System.Console.ReadLine());
           edad = fech_act - fech_a;
           Console.WriteLine("Tu edad es {0}", edad);
           Console.ReadLine();
        }
    }
}
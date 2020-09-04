using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operacionse
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, a, r, l, aa;
            do
            {
                Console.WriteLine("¿Que quieres realizar?");
                Console.ReadLine();
                Console.WriteLine("Presiona 1 para suma");
                Console.ReadLine();
                Console.WriteLine("Presiona 2 para resta"); 
                Console.ReadLine();
                Console.WriteLine("Presiona 3 para multipicar");
                Console.ReadLine();
                k = int.Parse(Console.ReadLine());
                Console.WriteLine("Teclea el primer numero");
                r = int.Parse(Console.ReadLine());
                Console.WriteLine("Teclea el segundo numero");
                l = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        a = r + l;
                        Console.WriteLine("El resultado es: {0}!", a);
                        break;
                    case 2:
                        a = r - l;
                        Console.WriteLine("El resultado es: {0}!", a);
                        break;
                    case 3:
                        a = r * l;
                        Console.WriteLine("El resultado es: {0}!", a);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Error 404");
                        Console.ReadLine();
                        break;
                }
                Console.WriteLine("Presiona una tecla para salir");
                Console.ReadLine();
                Console.WriteLine("¿Quieres evaluar otro numero? Presiona 0 Ü!");
                aa = int.Parse(Console.ReadLine());
            } while (aa == 1);
        }
    }
}

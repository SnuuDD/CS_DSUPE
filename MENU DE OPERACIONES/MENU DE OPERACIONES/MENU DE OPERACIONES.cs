using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MENU_DE_OPERACIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,zz,n1,n2, resp;
            do
            {
                Console.WriteLine("¿QUE OPERACION DESEAS REALIZAR?");
                Console.WriteLine("DIGITA 1 PARA SUMA");
                Console.WriteLine("DIGITA 2 PARA RESTA");
                Console.WriteLine("DIGITA 3 PARA MULTIPLICACION");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("INTRODUCE EL PRIMER NUMERO");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("INTRODUCE EL SEGUNDO NUMERO");
                n2 = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        zz = n1 + n2;
                        Console.WriteLine("EL RESULTADO DE LA OPERACION ES {0}", zz);
                        break;
                    case 2:
                        zz = n1 - n2;
                        Console.WriteLine("EL RESULTADO DE LA OPERACION ES {0}", zz);
                        break;
                    case 3:
                        zz = n1 * n2;
                        Console.WriteLine("EL RESULTADO DE LA OPERACION ES {0}", zz);
                        break;
                    default:
                        Console.WriteLine("Error:NUMERO NO VALIDO");
                        break;
                }
                Console.WriteLine("PRESIONA UNA TECLA PARA CONTINUAR");
                Console.ReadLine();
                Console.WriteLine("¿QUIERES REPETIR EL PROCESO? (DIGITA 1)");
                resp = int.Parse(Console.ReadLine());
            } while (resp == 1);
        }
    }
}

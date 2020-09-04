using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSITIVO_NEGATIVO_NEUTRO
{
    class Program
    {
        static void Main()
        {
            int r;
            float num;

            do
            {
                Console.WriteLine("DIGITA UN NUMERO");
                num = float.Parse(Console.ReadLine());
                if (num > 0)
                    Console.WriteLine("NUMERO POSITIVO");
                else
                {
                    if (num < 0)
                        Console.WriteLine("NUMERO NEGATIVO");
                    else
                        Console.WriteLine("NUMERO NEUTRO");
                }
                Console.WriteLine("¿QUIERES EVALUAR OTRO NUMERO? (DIGITA 1)");
                r = int.Parse(Console.ReadLine());
            } while (r == 1);
        }
    }
}

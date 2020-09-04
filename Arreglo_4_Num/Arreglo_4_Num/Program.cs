using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arreglo_4_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            int max = 0, i;
            for (i = 0; i <= 3; i++)
            {
                Console.WriteLine("Numero {0}", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] > max)
                    max = numeros[i];
            }
            Console.WriteLine("Los numeros Capturados son:");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Numero {0}= ! {1} !", i + 1, numeros[i]);
            }
            Console.WriteLine("El numero mayor fue: {0}", max);
            Console.ReadKey();
        }
    }
}

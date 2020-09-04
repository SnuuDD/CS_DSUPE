using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace Matriz_P_I
{
    class Program
    {
         static void Main(string[] args)
        {
            int i, j=0, m=0;
            int[] numeros = new int[10];
            int[] pares = new int [j];
            int[] impares = new int [m];
            
            Console.WriteLine("Introduce los numeros a evaluar");

            for (i = 1; i < 11; i++)
            {
                Console.WriteLine("Numero {0}: ", numeros[i+1]);
                numeros[i] = int.Parse(Console.ReadLine());
                if
                    (numeros[i] % 2 == 0)
                     pares[i] = Console.Read();

                    if
                         (numeros[i] % 2 == 1)
                         impares[i] = Console.Read();
            }

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Numero par: {0}", pares[j]);
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Numero impar: {0}", impares[m]);
            }
        }
    }
}

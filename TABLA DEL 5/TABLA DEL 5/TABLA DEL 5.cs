using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TABLA_DEL_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, mul;
                for (i=1;i<=10;i++)
                {
                    mul = 5 * i;
                Console.WriteLine("5*{0}={1}",i,mul);
                }
                Console.WriteLine("PRESIONA UNA TECLA PARA CONTINUAR");
                Console.ReadLine();       
        }
    }
}

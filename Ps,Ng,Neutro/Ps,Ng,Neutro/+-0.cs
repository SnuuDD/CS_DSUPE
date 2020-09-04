using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {int r;
            float num;
            do
            {
            Console.WriteLine("Inserta un numero");
            num = float.Parse(Console.ReadLine());
          
            if (num > 0)
                Console.WriteLine("☻ El numero es positivo ☺");
            else
            {if
                (num < 0)
                Console.WriteLine("El numero es negativo");
            else
                Console.WriteLine("El numero neutro");
            }
            Console.WriteLine("Si quieres hacerlo denuevo teclea 1");
            r = int.Parse(Console.ReadLine());
            } while (r ==1);
}
}
}
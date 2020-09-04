using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOTAL_DE_3_PRODUCTOS_WHILE_
{
    class Program
    {
        static void Main(string[] args)
        {
            float precio, total = 0;
            int i = 0;
            while (i <= 2) 
            {
                i = i + 1;
                Console.WriteLine("PRECIO {0};", i);
                precio=float.Parse(Console.ReadLine());
                total=total+precio;
            }
            Console.WriteLine("TOTAL ${0}", total);
            Console.ReadLine();
        }
    }
}

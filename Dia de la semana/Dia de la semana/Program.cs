using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dias_de_la_semana
{
    class Program
    {
        static void Main()
        {
            int num;
                {
            Console.WriteLine("Escribe un numero del 1 - 7 !♠");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;

                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
                    {
                        Console.ReadKey();

            }             

            }
                
                
    
}
    }
}
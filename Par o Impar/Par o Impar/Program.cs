using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Par_o_Impar
{
    class Program
    {
        static void Main()
        {double numero;
            int r;
            do
            {

            Console.WriteLine("Dame un numero");
            numero = double.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else 
            {
                Console.WriteLine("Es numero es impar");
            }
            Console.WriteLine("presiona una tecla para continuar");
            Console.ReadLine();
             Console.WriteLine("Digita 9 para continuar");
            
                    r = int.Parse(Console.ReadLine());

            } while (r == 9) ;
            


        }
    }
}
        
         
                
    


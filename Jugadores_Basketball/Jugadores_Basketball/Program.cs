using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jugadores_Basketball
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombre = new string[5];
            string[] Posiciones= { "Centro", "Ala izquierda", "Ala derecha", "Poste Derecho", "Poste izquierdo"};
            Console.WriteLine("Ingresa el nombre de la posicion");
            int i;
            for (i = 0; i < 5; i++)
            {
            Console.Write("{0}: ", Posiciones[i]);
            Nombre[i]=Console.ReadLine(); 
            Console.WriteLine("");
            }
            Console.WriteLine("Tu equipo es:");
            for(i = 0 ;i < 5; i++)
            {
            Console.WriteLine("{0} : {1} !", Posiciones[i], Nombre[i]);
            }
            Console.ReadKey();
           
    }
    }
}
    
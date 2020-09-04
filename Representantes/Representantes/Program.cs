using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Representantes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombre = new string[4];
            string[] Concurso = { "Fonomimica", "Baile Moderno", "Expresion Artistica", "Danza Contemporanea" };
            string[] Grupo = new string[4];

            Console.WriteLine("Ingresa tu nombre seguido de tu grupo");

            int i;
            for (i = 0; i < 4; i++)
            {
                Console.Write("{0}: ", Concurso[i]);
                Nombre[i] = Console.ReadLine();
                Console.Write("Grupo: ");
                Grupo[i] = Console.ReadLine();
                Console.WriteLine("");
            }
            Console.WriteLine("Tus datos son:");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("{0} : {1} : {2} !", Concurso[i], Grupo[i], Nombre[i]);
            }
            Console.ReadKey();
        }
    }
}

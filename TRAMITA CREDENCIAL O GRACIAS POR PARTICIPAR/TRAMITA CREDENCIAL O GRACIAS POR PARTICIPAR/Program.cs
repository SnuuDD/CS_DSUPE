﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRAMITA_CREDENCIAL_O_GRACIAS_POR_PARTICIPAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp, edad;
            do
            {
                Console.WriteLine("INTRODUCE TU EDAD");
                edad = int.Parse(Console.ReadLine());
                if (edad == 18)
                {
                    Console.WriteLine("TRAMITA TU CREDENCIAL");
                }
                else
                {
                    Console.WriteLine("GRACIAS POR PARTICIPAR");
                }
                Console.WriteLine("PRESIONA UNA TECLA PARA CONTINUAR");
                Console.ReadLine();
                Console.WriteLine("¿QUIERES EVALUAR OTRO NUMERO? (DIGITA 1)");
                resp = int.Parse(Console.ReadLine());
            } while (resp == 1);
        }
    }
}

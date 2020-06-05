using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices1
{
    class Program
    {
        static int valor = 2;
        static string[,] letras = new string[valor, valor];
        static void Main(string[] args)
        {
            string linea;
            for (int l = 0; l < valor; l++)
            {
                for (int k = 0; k < valor; k++)
                {
                    Console.WriteLine("dato 1: " + l + "  dato 2: " + k + "\n\n");
                    Console.Write("Ingrese sus datos: ");
                    linea = Console.ReadLine();
                    letras[k, l] = linea;
                }
            }
            Console.WriteLine("\n-----------------------------------\n");
            for (int l = 0; l < valor; l++)
            {
                for (int k = 0; k < valor; k++)
                {
                    Console.WriteLine("Los Datos son: " + letras[k, l]);
                }
            }
            Console.ReadKey();
        }
    }
}

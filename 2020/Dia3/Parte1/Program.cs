using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            string lectura;
            int numArboles = 0, x=0, y = 0;

            Console.WriteLine("Ingresa tu rompecabezas, cuando termine presiona 0");
            while (true)
            {
                lectura = Console.ReadLine();
                if (lectura != "0") rompecabezas.Add(lectura);
                else break;
            }

            for (int i = 0; i < rompecabezas.Count; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    rompecabezas[i] += rompecabezas[i];
                }
            }

            for (int i = 0; i < rompecabezas.Count; i++)
            {
                x += 3;
                y += 1;

                if (y >= rompecabezas.Count) break;

                if (rompecabezas[y][x] == '#') numArboles++;
            }

            Console.WriteLine("\nRespuesta: ");
            Console.WriteLine(numArboles);
        }
    }
}

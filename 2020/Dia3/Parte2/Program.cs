using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            string lectura;
            int numArboles = 0, x = 0, y = 0, sumaX = 1, sumaY = 1;
            long multi = 1;

            Console.WriteLine("Ingresa tu rompecabezas, cuando termine presiona 0");
            while (true)
            {
                lectura = Console.ReadLine();
                if (lectura != "0") rompecabezas.Add(lectura);
                else break;
            }

            for (int i = 0; i < rompecabezas.Count; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    rompecabezas[i] += rompecabezas[i];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < rompecabezas.Count; j++)
                {
                    x += sumaX;
                    y += sumaY;

                    if (y >= rompecabezas.Count) break;

                    if (rompecabezas[y][x] == '#')
                    {
                        numArboles++;
                    }
                }

                if (i < 3)
                {
                    sumaX += 2;
                }

                if(i == 3)
                {
                    sumaX = 1;
                    sumaY = 2;
                }

                multi *= numArboles;

                numArboles = 0;
                x = 0;
                y = 0;
            }

            Console.WriteLine("\nRespuesta: ");
            Console.WriteLine(multi);
        }
    }
}

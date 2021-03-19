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

            while (true)
            {
                lectura = Console.ReadLine();
                if (lectura != "0") rompecabezas.Add(lectura);
                else break;
            }

            foreach (var item in rompecabezas)
            {
                x += 3;
                y += 1;

                if(rompecabezas[x][y] == '.')
            }
        }
    }
}

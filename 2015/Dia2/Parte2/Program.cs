using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            int[] area = new int[3];
            string input;
            int papelRegalo = 0, areaMinima = 10000, cinta = 0;

            while (true)
            {
                input = Console.ReadLine();
                if (input != "0") rompecabezas.Add(input);
                else break;
            }

            foreach (var item in rompecabezas)
            {
                var l = Int32.Parse(item.Split('x')[0]);
                var w = Int32.Parse(item.Split('x')[1]);
                var h = Int32.Parse(item.Split('x')[2]);

                int cintaEnvolver = l * w * h;

                area[0] = l * w;
                area[1] = w * h;
                area[2] = h * l;

                for (int i = 0; i < area.Length; i++)
                {
                    if (area[i] < areaMinima) areaMinima = area[i];
                }

                if (areaMinima == area[0]) cinta = (((l * 2) + (w * 2)) + (cintaEnvolver));
                else if (areaMinima == area[1]) cinta = (((w * 2) + (h * 2)) + (cintaEnvolver));
                else cinta = (((h * 2) + (l * 2)) + (cintaEnvolver));

                papelRegalo += cinta;

                areaMinima = 1000;
            }

            Console.WriteLine(papelRegalo);
        }
    }
}

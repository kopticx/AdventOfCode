using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            List<string> casas = new List<string>();
            int vertical = 0, horizontal = 0, regalos = 1;
            string input = "Aqui va el rompecabezas";

            Console.WriteLine("\nRespuesta");

            casas.Add("0 0");
            foreach (var item in input)
            {
                switch (item)
                {
                    case '^':
                        vertical++;
                        break;

                    case 'v':
                        vertical--;
                        break;

                    case '>':
                        horizontal++;
                        break;

                    case '<':
                        horizontal--;
                        break;
                }

                if (!casas.Exists(x => x == $"{vertical} {horizontal}"))
                {
                    regalos++;

                    casas.Add($"{vertical} {horizontal}");
                }
            }

            Console.WriteLine(regalos);
        }
    }
}

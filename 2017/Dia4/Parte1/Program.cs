using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            List<string> comprobante = new List<string>();
            string input;
            bool valido = true;
            int contrasenasValidas = 0;

            Console.WriteLine("Ingresa tu rompecabezas, cuando termine presiona 0");
            while (true)
            {
                input = Console.ReadLine();

                if (input != "0") rompecabezas.Add(input);
                else break;
            }

            foreach (var item in rompecabezas)
            {
                comprobante.Clear();
                valido = true;

                var separacion = item.Split(' ');

                foreach (var item2 in separacion)
                {
                    if(!comprobante.Exists(x => x == item2)) comprobante.Add(item2);
                    else
                    {
                        valido = false;
                        break;
                    }
                }

                if (valido) contrasenasValidas++;
            }

            Console.WriteLine("\nRespuesta: ");
            Console.WriteLine(contrasenasValidas);
        }
    }
}

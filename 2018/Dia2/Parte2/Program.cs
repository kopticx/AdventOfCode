using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            List<int> posicionesLetraDiferente = new List<int>();

            string input;
            int contador = 0;

            Console.WriteLine("Ingresa tu rompecabezas 0 para salir: ");

            while (true)
            {
                input = Console.ReadLine();

                if (input != "0") rompecabezas.Add(input);
                else break;
            }

            foreach (var item in rompecabezas)
            {
                foreach (var item2 in rompecabezas)
                {
                    for (int i = 0; i < item2.Length; i++)
                    {
                        if (item != item2)
                        {
                            if (item[i] != item2[i])
                            {
                                contador++;
                            }
                        }
                    }
                }
            }
        }
    }
}

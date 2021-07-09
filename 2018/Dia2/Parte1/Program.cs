using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            List<int> contadores = new List<int>();

            string input;
            int contador = 0, contador1 = 0, contador2 = 0, resultado;

            Console.WriteLine("Ingresa tu rompecabezas 0 para salir: ");

            while (true)
            {
                input = Console.ReadLine();

                if (input != "0") rompecabezas.Add(input);
                else break;
            }

            foreach (var item in rompecabezas)
            {
                foreach (var item2 in item)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (item2 == item[i]) contador++;
                    }

                    contadores.Add(contador);
                    contador = 0;
                }

                if (contadores.Exists(x => x == 2)) contador1++;
                if (contadores.Exists(x => x == 3)) contador2++;

                contadores.Clear();
            }

            resultado = contador1 * contador2;

            Console.WriteLine(resultado);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rompecabezas = new List<int>();
            int input, resultado = 0;

            while (true)
            {
                input = Int32.Parse(Console.ReadLine());

                if (input != 7000)
                {
                    rompecabezas.Add(input);
                }
                else break;
            }

            foreach (var item in rompecabezas)
            {
                resultado += item;
            }

            Console.WriteLine(resultado);
        }
    }
}

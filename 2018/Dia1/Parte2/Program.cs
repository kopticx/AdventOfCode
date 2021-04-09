using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rompecabezas = new List<int>();
            List<int> resultados = new List<int>();

            int input, resultado = 0;
            bool existe = false;

            while (true)
            {
                input = Int32.Parse(Console.ReadLine());

                if (input != 7000)
                {
                    rompecabezas.Add(input);
                }
                else break;
            }

            do
            {
                foreach (var item in rompecabezas)
                {
                    resultado += item;

                    if (!resultados.Exists(x => x == resultado))
                    {
                        resultados.Add(resultado);
                    }
                    else
                    {
                        existe = true;

                        break;
                    }
                }
            }
            while (existe == false);

            Console.WriteLine(resultado);
        }
    }
}

using System;
using System.Collections.Generic;   

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SIN RESOLVER AUN

            List<int> intsRompecabezas = new List<int>();

            int verb = 0, noun = 0;

            Console.WriteLine("Ingresa tu rompecabezas : ");

            var rompecabezas = Console.ReadLine().Split(',');

            rompecabezas[1] = "12";
            rompecabezas[2] = "2";

            foreach (var item in rompecabezas)
            {
                intsRompecabezas.Add(Int32.Parse(item));
            }

            for (int i = 0; i < intsRompecabezas.Count; i += 4)
            {
                if (intsRompecabezas[i] == 1)
                {
                    intsRompecabezas[intsRompecabezas[i + 3]] = intsRompecabezas[intsRompecabezas[i + 1]] + intsRompecabezas[intsRompecabezas[i + 2]];
                }
                else
                {
                    if (intsRompecabezas[i] == 2)
                    {
                        intsRompecabezas[intsRompecabezas[i + 3]] = intsRompecabezas[intsRompecabezas[i + 1]] * intsRompecabezas[intsRompecabezas[i + 2]];
                    }
                    else
                    {
                        if (intsRompecabezas[i] == 99) break;
                    }
                }
            }

            Console.WriteLine(intsRompecabezas[0]);
        }
    }
}

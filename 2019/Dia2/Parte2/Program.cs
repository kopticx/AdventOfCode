using System;
using System.Collections.Generic;   

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intsRompecabezas = new List<int>();
            int noun = 0, verb = 0;

            Console.WriteLine("Ingresa tu rompecabezas : ");

            var rompecabezas = Console.ReadLine().Split(',');

            foreach (var item in rompecabezas)
            {
                intsRompecabezas.Add(Int32.Parse(item));
            }

            List<int> copiaRompecabezas = new List<int>(intsRompecabezas);

            for (int j = 12; j < 99; j++)
            {
                for (int k = 2; k < 99; k++)
                {
                    intsRompecabezas = new List<int>(copiaRompecabezas);

                    intsRompecabezas[1] = j;
                    intsRompecabezas[2] = k;

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

                        if(intsRompecabezas[0] == 19690720)
                        {
                            noun = j;
                            verb = k;
                            goto respuesta;
                        }
                    }
                }
            }

            respuesta:
            Console.WriteLine("\nRepuesta:");
            Console.WriteLine(100 * noun + verb);
        }
    }
}

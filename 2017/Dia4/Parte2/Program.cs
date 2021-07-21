using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            List<string> comprobante = new List<string>();
            string input;
            bool valido = true;
            int contrasenasValidas = 0, contadorLetras = 0;

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
                contadorLetras = 0;

                var separacion = item.Split(' ');

                foreach (var item2 in separacion)
                {
                    if (!comprobante.Exists(x => x == item2)) comprobante.Add(item2);
                    else
                    {
                        valido = false;
                        break;
                    }
                }

                if (valido)
                {
                    foreach (var item2 in comprobante)
                    {
                        foreach (var item3 in comprobante)
                        {
                            if (item2 != item3 && item2.Length == item3.Length)
                            {
                                contadorLetras = 0;

                                for (int k = 0; k < item2.Length; k++)
                                {
                                    for (int i = 0; i < item3.Length; i++)
                                    {
                                        if (item2[k] == item3[i])
                                        {
                                            contadorLetras++;
                                            break;
                                        }
                                    } 
                                }

                                if (contadorLetras == item2.Length)
                                {
                                    valido = false;
                                    goto inicio;
                                }
                            }
                        }
                    }
                }

                inicio:

                if (valido) contrasenasValidas++;
            }

            Console.WriteLine("\nRespuesta: ");
            Console.WriteLine(contrasenasValidas);
        }
    }
}

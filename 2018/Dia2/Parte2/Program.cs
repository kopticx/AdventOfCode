using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            List<string> itemDiferente = new List<string>();

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
                    contador = 0;

                    if (item != item2)
                    {
                        for (int i = 0; i < item2.Length; i++)
                        {
                            if (item[i] != item2[i])
                            {
                                contador++;
                            }
                        }

                        if (contador == 1)
                        {
                            itemDiferente.Add(item2);
                        }
                    } 
                }
            }

            Console.WriteLine("\nRespuesta: ");
            for (int i = 0; i < itemDiferente[0].Length; i++)
            {
                if (itemDiferente[0][i] == itemDiferente[1][i]) Console.Write(itemDiferente[0][i]);
            }
        }
    }
}

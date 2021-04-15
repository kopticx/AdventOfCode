using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            List<char> letrasDiferentes = new List<char>();

            string input;
            char letra;
            int contador = 0, contador1 = 0, contador2 = 0, resultado, k = 0, vueltasItem = 0;

            Console.WriteLine("Ingresa tu rompecabezas 0 para salir: ");

            while (true)
            {
                input = Console.ReadLine();

                if (input != "0") rompecabezas.Add(input);
                else break;
            }

            foreach (var item in rompecabezas)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if(!letrasDiferentes.Exists(x => x == item[i]))
                    {
                        letrasDiferentes.Add(item[i]);
                    }
                }

                while (vueltasItem < item.Length)
                {
                    letra = letrasDiferentes[k];

                    for (int j = 0; j < item.Length; j++)
                    {
                        if (letra == item[j]) contador++;

                        if (contador == 2) contador1++;
                        else
                        {
                            if (contador == 3) contador2++;
                        }
                    }

                    Console.WriteLine(contador);

                    vueltasItem++;
                }

                k++;
            }

            resultado = contador1 * contador2;

            Console.WriteLine("La respuesta es : {0}", resultado);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu rompecabezas: ");

            string rompecabezas = Console.ReadLine();

            int suma = 0;
            string numero;

            for (int i = 0; i < rompecabezas.Length; i++)
            {
                if (i + 1 < rompecabezas.Length)
                {
                    if (rompecabezas[i] == rompecabezas[i + 1])
                    {
                        numero = rompecabezas[i].ToString();

                        suma += Int32.Parse(numero);
                    }
                }
                else break;
            }

            if (rompecabezas[rompecabezas.Length - 1] == rompecabezas[0])
            {
                numero = rompecabezas[0].ToString();

                suma += Int32.Parse(numero);
            }

            Console.WriteLine("\nLa respuesta es: {0}", suma);
        }
    }
}

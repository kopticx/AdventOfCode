using System;

namespace Parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el rompecabezas: ");
            string rompecabezas = Console.ReadLine();

            int suma = 0;
            int divisionLongitud = rompecabezas.Length / 2;
            string numero;

            for (int i = 0; i < rompecabezas.Length; i++)
            {
                if (i + divisionLongitud < rompecabezas.Length)
                {
                    if (rompecabezas[i] == rompecabezas[i + divisionLongitud])
                    {
                        numero = rompecabezas[i].ToString();

                        suma += (Int32.Parse(numero) * 2);
                    }
                }
                else break;
            }

            Console.WriteLine("\nLa respuesta es : {0}", suma);
        }
    }
}

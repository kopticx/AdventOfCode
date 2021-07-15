using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            string input;
            int triangulosValidos = 0, k = 0;

            Console.WriteLine("Ingresa tu rompecabezas: ");
            while (true)
            {
                input = Console.ReadLine();

                if (input != "0")
                {
                    if (k > 0) input = input.Remove(0, 2);

                    rompecabezas.Add(input);
                }
                else break;

                k++;
            }

            foreach (var item in rompecabezas)
            {
                var a = Int32.Parse(item.Substring(0, 3).Trim());
                var b = Int32.Parse(item.Substring(5, 3).Trim());
                var c = Int32.Parse(item.Substring(10, 3).Trim());

                if (a + b > c && a + c > b && b + c > a) triangulosValidos++;
            }

            Console.WriteLine("\nRespuesta: ");
            Console.WriteLine(triangulosValidos);
        }
    }
}

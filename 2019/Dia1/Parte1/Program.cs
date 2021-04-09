using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> rompecabezas = new List<double>();
            double input, suma = 0, operacion = 0;

            while (true)
            {
                input = Double.Parse(Console.ReadLine());

                if (input != 0)
                {
                    rompecabezas.Add(input);
                }
                else break;
            }

            foreach (var item in rompecabezas)
            {
                operacion = Math.Floor(item / 3) - 2;

                suma += operacion;
            }

            Console.WriteLine(suma);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> rompecabezas = new List<double>();
            double input, suma = 0, operacion = 0, diviones = 0;

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
                operacion = item;

                do
                {
                    operacion = Math.Floor(operacion / 3) - 2;

                    if (operacion > 0) diviones += operacion;

                } 
                while (operacion >= 0);

                suma += diviones;

                diviones = 0;
            }

            Console.WriteLine(suma);
        }
    }
}

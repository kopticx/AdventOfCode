using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rompecabezas = new List<int>();
            int numeros, resultado = 0;

            //La lectura termina cuando tecleas 0
            while (true)
            {
                numeros = Int32.Parse(Console.ReadLine());

                if (numeros != 0) rompecabezas.Add(numeros);
                else break;
            }

            //Recorremos la lista 2 veces hasta que los numeros sumen 2020
            foreach (var item in rompecabezas)
            {
                foreach (var item2 in rompecabezas)
                {
                    if (item + item2 == 2020) resultado = item * item2;
                }
            }

            //Imprimimos la multiplicacion
            Console.WriteLine(resultado);
        }
    }
}

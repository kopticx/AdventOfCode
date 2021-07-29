using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            string[] subcadenasDenegadas = new string[] { "ab", "cd", "pq", "xy" };
            string input;
            int cadenasBuenas = 0;

            Console.WriteLine("Ingresa tu rompecabezas, al terminar presiona 0");
            while(true)
            {
                input = Console.ReadLine();

                if (input != "0") rompecabezas.Add(input);
                else break;
            }

            foreach (var item in rompecabezas)
            {
                int contadorVocales = 0;
                bool letraSeguida = false, cadenaBuena = true;

                for (int i = 0; i < item.Length; i++)
                {
                    if(i + 1 <=  item.Length - 1)
                    {
                        if (item[i] == item[i + 1]) letraSeguida = true;

                        if (Array.Exists(subcadenasDenegadas, x => x == item[i].ToString() + item[i + 1].ToString())) cadenaBuena = false;
                    }

                    if (Array.Exists(vocales, x => x == item[i])) contadorVocales++;
                }

                if (cadenaBuena && letraSeguida && contadorVocales >= 3) cadenasBuenas++;
            }

            Console.WriteLine("\nResultado:");
            Console.WriteLine(cadenasBuenas);
        }
    }
}

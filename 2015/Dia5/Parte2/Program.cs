using System;
using System.Collections.Generic;
using System.Linq;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input != "0") rompecabezas.Add(input);
                else break;
            }

            Console.WriteLine("\nResultado:");
            Console.WriteLine(PartTwo(rompecabezas));
        }

        public static object PartTwo(List<string> input) =>
            input.Count(line => {
                var appearsTwice = Enumerable.Range(0, line.Length - 1).Any(i => line.IndexOf(line.Substring(i, 2), i + 2) >= 0);
                var repeats = Enumerable.Range(0, line.Length - 2).Any(i => line[i] == line[i + 2]);
                return appearsTwice && repeats;
            });
    }
}

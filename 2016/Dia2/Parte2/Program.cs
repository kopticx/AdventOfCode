using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            string input, respuesta = "";
            int x = 0, y = 0;

            Console.WriteLine("Ingresa tu rompecabezas 0 para salir: ");

            while (true)
            {
                input = Console.ReadLine();

                if (input != "0") rompecabezas.Add(input);
                else break;
            }

            foreach (var item in rompecabezas)
            {
                foreach (var item2 in item)
                {
                    //    1
                    //  2 3 4
                    //5 6 7 8 9
                    //  A B C
                    //    D
                    switch (item2)
                    {
                        case 'U':
                            if (y == 0 && x >= 1 && x <= 3) y++;
                            else if (y == 1 && x == 2) y++;
                            else if (y == -1 && x >= 1 && x <= 3) y++;
                            else if (y == -2 && x == 2) y++;
                            break;

                        case 'D':
                            if (y == 0 && x > 0 && x < 4) y--;
                            else if (y == 1 && x >= 1 && x < 4) y--;
                            else if (y == -1 && x == 2) y--;
                            else if (y == 2 && x == 2) y--;
                            break;

                        case 'R':
                            if (y == 0 && x >= 0 && x < 4) x++;
                            else if (y == 1 && x >= 1 && x < 3) x++;
                            else if (y == -1 && x >= 1 && x < 3) x++;
                            break;

                        case 'L':
                            if (y == 0 && x <= 4 && x > 0) x--;
                            else if (y == 1 && x <= 3 && x > 1) x--;
                            else if (y == -1 && x <= 3 && x > 1) x--;
                            break;
                    }
                }

                switch ($"{x} {y}")
                {
                    case "0 0":
                        respuesta += "5";
                        break;

                    case "1 0":
                        respuesta += "6";
                        break;

                    case "2 0":
                        respuesta += "7";
                        break;

                    case "3 0":
                        respuesta += "8";
                        break;

                    case "4 0":
                        respuesta += "9";
                        break;

                    case "1 1":
                        respuesta += "2";
                        break;

                    case "2 1":
                        respuesta += "3";
                        break;

                    case "3 1":
                        respuesta += "4";
                        break;

                    case "2 2":
                        respuesta += "1";
                        break;

                    case "1 -1":
                        respuesta += "A";
                        break;

                    case "2 -1":
                        respuesta += "B";
                        break;

                    case "3 -1":
                        respuesta += "C";
                        break;

                    case "2 -2":
                        respuesta += "D";
                        break;
                }
            }

            Console.WriteLine("\nRespuesta: ");
            Console.WriteLine(respuesta);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> casas = new List<string>();

            int verticalSanta = 0, horizontalSanta = 0, verticalRobot = 0, horizontalRobot = 0, regalos = 1;

            string input = ""; //Aqui va el rompecabezas

            Console.WriteLine("\nRespuesta");

            casas.Add("0 0");
            for (int i = 0; i < input.Trim().Length; i++)
            {
                if(i % 2 == 0)
                {
                    switch (input[i])
                    {
                        case '^':
                            verticalSanta++;
                            break;

                        case 'v':
                            verticalSanta--;
                            break;

                        case '>':
                            horizontalSanta++;
                            break;

                        case '<':
                            horizontalSanta--;
                            break;
                    }

                    if (!casas.Exists(x => x == $"{verticalSanta} {horizontalSanta}"))
                    {
                        regalos++;

                        casas.Add($"{verticalSanta} {horizontalSanta}");
                    }
                }
                else
                {
                    switch (input[i])
                    {
                        case '^':
                            verticalRobot++;
                            break;

                        case 'v':
                            verticalRobot--;
                            break;

                        case '>':
                            horizontalRobot++;
                            break;

                        case '<':
                            horizontalRobot--;
                            break;
                    }

                    if (!casas.Exists(x => x == $"{verticalRobot} {horizontalRobot}"))
                    {
                        regalos++;

                        casas.Add($"{verticalRobot} {horizontalRobot}");
                    }
                }
            }

            Console.WriteLine(regalos);
        }
    }
}

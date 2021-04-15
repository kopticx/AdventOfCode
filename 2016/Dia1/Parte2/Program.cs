using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            //By PromipiCode

            List<string> ubicaciones = new List<string>();

            string xy = "";
            var instruccions = Console.ReadLine().Split(", ");
            int x = 0, y = 0; //x representa este y oeste  |  Y representa norte y sur

            int mirada = 90;

            foreach (var instruction in instruccions)
            {
                if (instruction[0] == 'R')
                {
                    if (mirada == 360) mirada = 90;
                    else mirada += 90;
                }
                else
                {
                    if (mirada == 90) mirada = 360;
                    else mirada -= 90;
                }

                int sumar = int.Parse(string.Join("", instruction.Replace(instruction[0].ToString(), "")));

                if (mirada == 90) x += sumar;
                else if (mirada == 180) y += sumar;
                else if (mirada == 270) x -= sumar;
                else if (mirada == 360) y -= sumar;

                xy = $"Distancia : {Math.Abs(x + y)}, X = {x}, Y= {y}";

                /*if (!ubicaciones.Exists(x => x == xy))
                {
                    ubicaciones.Add(xy);
                }
                else break;*/

                Console.WriteLine(xy);
            }

            Console.WriteLine(xy);
        }
    }
}

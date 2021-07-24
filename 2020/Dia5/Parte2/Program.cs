using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            List<string> posicionFilas = new List<string>();
            List<string> posicionColum = new List<string>();
            List<string> asientos = new List<string>();
            string input;
            int fila = 0, columna = 0;

            Console.WriteLine("Ingresa tu rompecabezas, 0 para salir");

            while (true)
            {
                input = Console.ReadLine();

                if (input != "0") rompecabezas.Add(input);
                else break;
            }

            for (int i = 0; i < 128; i++)
            {
                asientos.Add("0,0,0,0,0,0,0,0");
            }

            foreach (var item in rompecabezas)
            {
                posicionFilas.Add("0 127");
                posicionColum.Add("0 7");

                for (int i = 0; i < item.Length; i++)
                {
                    var separacion = posicionFilas[0].Split(' ');
                    var separacion2 = posicionColum[0].Split(' ');
                    double valor1 = 0, valor2 = 0;

                    if (i != 6 && i != 9)
                    {
                        switch (item[i])
                        {
                            case 'F':
                                valor1 = Convert.ToDouble(separacion[0]);
                                valor2 = Double.Parse(separacion[1]) - Math.Ceiling((Double.Parse(separacion[1]) - Double.Parse(separacion[0])) / 2);

                                posicionFilas[0] = $"{valor1} {valor2}";
                                break;

                            case 'B':
                                valor1 = Double.Parse(separacion[1]) - Math.Floor((Double.Parse(separacion[1]) - Double.Parse(separacion[0])) / 2);
                                valor2 = Convert.ToDouble(separacion[1]);

                                posicionFilas[0] = $"{valor1} {valor2}";
                                break;

                            case 'L':
                                valor1 = Convert.ToDouble(separacion2[0]);
                                valor2 = Double.Parse(separacion2[1]) - Math.Ceiling((Double.Parse(separacion2[1]) - Double.Parse(separacion2[0])) / 2);

                                posicionColum[0] = $"{valor1} {valor2}";
                                break;

                            case 'R':
                                valor1 = Double.Parse(separacion2[1]) - Math.Floor((Double.Parse(separacion2[1]) - Double.Parse(separacion2[0])) / 2);
                                valor2 = Convert.ToDouble(separacion2[1]);

                                posicionColum[0] = $"{valor1} {valor2}";
                                break;
                        }
                    }
                    else
                    {
                        switch (item[i])
                        {
                            case 'F':
                                fila = Convert.ToInt32(separacion[0]);
                                break;

                            case 'B':
                                fila = Convert.ToInt32(separacion[1]);
                                break;

                            case 'L':
                                columna = Convert.ToInt32(separacion2[0]);
                                break;

                            case 'R':
                                columna = Convert.ToInt32(separacion2[1]);
                                break;
                        }
                    }
                }

                var asiento = asientos[fila].Split(',');
                string linea = "";
                asiento[columna] = "1";
                Array.ForEach(asiento, x => linea += $"{x}," );
                asientos[fila] = linea;

                posicionFilas.Clear();
                posicionColum.Clear();
                fila = 0;
                columna = 0;
            }

            Console.WriteLine("\nRespuesta:");
            for (int i = 0; i < 128; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    var asiento = asientos[i].Split(',');

                    if (asiento[k] == "0" && asientos[i].Contains('1') && i > 60 && i < 100) Console.WriteLine($"{i * 8 + k}");
                }
            }
        }
    }
}

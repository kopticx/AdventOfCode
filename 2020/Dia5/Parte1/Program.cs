using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            List<string> posicionFilas = new List<string>();
            List<string> posicionColum = new List<string>();
            List<int> tarjetas = new List<int>();
            string input;
            int fila = 0, columna = 0;

            Console.WriteLine("Ingresa tu rompecabezas, 0 para salir");

            while (true)
            {
                input = Console.ReadLine();

                if (input != "0") rompecabezas.Add(input);
                else break;
            }

            foreach (var item in rompecabezas)
            {
                posicionFilas.Add("0 127");
                posicionColum.Add("0 7");

                for(int i = 0; i < item.Length; i++)
                {
                    var separacion = posicionFilas[0].Split(' ');
                    var separacion2 = posicionColum[0].Split(' ');
                    double valor1 = 0, valor2 = 0;

                    if(i != 6 && i != 9)
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
                tarjetas.Add(fila * 8 + columna);

                posicionFilas.Clear();
                posicionColum.Clear();
                fila = 0;
                columna = 0;
            }

            tarjetas.Sort();
            Console.WriteLine("\nRespuesta:");
            Console.WriteLine(tarjetas[tarjetas.Count - 1]);
        }
    }
}

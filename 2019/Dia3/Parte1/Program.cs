using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coordenadasCable1 = new List<string>();
            List<string> coordenadasCable2 = new List<string>();
            int xCable1 = 0, yCable1 = 0, xCable2 = 0, yCable2 = 0;

            Console.WriteLine("Ingresa el primer rompecabezas: ");
            var rompecabezas = Console.ReadLine().Split(',');

            foreach (var item in rompecabezas)
            {
                if (item.StartsWith("R"))
                {
                    xCable1++;

                    for (int i = 0; i < xCable1; i++)
                    {
                        if (!coordenadasCable1.Exists(x => x == $"{i} {yCable1}"))
                        {
                            coordenadasCable1.Add($"{i} {yCable1}");
                        }
                    }
                }
                else
                {
                    if (item.StartsWith("L"))
                    {
                        xCable1--;

                        coordenadasCable1.Add($"{xCable1} {yCable1}");
                    }
                    else
                    {
                        if (item.StartsWith("U"))
                        {
                            yCable1++;

                            for (int i = 0; i <= yCable1; i++)
                            {
                                if (!coordenadasCable1.Exists(x => x == $"{xCable1} {i}"))
                                {
                                    coordenadasCable1.Add($"{xCable1} {i}");
                                }
                            }
                        }
                        else
                        {
                            if (item.StartsWith("D"))
                            {
                                coordenadasCable1.Add($"{xCable1} {yCable1}");
                            }
                        }
                    }
                }
            }

            Console.WriteLine("\nIngresa el segundo rompecabezas:");
            var rompecabezas2 = Console.ReadLine().Split(',');

            foreach (var item in rompecabezas2)
            {
                if (item.StartsWith("R"))
                {
                    xCable2++;

                    for (int i = 0; i < xCable2; i++)
                    {
                        if(!coordenadasCable2.Exists(x => x == $"{i} {yCable2}"))
                        {
                            coordenadasCable2.Add($"{i} {yCable2}");
                        }
                    }
                }
                else
                {
                    if (item.StartsWith("L"))
                    {
                        xCable2--;

                        coordenadasCable2.Add($"{xCable2} {yCable2}");
                    }
                    else
                    {
                        if (item.StartsWith("U"))
                        {
                            yCable2++;

                            for (int i = 0; i <= yCable2; i++)
                            {
                                if (!coordenadasCable2.Exists(x => x == $"{xCable2} {i}"))
                                {
                                    coordenadasCable2.Add($"{xCable2} {i}");
                                }
                            }
                        }
                        else
                        {
                            if (item.StartsWith("D"))
                            {
                                coordenadasCable2.Add($"{xCable2} {yCable2}");
                            }
                        }
                    }
                }
            }

            Console.WriteLine("\nResultado:");
            for (int i = 0; i < coordenadasCable1.Count; i++)
            {
                if (coordenadasCable2.Exists(x => x == coordenadasCable1[i]))
                {
                    Console.WriteLine(coordenadasCable1[i]);
                }
            }
        }
    }
}

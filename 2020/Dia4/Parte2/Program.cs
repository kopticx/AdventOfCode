using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            List<string> comprobante = new List<string>();
            List<string> colorOjos = new List<string>() { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
            string input;
            int pasaportesValidos = 0, campos = 0;
            bool contieneCid = false, hclValido = true;

            Console.WriteLine("Ingresa tu rompecabezas, cuando termine presiona 0");
            while (true)
            {
                input = Console.ReadLine();

                if (input != "0") rompecabezas.Add(input);
                else
                {
                    rompecabezas.Add("");
                    break;
                }
            }

            foreach (var item in rompecabezas)
            {
                if (item != "")
                {
                    comprobante.Add(item);
                }
                else
                {
                    foreach (var item2 in comprobante)
                    {
                        var separacion = item2.Split(' ');

                        for (int i = 0; i < separacion.Length; i++)
                        {
                            if (separacion[i].Contains("byr:"))
                            {
                                var validacion = separacion[i].Split(":")[1];

                                if (validacion.Length == 4 && Int32.Parse(validacion) >= 1920 && Int32.Parse(validacion) <= 2002) campos++;
                                else goto siguiente;
                            }

                            if (separacion[i].Contains("iyr:"))
                            {
                                var validacion = separacion[i].Split(":")[1];

                                if (validacion.Length == 4 && Int32.Parse(validacion) >= 2010 && Int32.Parse(validacion) <= 2020) campos++;
                                else goto siguiente;
                            }

                            if (separacion[i].Contains("eyr:"))
                            {
                                var validacion = separacion[i].Split(":")[1];

                                if (validacion.Length == 4 && Int32.Parse(validacion) >= 2020 && Int32.Parse(validacion) <= 2030) campos++;
                                else goto siguiente;
                            }

                            if (separacion[i].Contains("hgt:"))
                            {
                                var validacion = separacion[i].Split(":")[1];

                                if (validacion.Contains("in"))
                                {
                                    if (Int32.Parse(validacion.Substring(0, validacion.IndexOf('i'))) >= 59 && Int32.Parse(validacion.Substring(0, validacion.IndexOf('i'))) <= 76) campos++;
                                    else goto siguiente;
                                }
                                else
                                {
                                    if (validacion.Contains("cm"))
                                    {
                                        if (Int32.Parse(validacion.Substring(0, validacion.IndexOf('c'))) >= 150 && Int32.Parse(validacion.Substring(0, validacion.IndexOf('c'))) <= 193) campos++;
                                        else goto siguiente;
                                    }
                                    else goto siguiente;
                                }
                            }
                            
                            if (separacion[i].Contains("hcl:"))
                            {
                                var validacion = separacion[i].Split(":")[1];

                                if (validacion.Length == 7)
                                {
                                    if (validacion.StartsWith("#"))
                                    {
                                        for (int j = 1; j < validacion.Length; j++)
                                        {
                                            if (Char.IsLetter(validacion, j))
                                            {
                                                if (validacion[j] > 'f' || validacion[j] < 'a')
                                                {
                                                    hclValido = false;
                                                    break;
                                                }
                                            }
                                        }

                                        if (hclValido) campos++;
                                        else goto siguiente;
                                    }
                                    else goto siguiente;
                                }
                                else goto siguiente;
                            }

                            if (separacion[i].Contains("ecl:"))
                            {
                                var validacion = separacion[i].Split(":")[1];

                                if (colorOjos.Exists(x => x == validacion)) campos++;
                                else goto siguiente;
                            }

                            if (separacion[i].Contains("pid:"))
                            {
                                var validacion = separacion[i].Split(":")[1];

                                if (validacion.Length == 9) campos++;
                                else goto siguiente;
                            }

                            if (separacion[i].Contains("cid:"))
                            {
                                contieneCid = true;
                                campos++;
                            }
                        }
                    }

                    siguiente:

                    if (campos == 8) pasaportesValidos++;
                    else
                    {
                        if (campos == 7 && contieneCid == false) pasaportesValidos++;
                    }

                    Console.WriteLine(pasaportesValidos);

                    comprobante.Clear();
                    contieneCid = false;
                    hclValido = true;
                    campos = 0;
                }
            }

            Console.WriteLine("\nResultado:");
            Console.WriteLine(pasaportesValidos);
        }
    }
}

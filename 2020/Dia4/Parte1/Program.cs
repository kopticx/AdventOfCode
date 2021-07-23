using System;
using System.Collections.Generic;

namespace Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            List<string> comprobante = new List<string>();
            string input;
            int pasaportesValidos = 0, campos = 0;
            bool contieneCid = false;

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
                if (item != String.Empty)
                {
                    comprobante.Add(item);
                }
                else
                {
                    foreach (var item2 in comprobante)
                    {
                        if (item2.Contains("byr:")) campos++;
                        if (item2.Contains("iyr:")) campos++;
                        if (item2.Contains("eyr:")) campos++;
                        if (item2.Contains("hgt:")) campos++;
                        if (item2.Contains("hcl:")) campos++;
                        if (item2.Contains("ecl:")) campos++;
                        if (item2.Contains("pid:")) campos++;
                        if (item2.Contains("cid:"))
                        {
                            contieneCid = true;
                            campos++;
                        }
                    }

                    if (campos == 8) pasaportesValidos++;
                    else
                    {
                        if (campos == 7 && contieneCid == false) pasaportesValidos++;
                    }

                    comprobante.Clear();
                    contieneCid = false;
                    campos = 0;
                }
            }

            Console.WriteLine("\nResultado:");
            Console.WriteLine(pasaportesValidos);
        }
    }
}

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
            List<char> letrasPerGrupo = new List<char>();
            string cadena;
            int respuestaPerGrupo = 0, respuestasContestadas = 0;

            Console.WriteLine("Ingresa tu rompecabezas, 0 para salir");
            while (true)
            {
                cadena = Console.ReadLine();

                if (cadena != "0") rompecabezas.Add(cadena);
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
                    foreach (var item2 in comprobante[0])
                    {
                        letrasPerGrupo.Add(item2);
                    }

                    if(comprobante.Count > 1)
                    {
                        foreach (var item2 in letrasPerGrupo)
                        {
                            int contadorLetras = 0;
                            foreach (var item3 in comprobante)
                            {
                                if (item3.Contains(item2)) contadorLetras++;
                                else break;
                            }

                            if (contadorLetras == comprobante.Count) respuestaPerGrupo++;
                        }
                    }
                    else
                    {
                        foreach (var item2 in letrasPerGrupo)
                        {
                            respuestaPerGrupo++;
                        }
                    }

                    respuestasContestadas += respuestaPerGrupo;
                    comprobante.Clear();
                    letrasPerGrupo.Clear();
                    respuestaPerGrupo = 0;
                }
            }

            Console.WriteLine("\nRespuesta:");
            Console.WriteLine(respuestasContestadas);
        }
    }
}

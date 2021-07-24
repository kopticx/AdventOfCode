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
                    foreach (var item2 in comprobante)
                    {
                        foreach (var item3 in item2)
                        {
                            if(!letrasPerGrupo.Exists(x => x == item3))
                            {
                                respuestaPerGrupo++;
                                letrasPerGrupo.Add(item3);
                            }
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

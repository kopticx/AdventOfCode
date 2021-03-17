using System;
using System.Collections.Generic;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rompecabezas = new List<string>();
            string cadena;
            int contraseñasValidas = 0;

            while (true)
            {
                cadena = Console.ReadLine();

                if (cadena != "0") rompecabezas.Add(cadena);
                else break;
            }

            foreach (var item in rompecabezas)
            {
                //Separamos la cadena apartir de los :
                var parte1 = item.Split(':')[0];

                //Validacion ----> 1-4
                var validacion = parte1.Split(' ')[0];

                //Dividimos la validacion a partir del '-'
                var numero1 = Int32.Parse(validacion.Split('-')[0]);
                var numero2 = Int32.Parse(validacion.Split('-')[1]);

                //Letra
                var letra = Char.Parse(parte1.Split(' ')[1]);

                var contraseña = item.Split(':')[1].Trim();

                if (contraseña[numero1 - 1] == letra && contraseña[numero2 - 1] != letra || contraseña[numero1 - 1] != letra && contraseña[numero2 - 1] == letra) contraseñasValidas++;

            }

            Console.WriteLine(contraseñasValidas);
        }
    }
}

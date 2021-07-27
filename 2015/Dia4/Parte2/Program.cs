using System;
using System.Text;
using System.Security.Cryptography;

namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int i = 1;

            Console.WriteLine("Ingresa tu rompecabezas: ");
            input = Console.ReadLine();

            StringBuilder s = new StringBuilder(input);

            while (!GetMD5Hash(s.ToString()).StartsWith("000000"))
            {
                s = new StringBuilder(input);

                s.Append(i.ToString());

                i++;
            }

            Console.WriteLine("\nResultado: ");
            Console.WriteLine(i - 1);
        }

        static String GetMD5Hash(String input)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            String hash = s.ToString();
            return hash;
        }
    }
}

using System;
using System.Xml.Linq;

namespace Ejercicio6
{
    class program
    {
        static void Main(string[] args)
        {
            string Palabra, Reves = "";
            Console.Write("Ingresa una palabra:");
            Palabra = Console.ReadLine();
            foreach (char letra in Palabra)
            {
                Reves = letra.ToString() + Reves;
            }
            if (Palabra.ToLower() == Reves.ToLower())
            {
                Console.WriteLine($"La palabra {Palabra} es polindromo: {Reves}");
            }
            else
            {
                Console.WriteLine($"La palabra {Palabra} no es polindromo: {Reves}");
            }
        }
    }
}
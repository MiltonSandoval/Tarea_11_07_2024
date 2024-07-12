using System;
using System.Collections.Generic;

namespace EjercicioRepetirPalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            string Frase, Palabra = "";
            Console.Write("Ingresa una frase: ");
            Frase = Console.ReadLine().Trim();

            Dictionary<string, int> Contador = new Dictionary<string, int>();
            foreach (char letra in Frase + " ")
            {
                if (letra.ToString() == " " && Palabra != "")
                {
                    if (Contador.ContainsKey(Palabra.ToLower()))
                    {
                        Contador[Palabra.ToLower()]++;
                    }
                    else
                    {
                        Contador[Palabra.ToLower()] = 1;
                    }
                    Palabra = "";
                }
                else
                {
                    Palabra += letra.ToString();
                }
            }

            Console.WriteLine("\nPalabras que se repiten:");
            foreach (var veces in Contador)
            {
                if (veces.Value > 1)
                {
                    Console.WriteLine($"{veces.Key}: {veces.Value} veces");
                }
            }
        }
    }
}

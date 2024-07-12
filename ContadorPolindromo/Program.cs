using System;

namespace Ejercicio7
{
    class program
    {
        static void Main(string[] args)
        {
            string Palabra, Reves = "", Guardador = "";
            int Contador = 0;
            Console.Write("Ingresa una frase:");
            Palabra = Console.ReadLine().Trim();
            foreach (char letra in Palabra+" ")
            {
                if (letra.ToString() == " " && Guardador != "")
                {
                    if(Guardador.ToLower() == Reves.ToLower())
                    {
                        Contador++;
                    }
                    Guardador = "";
                    Reves = "";
                }
                else
                {
                    Guardador += letra.ToString();
                    Reves = letra.ToString() + Reves;
                }
            }
            Console.WriteLine($"La Frase:{Palabra} \nTiene {Contador} Palabras polindromo");
        }
    }
}
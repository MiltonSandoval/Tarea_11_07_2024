using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Ejercicio3
{
    class program
    {
        static void Main(string[] args)
        {
            string Frase, Nueva ="";
            Console.Write("Ingresa una frase:");
            Frase = Console.ReadLine();
            foreach (char letra in Frase)
            {
                if (letra.ToString() == " ")
                {
                    Nueva += "*";
                }
                else
                {
                    Nueva += letra.ToString();
                }
            }
            Console.WriteLine($"La nueva frase es:{Nueva}");
        }
    }
}
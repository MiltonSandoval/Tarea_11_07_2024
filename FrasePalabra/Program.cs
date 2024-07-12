using System;

namespace Ejercicio1
{
    class program
    {
        static void Main(string[] args)
        {
            string Frase, Palabra;
            Console.Write("Ingresa la frase:");
            Frase = Console.ReadLine();
            Console.Write("Ingresa la palabra a buscar:");
            Palabra = Console.ReadLine();
            if (Frase.ToLower().Contains(Palabra.ToLower()))
            {
                Console.WriteLine($"La frase: {Frase} \n Contiene la palabra:{Palabra}");
            }
            else
            {
                Console.WriteLine($"La frase: {Frase} \n No contiene la palabra:{Palabra}");
            }
        }
    }   
}
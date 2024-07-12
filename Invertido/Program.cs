using System;

namespace Ejercicio2
{
    class program
    {
        static void Main(string[] args)
        {
            string Name, Reves="";
            Console.Write("Ingresa tu nombre:");
            Name = Console.ReadLine();
            foreach (char letra in Name)
            {
                Reves = letra.ToString() + Reves;
            }
            Console.WriteLine($"{Name} al reves es:{Reves}");
        }
    }
}
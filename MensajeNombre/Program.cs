using System;

namespace Ejercicio1
{
    class program
    {
        static void Main(string[] args)
        {
            string Name;
            Console.Write("Ingresa tu nombre:");
            Name = Console.ReadLine();
            Console.WriteLine($"Bienvenido: Sr(a) {Name}, a su tienda de preferencia");
        }
    }
}
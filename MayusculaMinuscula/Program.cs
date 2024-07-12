using System;

namespace Ejercicio1
{
    class program
    {
        static void Main(string[] args)
        {
            string Letra, Comparador;
            Console.Write("Ingresa una letra:");
            Letra = Console.ReadLine();
            Comparador = Letra.ToLower();
            if(Letra == Comparador)
            {
                Console.WriteLine($"{Letra} es minuscula");
            }
            else
            {
                Console.WriteLine($"{Letra} es Mayuscula");
            }
        }
    }
}
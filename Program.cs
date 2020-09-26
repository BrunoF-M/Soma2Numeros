using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int numero1;
            int numero2;

            Console.Write("A soma de: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Mais..: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"é igual a: {numero1 + numero2}");
            Console.WriteLine();
            
            Console.WriteLine("Digite qualquer tecla para finalizar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

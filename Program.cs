using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.WriteLine("Digite o valor para verificação");
            valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("Número par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}

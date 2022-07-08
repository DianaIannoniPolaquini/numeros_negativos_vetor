using System;

namespace VETOR_NÚMERO_NEGATIVO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vet;

            Console.WriteLine("Entre com os números: ");
            n = int.Parse(Console.ReadLine());
            vet = new int[n];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(s[i]);
            }
            Console.WriteLine(); 
            Console.WriteLine("Os números negativos são: ");
            for (int i = 0; i < n; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }

            }
        }
    }
}

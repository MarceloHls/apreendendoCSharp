using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Somar(args);
        }
        static void Somar(params string[] Params)
        {
            int Length = Params.Length;

            int[] ints = new int[Params.Length];
            for (int i = 0; i < Params.Length; i++)
            {
                ints[i] = int.Parse(Params[i]);
            }

            if (Length == 0)
            {
                Console.WriteLine("Numeros insuficientes");
            }
            else if (Length == 1)
            {
                Console.WriteLine(Params[0]);
            }
            else
            {
                int soma = ints[0] + ints[1];
                Console.WriteLine($"{ints[0]} + {ints[1]} = {soma}");
                for (int i = 2; i < Length; i++)
                {
                    Console.WriteLine($"{soma} + {ints[i]} = {soma + ints[i] }");
                    soma += ints[i];
                }

            }

        }
    }
}

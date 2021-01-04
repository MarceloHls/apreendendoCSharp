using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                int[] n = new int[2];
                n[0] = Int32.Parse(args[0]);
                n[1] = Int32.Parse(args[2]);

                if (args[1] == "+")
                {
                    Console.WriteLine(n[0] + " + " + n[1] + " = " + (n[0] + n[1]));
                }
                else if (args[1] == "/")
                {
                    Console.WriteLine(n[0] + " / " + n[1] + " = " + (n[0] / n[1]));
                }
                else if (args[1] == "-")
                {
                    Console.WriteLine(n[0] + " - " + n[1] + " = " + (n[0] - n[1]));
                }
                else if (args[1] == "*")
                {
                    Console.WriteLine(n[0] + " x " + n[1] + " = " + (n[0] * n[1]));
                }
                else
                {
                    Console.WriteLine("Argumento invalido");
                    Console.WriteLine(" + || / || - || * ");
                    Console.WriteLine(" n + n");
                    Console.WriteLine(" n / n");
                    Console.WriteLine(" n - n");
                    Console.WriteLine(" n * n");
                }
            }
            else
            {
                Console.WriteLine("Sem argumento");
                Console.WriteLine(" + || / || - || * ");
                Console.WriteLine(" n + n");
                Console.WriteLine(" n / n");
                Console.WriteLine(" n - n");
                Console.WriteLine(" n * n");
            }
        }

    }
}

using System;

namespace Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Dividir(10, 2, out int resto);
            Console.WriteLine($"resultado {result} resto {resto}");

            int resto2;
            int result2 = Dividir(10, 3, out resto2);
            Console.Write($"resultado {result2} resto {resto2}");
        }
        static int Dividir(int divdendo, int divisor, out int resto)
        {
            resto = divdendo % divisor;
            return (divdendo / divisor);
        }
    }
}

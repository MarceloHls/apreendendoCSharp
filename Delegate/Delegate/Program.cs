using System;

namespace Delegate
{
    delegate int Op(int n1, int n2);
    class Math
    {
        public static int soma(int n1, int n2)
        {
            return n1 + n2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Op a = new Op(Math.soma);
            Console.WriteLine(a(5, 5));
        }
    }
}

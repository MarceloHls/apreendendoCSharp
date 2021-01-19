using System;

namespace Recursividade
{
    public static class Fatorial
    {
        public static int calcular(int n)
        {
            int resul;
            if (n <= 0)
            {
                resul = 1;
            }
            else
            {
                resul = n * calcular(n - 1);

            }
            return resul;

            // if(resul == 0){
            //      Console.Write($"{n}! = {n}");
            // }

            // ulong atual = n - 1;
            // if (atual > 0)
            // {
            //     Console.Write($" * {atual}");
            //     resul = resul == 0 ? n * atual : resul * atual;
            //     calcular(atual, resul);
            // }
            // else
            // {
            //     Console.Write(" = " + resul);
            // }

        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine(Fatorial.calcular(5));
        }
    }
}

using System;

namespace Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 10;
            num = num << 1;

            Console.WriteLine(num);

            num = num >> 1;
            Console.WriteLine(num);

            num = 10;
            num = num << 2;

            Console.WriteLine(num);

            num = num >> 3;
            Console.WriteLine(num);

        }
    }
}
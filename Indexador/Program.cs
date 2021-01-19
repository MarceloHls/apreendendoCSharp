using System;
using System.Collections.Generic;

namespace Indexador
{
    class Indexar
    {
        private string[] arr = new string[5];
        public string this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Indexar teste = new Indexar();
            teste[0] = "5";
            teste[1] = "20";
            Console.WriteLine(teste[0]);
            Console.WriteLine(teste[1]);

            List<int> lista = new List<int>();
        }
    }
}

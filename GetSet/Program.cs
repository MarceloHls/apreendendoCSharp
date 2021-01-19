using System;

namespace GetSet
{
    public class Pessoa
    {
        public string nome { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa eu = new Pessoa();

            eu.nome = "Marcelo";

            Console.WriteLine(eu.nome);


        }
    }
}

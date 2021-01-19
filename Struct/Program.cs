using System;

namespace Struct
{
    class Program
    {
        public struct Pessoa
        {
            string nome;
            int idade;

            public Pessoa(string nome, int idade)
            {
                this.nome = nome;
                this.idade = idade;
            }

            public void info(){
                Console.WriteLine(nome);
                Console.WriteLine(idade);
            }
        }
        static void Main(string[] args)
        {
            Pessoa eu =  new Pessoa("marcelo",22);
            eu.info();
        }
    }
}

using System;

namespace Static
{
    static public class JogadorStatic
    {
        static public int vida = 0;
        static public string nome;
        static public bool vivo = false;

        static public void Start(string nomeRecebido)
        {
            vida = 100;
            vivo = true;
            nome = nomeRecebido;
        }

        static public void Show()
        {
            string estado = vivo ? "vivo" : "morto";
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Vida: {vida}");
            Console.WriteLine($"Estado: {estado}");
        }
    }

    public class Jogador
    {
        public int vida = 0;
        public string nome;
        static public bool vivo = true;

        public Jogador(string nome)
        {
            vida = 100;
            this.nome = nome;
        }

        public void Show()
        {
            string estado = vivo ? "vivo" : "morto";
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Vida: {vida}");
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine("-----------------------------------");
        }

        static public void alterarVida(Jogador jogador, int valor)
        {
            jogador.vida = valor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            JogadorStatic.Start("marcelo static");
            JogadorStatic.Show();

            Jogador j1 = new Jogador("marcelo");
            Jogador j2 = new Jogador("joao");
            Jogador j3 = new Jogador("maria");


            j1.Show();
            j2.Show();
            j3.Show();

            Console.WriteLine("\n Aleterar estado \n ");
            Jogador.vivo = false;

            Jogador.alterarVida(j1,50);

            j1.Show();
            j2.Show();
            j3.Show();
        }
    }
}

using System;

namespace sobrecargaConstrutor
{

    public class Produto
    {
        public string nome;
        public int valor;
        public int quantidade;
        public Produto()
        {
            this.nome = "indefinido";
            this.valor = 0;
            this.quantidade = 0;
        }
        public Produto(string nome)
        {
            this.nome = nome;
            this.valor = 0;
            this.quantidade = 1;
        }
        public Produto(string nome, int valor)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = 1;
        }
        public Produto(string nome, int valor, int quantidade)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
        }

        public int subTotal()
        {
            if (this.quantidade > 0 & this.valor > 0)
            {
                return this.quantidade * this.valor;
            }
            else if (this.valor > 0)
            {
                return this.valor;
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de Produtos: ");
            int quantidade = int.Parse(Console.ReadLine());
            Produto[] produtos = new Produto[quantidade];
            for (int i = 0; i < quantidade; i++)


            {
                Console.Write("Digite o nome (se houver),o valor (se houver) e a quantidade (se houver) : ");
                string[] input = Console.ReadLine().Split(" ");
                if (input.Length <= 0)
                {
                    produtos[i] = new Produto();
                }
                else if (input.Length == 1)
                {

                    produtos[i] = new Produto(input[0]);
                }
                else if (input.Length == 2)
                {
                    int valor = int.Parse(input[1]);
                    produtos[i] = new Produto(input[0], valor);
                }
                else
                {
                    int valor = int.Parse(input[1]);
                    int quant = int.Parse(input[2]);
                    produtos[i] = new Produto(input[0], valor, quant);
                }
            }

            int opcao = 0;
            while (opcao != 2)
            {
                Console.WriteLine("Digite a opcao ");
                Console.WriteLine("1 - Listar todos ");
                Console.Write("2 - Sair:  ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            foreach (Produto produto in produtos)
                            {
                                int total = produto.subTotal();
                                Console.WriteLine($"{produto.nome}\t\t\t{produto.valor}\t\t\t{produto.quantidade}\t\t\t{total}");
                            }
                            break;
                        }
                }
            }

        }
    }
}

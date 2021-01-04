using System;

namespace First_Classe
{
    public class Pessoa
    {
        public string nome;
        public char sexo;
        public int idade = 0;
        private bool ativo = true;
        public void setPessoa(string nome, char sexo, int idade)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.idade = idade;
        }
        public Pessoa GetPessoa()
        {
            Pessoa newPessoa = new Pessoa();
            newPessoa.setPessoa(this.nome, this.sexo, this.idade);
            newPessoa.SetAtivo(this.ativo);
            return newPessoa;
        }

        
        public void show()
        {
            if (this.ativo)
            {
                Console.WriteLine($"{this.nome}\t{this.sexo}\t{this.idade}");
            }

        }
        public void SetAtivo(bool ativo)
        {
            this.ativo = ativo;
        }

    }
    public class Control
    {
        private int control = 0;
        private int limite = 0;
        public bool limiteExedido = false;

        public Control(int limite)
        {
            this.limite = limite;
        }
        public void addControl()
        {

            if (this.control < this.limite)
            {
                this.control++;
            }
            else
            {
                this.limiteExedido = true;
            }

        }
        public int GetControl()
        {

            if (this.control < this.limite)
            {
                return this.control;
            }
            else
            {
                this.limiteExedido = true;
                return this.control;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas Pessoas: ");
            int qunt = int.Parse(Console.ReadLine());
            Pessoa[] pessoas = new Pessoa[qunt];
            Control control = new Control(qunt);

            int opcao = 0;
            while (opcao != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Selcione as opcoes");
                Console.WriteLine("1 - Adicionar pessoa");
                Console.WriteLine("2 - Editar pessoa");
                Console.WriteLine("3 - Exluir pessoa");
                Console.WriteLine("4 - Listar pessoas");
                Console.WriteLine("5 - Sair");
                Console.Write("Digite: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (opcao)
                {
                    case 1:
                        if (!control.limiteExedido)
                        {
                            Pessoa newPessoa = new Pessoa();
                            Console.Write("Digite o nome: ");
                            newPessoa.nome = Console.ReadLine();
                            Console.Write("Digite o sexo: ");
                            newPessoa.sexo = char.Parse(Console.ReadLine());
                            Console.Write("Digite a idade: ");
                            newPessoa.idade = int.Parse(Console.ReadLine());
                            pessoas[control.GetControl()] = newPessoa;
                            control.addControl();
                        }
                        else
                        {
                            Console.WriteLine("Limite de pessoas adicionadas");
                        }

                        break;
                    case 2:
                        Console.Write("Digite o nome da pessoa: ");
                        string nome = Console.ReadLine();
                        bool localizado = false;
                        for (int i = 0; i < pessoas.Length & !localizado; i++)
                        {
                            string nomeAtual = pessoas[i].nome;
                            if (nomeAtual.Contains(nome))
                            {
                                Console.WriteLine();
                                Console.WriteLine("Localizado");
                                Console.WriteLine();
                                Pessoa newPessoa = new Pessoa();
                                Console.Write("Digite o nome: ");
                                newPessoa.nome = Console.ReadLine();
                                Console.Write("Digite o sexo: ");
                                newPessoa.sexo = char.Parse(Console.ReadLine());
                                Console.Write("Digite a idade: ");
                                newPessoa.idade = int.Parse(Console.ReadLine());
                                pessoas[i] = newPessoa;
                                localizado = true;
                            }
                        }
                        if (!localizado)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Não Localizado");
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.Write("Digite o nome da pessoa: ");
                        string nome2 = Console.ReadLine();
                        bool localizado2 = false;
                        for (int i = 0; i < pessoas.Length & !localizado2; i++)
                        {
                            string nomeAtual = pessoas[i].nome;
                            if (nomeAtual.Contains(nome2))
                            {
                                Console.WriteLine("Localizado");
                                Console.WriteLine("Excluido");
                                pessoas[i].SetAtivo(false);
                                localizado2 = true;
                            }
                        }
                        if (!localizado2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Não Localizado");
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        for (int i = 0; i < control.GetControl(); i++)
                        {
                            pessoas[i].show();
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
            }

        }
    }
}
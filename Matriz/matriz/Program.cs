using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade de pessoas: ");
            int quantidadePessoas = int.Parse(Console.ReadLine());

            string[,] pessoas = new string[quantidadePessoas, 3];
            string[] dados = { "Nome", "Idade", "Sexo" };

            for (int i = 0; i < quantidadePessoas; i++)
            {
                Console.WriteLine("***** Pessoa {0} ***** ", (i + 1));
                for (int i2 = 0; i2 < 3; i2++)
                {
                    Console.Write($"{dados[i2]} : ");
                    pessoas[i, i2] = Console.ReadLine();
                }
            }

            int[] maior = { 0, 0 };
            int[] menor = { 0, 0 };
            /// menorValor ----- Pessoa

            for (int i = 0; i < quantidadePessoas; i++)
            {
                int idade = int.Parse(pessoas[i, 1]);
               
                menor[0] = menor[0] == 0 ? idade : menor[0];

                if (idade > maior[0])
                {
                    maior[0] = idade;
                    maior[1] = i;
                }
                if (idade < menor[0])
                {
                    menor[0] = idade;
                    menor[1] = i;
                }
            }

            int opcao = 0;
            while (opcao != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Digite uma opcao");
                Console.WriteLine("1-Pessoa com maior idade");
                Console.WriteLine("2-Pessoa com menor idade");
                Console.WriteLine("3-Todas pessoas");
                Console.Write("4-Sair : ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (opcao)
                {
                    case 1:
                        for (int i = 0; i < 3; i++)
                            Console.WriteLine($"{dados[i]}: {pessoas[maior[1], i]}");
                        break;
                    case 2:
                        for (int i = 0; i < 3; i++)
                            Console.WriteLine($"{dados[i]}: {pessoas[menor[1], i]}");
                        break;
                    case 3:
                        Console.WriteLine("Nome \t\t Idade \t\t Sexo ");
                        for (int i = 0; i < quantidadePessoas; i++)
                            Console.WriteLine($"{pessoas[i, 0]} \t\t {pessoas[i, 1]} \t\t {pessoas[i, 2]} ");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida");
                        break;
                }
            }
        }
    }
}

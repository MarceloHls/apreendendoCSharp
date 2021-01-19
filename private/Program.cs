using System;

namespace Private
{
    class Program
    {

        public class Empresa
        {
            public int receita = 0;
            public string nome = "";
            private static double imposto = 25.5;
            private double lucro = 0;

            private static string senha = "governo";

            public Empresa(int receita, string nome)
            {
                this.nome = nome;
                this.receita = receita;
            }
            static public void AlterarImposto(double imposto, string senha)
            {
                if (senha == Empresa.senha)
                {
                    Empresa.imposto = imposto;
                }
            }

            private void calImposto()
            {
                this.lucro = (receita - receita * (Empresa.imposto / 100));
            }

            public void showLucro()
            {
                calImposto();
                Console.WriteLine($"{this.nome} -- Receita : {this.receita} bi Lucro: {this.lucro} bi");
            }
        }
        static void Main(string[] args)
        {


            string[] lista = {
                "1500 bradesco",
                "2000 tesla",
                "1100 google",
                "15000 apple",
                "13000 amazon"
                };

       

            Empresa[] empresas = new Empresa[lista.Length];

                    for (int i = 0; i < lista.Length; i++)
                    {
                        string[] empresaAtual = lista[i].Split();
                        int receita = int.Parse(empresaAtual[0]);
                        string nome = empresaAtual[1];
                        empresas[i] = new Empresa(receita, nome);
                    }

                    foreach (Empresa empresa in empresas)
                    {
                        empresa.showLucro();
                    }

                    Console.WriteLine("\n---------------------------\n");
                    Empresa.AlterarImposto(49.5, "governo");

                    foreach (Empresa empresa in empresas)
                    {
                        empresa.showLucro();
                    }

        }
    }
}

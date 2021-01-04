using System;

namespace contrutorDestrutor
{

    public class Calculos
    {
        private int n1;
        private int n2;
        public Calculos(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public void calcular()
        {
            Console.WriteLine("{0} + {1} = {2}", this.n1, this.n2, (this.n1 + this.n2));
            Console.WriteLine("{0} - {1} = {2}", this.n1, this.n2, (this.n1 - this.n2));
            Console.WriteLine("{0} * {1} = {2}", this.n1, this.n2, (this.n1 * this.n2));
            Console.WriteLine("{0} / {1} = {2}", this.n1, this.n2, (this.n1 / this.n2));

        }

        ~Calculos()
        {
            Console.WriteLine("Calculos de {0} com {1} encerrados",this.n1,this.n2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos calculos: ");
            int quant = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quant; i++)
            {
                Console.Write("Digite o primeiro numero : ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                int n2 = int.Parse(Console.ReadLine());
                Calculos calculos = new Calculos(n1, n2);
                calculos.calcular();
            }
        }
    }
}

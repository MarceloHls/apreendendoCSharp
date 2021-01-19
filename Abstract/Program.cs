using System;

namespace Abstract
{

    abstract public class Estado
    {
        protected string pais;
        protected string estado;

       
        public string getEstado()
        {
            return estado;
        }
        public string getPais()
        {
            return pais ;
        }
        abstract public string populacaoCidade();

    }

    public class Cidade:Estado{
        public string cidade;
        private double populacao;
        override public string populacaoCidade(){
            return populacao + " mi";
        }

        public Cidade(String estado, String cidade, double populacao){
           this.pais = "Brasil";
            this.estado = estado;
            this.cidade = cidade;
            this.populacao = populacao;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cidade sp = new Cidade("SP","Sao paulo",12.33);
            Console.WriteLine(sp.getPais());
            Console.WriteLine(sp.getEstado());
            Console.WriteLine(sp.cidade);
            Console.WriteLine(sp.populacaoCidade());
        }
    }
}

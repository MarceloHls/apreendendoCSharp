using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface
{

    public interface Pessoa
    {
        public void falar(string fala);
        public void Andar(int passos);
        public void dormir(int horas);
    }

    public interface Cidadao
    {
        public void getNaturalidade();
    }

    public class Brasileiro : Pessoa, Cidadao
    {
        string nome;
        string pais;

        public Brasileiro(string nome){
            this.pais = "Brasil";
            this.nome = nome;

        }
        public void falar(string fala)
        {
            Console.WriteLine(this.nome + " disse: " + fala);
        }
        public void Andar(int passos)
        {
             Console.WriteLine(this.nome + " deu " + passos + " passos");
        }
        public void dormir(int horas)
        {
             Console.WriteLine(this.nome + " dormiu " + horas + " horas");
        }
        public void getNaturalidade()
        {
            Console.WriteLine(this.nome + " nasceu em " + this.pais);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Brasileiro marcelo = new Brasileiro("marcelo");
            marcelo.Andar(900);
            marcelo.falar("Oi gente");
            marcelo.dormir(8);
            marcelo.getNaturalidade();

        }
    }
}

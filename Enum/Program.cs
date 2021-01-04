using System;

namespace Enum
{
    class Program
    {

        enum DiaSemana { Domingo, Segundo, Terça, Quarta, Quinta, Sexta, Sabado }
        static void Main(string[] args)
        {
            DiaSemana hoje = DiaSemana.Terça;
            DiaSemana amanha = (DiaSemana)3;
            Console.WriteLine(hoje);
            Console.WriteLine(amanha);
        }
    }
}

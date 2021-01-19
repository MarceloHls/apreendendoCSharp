using System;

namespace Protected
{
    class Program
    {
        static void Main(string[] args)
        {
         Empresa minha = new Empresa("marcelo",22,"Eu S/A","1234567891011");
         Console.WriteLine(minha.cnpj);
         Console.WriteLine(minha.fantasia);
        }
    }
}

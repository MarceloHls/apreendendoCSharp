using System;


namespace heranca
{

  
    class Program
    {
        static void Main(string[] args)
        {
          Carro.Carro ferrari = new  Carro.Carro(300,"Ferrari");
          Console.WriteLine($"Modelo:..........{ferrari.modelo}");
          Console.WriteLine($"Rodas:..........{ferrari.rodas}");
          Console.WriteLine($"VelMax:..........{ferrari.velMax}");
          Console.WriteLine($"Terrestre:..........{ferrari.terrestre}");
          Console.WriteLine($"Ligado:..........{ferrari.getLigado()}");
          ferrari.setLigado(true);
          Console.WriteLine($"Ligado:..........{ferrari.getLigado()}");
        }
    }
}

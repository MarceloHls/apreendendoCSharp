using System;
using System.Collections.Generic;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> obj = new Dictionary<string, string>();
            obj.Add("Frutas", "Melao,Melancia,Banana");
            obj.Add("Veiculos", "Carro,Moto,Aviao");

            foreach ( string key in obj.Keys)
            {
                Console.WriteLine(key);
                foreach (string value in obj[key].Split(","))
                {
                    Console.WriteLine(value.PadLeft(20));
                }
            }

        }
    }
}

using System;

namespace Virtual
{
    public class Base{
        virtual public  void print(){
            Console.WriteLine("Base");
        }
    }

    public class Derivada:Base{
        override public  void print(){
             Console.WriteLine("Derivada");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Derivada().print();
        }
    }
}

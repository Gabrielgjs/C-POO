using System;

namespace ModificadorDeParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Calculadora.Soma(2, 2);
            int b = Calculadora.Soma(2, 2, 4);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}

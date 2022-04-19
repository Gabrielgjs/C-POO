using System;

namespace ModificadorDeParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Calculadora.Soma(2, 2);
            int b = Calculadora.Soma(2, 2, 4);
            //int c = Calculadora.Soma(new int[] { 5, 5});
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}

using System;

namespace ModificadorParametroRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculadora.Triplicar(ref a);
            Console.WriteLine(a);
        }

    }
}

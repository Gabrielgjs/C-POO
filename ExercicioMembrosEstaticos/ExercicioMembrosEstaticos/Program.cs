using System;
using System.Globalization;

namespace ExercicioMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double dollarCotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar ? ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = ConversorDollar.DollarParaReal(compra, dollarCotacao);

            Console.WriteLine("Valor a ser pago em reais =  {0}", resultado.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}

using System;
using System.Globalization;
namespace VectorPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Nmae = name, Price = price };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            double media = soma / n;
            Console.WriteLine("Preço médio =" + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

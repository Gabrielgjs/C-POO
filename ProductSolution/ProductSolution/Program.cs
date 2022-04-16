using System;
using System.Globalization;

namespace ProductSolution
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Entre os dados do produto: ");

            Console.Write("Nome: ");    
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            

            Product p = new Product(nome, preco);

            /*
            Product p1 = new Product
            {
                Nome = "Celular",
                Preco = 700.00,
                Quantidade = 5
            };*/

            Console.WriteLine("Dados do produto: " + p );
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionaProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados : " + p);

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

        }
            
    }
}

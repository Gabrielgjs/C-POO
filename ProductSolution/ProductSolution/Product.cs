using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProductSolution
{
    class Product
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Product()
        {
        }
        public Product(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Product(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        //Propertie
        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1) {
                    _nome = value;  
                } 
            }
        }


        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionaProdutos(int quantidade)
        {
             Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
             Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                +", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

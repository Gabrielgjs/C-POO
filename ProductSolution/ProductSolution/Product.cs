﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProductSolution
{
    class Product
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
            return Nome
                +", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
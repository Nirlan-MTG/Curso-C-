using System.Globalization;

namespace Primeiro
{
    class Produto
    {
        private string vNome;
        public  double Preco { get; private set; }
        public  int Quantidade { get; private set; }

        public Produto(string pNome, double pPreco, int pQuantidade)
        {   // Construtor da classe 
            this.vNome = pNome;
            this.Preco = pPreco;
            this.Quantidade = pQuantidade;
        }
        public Produto(string pNome, double pPreco)
        {   // Construtor da classe - sobrecarga
            this.vNome = pNome;
            this.Preco = pPreco;
            this.Quantidade = 0;
        }

        // ------------------------------------------------------

        public string Nome
        {   // propertie 
            get { return this.vNome; }

            set
            {
                if (value != null && value.Length > 2)
                    this.vNome = value;
            }

        }

        // ------------------------------------------------------

        public double ValorTotalEstoque()
        {
            return this.Preco * this.Quantidade;
        }

        public void AdicionarEstoque(int pQuantidade)
        {
            this.Quantidade = this.Quantidade + pQuantidade;
        }

        public void RemoverEstoque(int pQuantidade)
        {
            this.Quantidade = this.Quantidade - pQuantidade;
        }


        public override string ToString()
        {
            return vNome
                + ", $ "
                + this.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + this.Quantidade
                + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

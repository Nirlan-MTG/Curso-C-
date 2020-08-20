using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string vNome     = Console.ReadLine();

            Console.Write("Preço: ");
            double vPreco    = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(vNome, vPreco);

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade a ser adcionada ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            p.AdicionarEstoque(qtd);
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade a ser removida do estoque: ");
            qtd = int.Parse(Console.ReadLine());

            p.RemoverEstoque(qtd);
            Console.WriteLine("Dados Atualizados: " + p);

        }
    }
}

using System;
using System.Globalization;

namespace ExemplosVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade: ");
            int vQtd = int.Parse(Console.ReadLine());
            Produto[] vVetor = new Produto[vQtd];
            double vSoma = 0;

            for (int i = 0; i < vQtd; i++)
            {
                string vNome  = Console.ReadLine();
                double vPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vVetor[i] = new Produto { Nome = vNome, Preco = vPreco };
                vSoma += vVetor[i].Preco;
            }

            double vMedia = vSoma / vQtd;
            Console.WriteLine("A media é: " + vMedia.ToString("F2", CultureInfo.InvariantCulture));

            // exemplo do uso do foreach
            string[] vVet = new string[] { "Maria", "Bob", "Alex" };
            foreach(string obj in vVet)
            {
                Console.WriteLine(obj);
            }


            /*          double[] vVetor = new double[vQtd];
                        double vSoma = 0;

                        for (int i = 0; i < vQtd; i++)
                        {
                            vVetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            vSoma += vVetor[i];
                        }

                        double vMedia = vSoma / vQtd;
                        Console.Write("A media é: " + vMedia.ToString("F2", CultureInfo.InvariantCulture));
            */
        }
    }
}

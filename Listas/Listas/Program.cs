using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vLista = new List<string>();
            vLista.Add("Maria");
            vLista.Add("Alex");
            vLista.Add("Bob");
            vLista.Add("Ana");
            vLista.Insert(2, "Marco");


            foreach (string vObj in vLista)
            {
                Console.WriteLine(vObj);
            }

            Console.WriteLine("Qtd: " + vLista.Count);

            string s1 = vLista.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro que começa com letra  A: " + s1);

            s1 = vLista.FindLast(x => x[0] == 'M');
            Console.WriteLine("Último que termina com a letra M: " + s1);

            // Matriz
            double[,] vMatriz = new double[2, 3]; // 2 linhas e 3 colunas
        }
    }
}

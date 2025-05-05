using System;
using System.Collections.Generic;
using ExercicioAvaliativo.Models;

namespace ExercicioAvaliativo.Exercicios
{
    public class Exercicio6_CadastroProduto
    {
        public static void Executar()
        {
            List<Produto> produtos = new();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Cadastro do produto {i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                produtos.Add(new Produto(nome, preco, quantidade));
            }

            Console.WriteLine("\nProdutos cadastrados:");
            foreach (var p in produtos)
            {
                Console.WriteLine($"{p.Nome} - R${p.Preco} x {p.Quantidade} = Total: R${p.ValorTotal()}");
            }
        }
    }
}

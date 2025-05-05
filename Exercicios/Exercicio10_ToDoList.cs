using System;
using System.Collections.Generic;

namespace ExercicioAvaliativo.Exercicios
{
    public class Exercicio10_ToDoList
    {
        public static void Executar()
        {
            // Lista para armazenar as tarefas
            List<string> tarefas = new();
            string opcao;

            do
            {
                // Exibe o menu de opções
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Adicionar tarefa");
                Console.WriteLine("2 - Listar tarefas");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // Adiciona uma nova tarefa à lista
                        Console.Write("Digite a tarefa: ");
                        string tarefa = Console.ReadLine();
                        tarefas.Add(tarefa);
                        break;
                    case "2":
                        // Lista todas as tarefas armazenadas
                        Console.WriteLine("\nTarefas:");
                        for (int i = 0; i < tarefas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tarefas[i]}");
                        }
                        break;
                    case "3":
                        // Encerra o programa
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        // Trata opções inválidas
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (opcao != "3"); // Continua exibindo o menu até que o usuário escolha sair
        }
    }
}

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
                Console.WriteLine("3 - Marcar tarefa como concluída");
                Console.WriteLine("4 - Sair");
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
                        Console.Write("Digite o número da tarefa que deseja marcar como concluída: ");
                        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= tarefas.Count)
                        {
                            // Adiciona "(Concluída)" ao final da tarefa
                            tarefas[numero - 1] = tarefas[numero - 1] + " (Concluída)";
                            Console.WriteLine("Tarefa marcada como concluída!");
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;
                    case "4":
                        // Encerra o programa
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        // Trata opções inválidas
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (opcao != "4"); // Continua exibindo o menu até que o usuário escolha sair
        }
    }
}
using System;

namespace ExercicioAvaliativo.Exercicios
{
    public class Exercicio4_ConversorTemperatura
    {
        public static void Executar()
        {
            int opcao;
            
            do
            {
                // Exibe o menu de opções para o usuário
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Celsius para Fahrenheit");
                Console.WriteLine("2 - Fahrenheit para Celsius");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                
                // Lê a opção escolhida pelo usuário
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // Caso o usuário escolha converter Celsius para Fahrenheit
                        Console.Write("Digite a temperatura em Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        
                        // Fórmula de conversão de Celsius para Fahrenheit
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        
                        // Exibe o resultado da conversão
                        Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
                        break;
                    case 2:
                        // Caso o usuário escolha converter Fahrenheit para Celsius
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        fahrenheit = double.Parse(Console.ReadLine());
                        
                        // Fórmula de conversão de Fahrenheit para Celsius
                        celsius = (fahrenheit - 32) * 5 / 9;
                        
                        // Exibe o resultado da conversão
                        Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
                        break;
                    case 3:
                        // Caso o usuário escolha sair do programa
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        // Caso o usuário insira uma opção inválida
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (opcao != 3); // Continua exibindo o menu até que o usuário escolha a opção 3 (sair)
        }
    }
}

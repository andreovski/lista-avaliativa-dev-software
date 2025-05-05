using System;

namespace ExercicioAvaliativo.Exercicios
{
    public class Exercicio9_JogoAdivinhacao
    {
        public static void Executar()
        {
            Random random = new();
            int numeroSecreto = random.Next(1, 101);
            int tentativas = 0;
            int chute = 0;

            Console.WriteLine("Adivinhe o número de 1 a 100!");

            while (chute != numeroSecreto)
            {
                Console.Write("Digite seu palpite: ");
                chute = int.Parse(Console.ReadLine());
                tentativas++;

                if (chute < numeroSecreto)
                    Console.WriteLine("Muito baixo!");
                else if (chute > numeroSecreto)
                    Console.WriteLine("Muito alto!");
                else
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
            }
        }
    }
}

using System;

namespace ExercicioAvaliativo.Exercicios
{
    public class Exercicio3_Fatorial
    {
        public static void Executar()
        {
            Console.Write("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            int resultado = 1;
            int i = numero;

            while (i > 1)
            {
                resultado *= i;
                i--;
            }

            Console.WriteLine($"Fatorial de {numero} é {resultado}");
        }
    }
}
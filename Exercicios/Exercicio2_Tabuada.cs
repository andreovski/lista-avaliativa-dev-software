using System;

namespace ExercicioAvaliativo.Exercicios
{
    public class Exercicio2_Tabuada
    {
        public static void Executar()
        {
            Console.Write("Digite um número para ver a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}

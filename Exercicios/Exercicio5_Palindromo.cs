using System;
using System.Text.RegularExpressions;

namespace ExercicioAvaliativo.Exercicios
{
    public class Exercicio5_Palindromo
    {
        public static void Executar()
        {
            Console.Write("Digite uma palavra ou frase: ");
            string entrada = Console.ReadLine();

            string textoLimpo = Regex.Replace(entrada.ToLower(), "[^a-z0-9]", "");
            char[] arr = textoLimpo.ToCharArray();
            Array.Reverse(arr);
            string reverso = new string(arr);

            if (textoLimpo == reverso)
                Console.WriteLine("É um palíndromo!");
            else
                Console.WriteLine("Não é um palíndromo.");
        }
    }
}

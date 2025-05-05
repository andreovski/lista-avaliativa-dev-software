using System;
using System.Text.RegularExpressions;

namespace ExercicioAvaliativo.Exercicios
{
    public class Exercicio1_ValidadorSenha
    {
        public static void Executar()
        {
            Console.Write("Digite uma senha: ");
            string senha = Console.ReadLine();

            if (ValidarSenhaForte(senha))
            {
                Console.WriteLine("Senha forte!");
            }
            else
            {
                Console.WriteLine("Senha fraca. A senha deve conter no mínimo:");
                Console.WriteLine("- 8 caracteres");
                Console.WriteLine("- Uma letra maiúscula");
                Console.WriteLine("- Um número");
                Console.WriteLine("- Um caractere especial (!, @, #, etc.)");
            }
        }

        private static bool ValidarSenhaForte(string senha)
        {
            if (senha.Length < 8) return false;
            if (!Regex.IsMatch(senha, "[A-Z]")) return false;
            if (!Regex.IsMatch(senha, "[0-9]")) return false;
            if (!Regex.IsMatch(senha, "[!@#\\$%\\^&\\*]")) return false;
            return true;
        }
    }
}

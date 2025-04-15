using System;

class Program {
    static void Main() {
        // EX01
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Bem-vindo!");

        // EX02
        Console.WriteLine("Digite seu ano de nascimento:");
        int anoNascimento = int.Parse(Console.ReadLine());
        int anoAtual = 2024;
        int idade = anoAtual - anoNascimento;
        Console.WriteLine($"Você tem {idade} anos.");

        // EX03
        Console.WriteLine("Digite a primeira nota:");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota:");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota:");
        double nota3 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"A média aritmética das notas é: {media:F2}");

        // EX04
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2) {
            Console.WriteLine($"O maior número é: {numero1}");
        } else if (numero2 > numero1) {
            Console.WriteLine($"O maior número é: {numero2}");
        } else {
            Console.WriteLine("Os números são iguais.");
        }

        // EX05
        Console.WriteLine("Digite um número para verificar se é par ou ímpar:");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0) {
            Console.WriteLine("O número é par.");
        } else {
            Console.WriteLine("O número é ímpar.");
        }
    }
}
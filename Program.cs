// See https://aka.ms/new-console-template for more information

using ExercicioPOOMediaAluno;

Aluno aluno = new Aluno();

Console.WriteLine("Digite o nome do Aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno: ");
aluno.Nota1 = double.Parse(Console.ReadLine());
aluno.Nota2 = double.Parse(Console.ReadLine());
aluno.Nota3 = double.Parse(Console.ReadLine());

Console.WriteLine($"NOTA FINAL: {aluno.CalcularNotaFinal()}");

switch (aluno.Aprovado)
{
    case true:
        Console.WriteLine("APROVADO");
        break;
    case false:
        Console.WriteLine("REPROVADO");
        Console.WriteLine($"FALTARAM {(60 - aluno.CalcularNotaFinal())} PONTOS");
        break;
}
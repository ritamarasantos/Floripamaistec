string[] nomeAlunos = new string[5];
decimal[] mediaAlunos = new decimal[5];

// Média e nome dos alunos
for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o nome do {i + 1} aluno: ");
    nomeAlunos[i] = Console.ReadLine();

    Console.Write($"Digite a média do {i + 1} aluno: ");
    mediaAlunos[i] = decimal.Parse(Console.ReadLine());
}

// verifica as médias e exibe se o aluno está aprovado ou não
for (int i = 0; i < 5; i++)
{
    if (mediaAlunos[i] >= 6)
    {
        Console.WriteLine($"O aluno {nomeAlunos[i]} está APROVADO");
    }
    else
    {
        Console.WriteLine($"O aluno {nomeAlunos[i]} está REPROVADO");
    }
}

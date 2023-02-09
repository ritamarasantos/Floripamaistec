// Separador de números ímpares e pares

List<int> numerosPares = new List<int>();
List<int> numerosImpares = new List<int>();

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1} número: ");
    int num = int.Parse(Console.ReadLine());

    // verifica se o número é ímpar ou par
    if (num % 2 == 0)
    {
        numerosPares.Add(num);
    }
    else
    {
        numerosImpares.Add(num);
    }
}

//Ordem crescente
numerosImpares.Sort();
numerosPares.Sort();

// Sum() faz a soma dos números de uma lista
Console.WriteLine($"A lista de números ímpares possui {numerosImpares.Count()} números e a soma deles é igual a {numerosImpares.Sum()}");
Console.WriteLine($"A lista de números pares possui {numerosPares.Count()} números e a soma deles é igual a {numerosPares.Sum()}");

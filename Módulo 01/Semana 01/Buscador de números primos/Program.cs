// Buscador de números primos

int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{

    int contador = 1;

    for (int n = 1; n < numeros[i]; n++)
    {
        if (numeros[i] % n == 0)
        {
            contador = contador + 1;
        }
    }

    if (contador == 2)
    {
        Console.WriteLine($"O número {numeros[i]} é um número primo. Ela está na posição {i + 1} do Array de números.");
    }
}


int n;
int x = 1, y = 0, z = 0;

// lê a quantidade de número da sequência a ser exibidos
string number = Console.ReadLine();

n = int.Parse(number);

// cria a sequência de Fibonacci
for (int i = 0; i < n; i++)
{
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}
Console.ReadLine();



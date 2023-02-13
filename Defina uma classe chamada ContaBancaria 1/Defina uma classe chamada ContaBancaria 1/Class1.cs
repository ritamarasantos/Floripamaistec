
//[M1S02] Ex 3 - Defina uma classe chamada ContaBancaria//

namespace Classes;
public class ContaBancaria
{
    public int numero;
    public int agencia;
    public string nomeTitular;
    public decimal saldo = 0;
    public TipoContaEnum tipoConta;
}

//[M1S02] Ex 4 - Crie um método para depositar valores//

public void Depositar(decimal valor)
{
    if(valor <= 0)
    {
        console.WriteLine("O valor precisa ser maior que 0!");
    }
    else if(valor > saldo)
    {
        console.writeline("O valor é maior que o saldo atual!");
    }

    
}




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
 //[M1S02] Ex 5 - Crie um método para exibir o saldo atual da conta//
    else if (valor > saldo)
    {
        console.writeline("O valor é maior que o saldo atual!");
    else
        {
            saldo = saldo - valor;
        }
 //[M1S02] Ex 6 - Crie um método para exibir o saldo atual da conta
        
    }
     public void ExibirSaldo()
    {
        console.writeline("O saldo atual da conta é de R$ {saldo}");
    }
}



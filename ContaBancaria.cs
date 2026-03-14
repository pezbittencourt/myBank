public class ContaBancaria
{
    public string Numero { get; private set; }
    public decimal Saldo { get; private set; }
    public Cliente Titular { get; private set; }

    public ContaBancaria(string numeroConta, decimal saldoInicial, Cliente titular)
    {
        Numero = numeroConta;
        Saldo = saldoInicial;
        Titular = titular;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("O valor depositado precisa ser positivo");
            return;
        }

        Saldo += valor;

        Console.WriteLine($"Depósito de R$ {valor} na conta {Numero} realizado com sucesso!");
    }

    public void Sacar(decimal valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente");
            return;
        }

        Saldo -= valor;
    }
}
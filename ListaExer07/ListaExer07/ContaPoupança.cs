public class ContaPoupanca : ContaBancaria
{
    public double juros = 0.5;

    public void CalJuros()
    {
        Saldo -= Saldo * juros;
        Console.WriteLine($"Juros: {Saldo}");
    }
}
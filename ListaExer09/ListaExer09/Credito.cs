public class Credito : IMetodoPagamento
{
    public void Pagamento(double valor)
    {
        Console.WriteLine($"Pagamento de R${valor} feito com cartao de credito");
    }

    public string StatusPagamento()
    {
        return "Pagamento foi aprovado.";
    }
}
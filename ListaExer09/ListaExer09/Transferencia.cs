public class Transferencia : IMetodoPagamento
{
    public void Pagamento(double valor)
    {
        Console.WriteLine($"Pagamento de R${valor} feito por transferencia bancária");
    }

    public string StatusPagamento()
    {
        return "Pagamento confirmado";
    }
}
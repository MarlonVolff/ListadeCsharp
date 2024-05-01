public class Boleto : IMetodoPagamento
{
    public void Pagamento(double valor)
    {
        Console.WriteLine($"Pagamento de R${valor} feito com boleto!");
    }

    public string StatusPagamento()
    {
        return "O pagamento feito corretamente";
    }
}
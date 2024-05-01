 IMetodoPagamento geucimar = new Credito();
    geucimar.Pagamento(300);
    Console.WriteLine(geucimar.StatusPagamento());

IMetodoPagamento Marlon = new Boleto();
    Marlon.Pagamento(400);
    Console.WriteLine(Marlon.StatusPagamento());

IMetodoPagamento escobar = new Transferencia();
    escobar.Pagamento(500);
    Console.WriteLine(escobar.StatusPagamento());

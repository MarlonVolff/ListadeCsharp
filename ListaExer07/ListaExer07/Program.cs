ContaBancaria contaa = new ContaBancaria();
ContaCorrente contaCorrente = new ContaCorrente();
ContaPoupanca contaPoupança = new ContaPoupanca();
ContaEmpresarial contaEmpresarial1 = new ContaEmpresarial();
ContaEmpresarial contaEmpresarial2 = new ContaEmpresarial();

contaPoupança.NumConta = 1534;
contaPoupança.Saldo = 1500;

Console.WriteLine("Conta Poupança");
Console.WriteLine("Número da conta: " + contaPoupança.NumConta);
Console.WriteLine("Saldo da conta: " + contaPoupança.Saldo);

contaPoupança.CalJuros();

Console.WriteLine("=========================================================");

contaEmpresarial1.NumConta = 1010;
contaEmpresarial2.Saldo = 200;

Console.WriteLine("Conta Empresarial 1");
Console.WriteLine("Número da conta: " + contaEmpresarial1.NumConta);
Console.WriteLine("Saldo Mínimo: " + contaEmpresarial2.saldoMin);
Console.WriteLine("Saldo da conta: " + contaEmpresarial2.Saldo);

contaEmpresarial2.VerificarSaldo();

//Uso do Chatgpt para dar dicas de como completar e funcionar...


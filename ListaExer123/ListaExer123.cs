// QUESTÃO 1
// RESPOSTA:
// Herança em Orientação a Objetos ela faz basicamente puxar 
// propriedades de uma classe superior para outra classe. 
// Então ela é ultiliza para uma classe onde vão servir em outra, 
// ou seja, uma classe deriva as propriedades de outra. 

// public class Funcionario
// {
//     public string Nome { get; set; }
//     public string Cargo { get; set; }
//     public double Salario { get; set; }

//     public Funcionario(string nome, string cargo, double salario)
//     {
//         Nome = nome;
//         Cargo = cargo;
//         Salario = salario;
//     }

//     public virtual void Apresentar()
//     {
//         Console.WriteLine($"Nome: {Nome}, Cargo: {Cargo}, Salário: {Salario}");
//     }
// }

// public class Gerente : Funcionario
// {
//     public string Departamento { get; set; }

//     public Gerente(string nome, double salario, string departamento) : base(nome, "Gerente", salario)
//     {
//         Departamento = departamento;
//     }

//     public override void Apresentar()
//     {
//         base.Apresentar();
//         Console.WriteLine($"Departamento: {Departamento}");
//     }
// }

// public class Desenvolvedor : Funcionario
// {
//     public string Linguagem { get; set; }

//     public Desenvolvedor(string nome, double salario, string linguagem) : base(nome, "Desenvolvedor", salario)
//     {
//         Linguagem = linguagem;
//     }

//     public override void Apresentar()
//     {
//         base.Apresentar();
//         Console.WriteLine($"Linguagem: {Linguagem}");
//     }
// }
//     Funcionario funcionario1 = new Funcionario("João", "Analista", 3000);
//     Gerente gerente1 = new Gerente("Maria", 5000, "TI");
//     Desenvolvedor dev1 = new Desenvolvedor("Marlon", 7000, "C#");
//     funcionario1.Apresentar();
//     gerente1.Apresentar();
//     dev1.Apresentar();


//QUESTAO 2:
//Em C#, as interfaces são declaradas usando a palavra interface. Uma classe pode implementar uma ou várias interfaces,
//definem um conjunto de metodos e propriedades que uma classe deve implementando diferentes classes de maneiras 
//específicas.

// public interface Ipagamento
// {
//     void Exibir(string tipo, double valor, int NumConta, string NomeConta);
// }

// public class Nubank : Transacao
// {
//     public double Saldo { get; set; }

//     public void NovoSaldo(Transacao valor)
//     {
//         if (valor.Tipo == "Pagar")
//         {
//             Saldo -= valor.Valor;
//         }
//         else if (valor.Tipo == "Reembolsar")
//         {
//             Saldo += valor.Valor;
//         }
//     }

// }
// public class Transacao : Ipagamento
// {
//     public string Tipo { get; set; }
//     public double Valor { get; set; }
//     public int NumConta { get; set; }

//     public String NomeConta {get; set;}

//     public void Exibir(string Tipo, double valor, int NumConta, string NomeConta){
//         Console.WriteLine($"Tipo (Pagar/Reembolsar): {Tipo}");
//         Console.WriteLine($"Valor de transferencia: {valor}");
//         Console.WriteLine($"Numero da Conta: {NumConta}");
//         Console.WriteLine($"Nome da Conta: {NomeConta}");
//     }

// }

// Nubank bank = new Nubank();
// Transacao transacao1 = new Transacao();
// bank.Saldo = 10;
// Console.WriteLine("Saldo Antes: " + inter.Saldo);

// transacao1.Valor = 20;
// transacao1.Tipo = "Pagar";
// transacao1.NumConta = 1234;
// transacao1.NomeConta = "Marlon";

// bank.NovoSaldo(transacao1);

// transacao1.Exibir(transacao1.Tipo, transacao1.Valor, transacao1.NumConta, transacao1.NomeConta);

// Console.WriteLine("Saldo em conta: " + bank.Saldo);

//QUESTAO3:
//a sobreposição ela sobrescreve o método da classe mãe para classe mais específica e a sobrecarga 
//é feito para utilizar o mesmo método várias vezes mas utilizando parâmetros diferentes. 

//SOBREPOSICAO:
// public class Carro
// {
//     public void Acelerar()
//     {
//         Console.WriteLine("Carro acelerando...");
//     }
// }

// public class CarroEsportivo : Carro
// {
//     public new void Acelerar() //O CHATGPT DEU UMA OPCAO DE DAR um novo public void da msm variavel.
//     {
//         Console.WriteLine("Carro esportivo acelerando rapidamente...");
//     }
// }

// Carro carro = new Carro();
// CarroEsportivo carroEsportivo = new CarroEsportivo();
// carro.Acelerar();              
// carroEsportivo.Acelerar();  

//SOBRECARGA:
// public class Carro
// {
//     public void Acelerar()
//     {
//         Console.WriteLine("O carro acelera");
//     }
//     public void Acelerar(int velocidade)
//     {
//         Console.WriteLine($"Carro acelerando a {velocidade} km/h...");
//     }
// }
// Carro carro = new Carro();
// carro.Acelerar();          
// carro.Acelerar(100);          



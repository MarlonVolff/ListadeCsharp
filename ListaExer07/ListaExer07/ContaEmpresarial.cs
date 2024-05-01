public class ContaEmpresarial : ContaBancaria
{
    public double saldoMin = 1000;

    public void VerificarSaldo(){
        if(Saldo < saldoMin){
            Console.WriteLine("Saldo abaixo do minimo");
        }
        else if (Saldo >= saldoMin){
            Console.WriteLine("Saldo suficiente");
        }
    }
  
}
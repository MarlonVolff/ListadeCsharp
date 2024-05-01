public class Filme
{
    public string Titulo { set; get; }
    public string Genero { set; get; }
    public float Duracao { set; get; }
    public bool Disponivel { set; get; }

    public Filme(string titulo, string genero, float duracao)
    {
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
        Disponivel = true;
    }

    public void LocacaoFilme(){

      if(Disponivel){
        Disponivel = false;
        Console.WriteLine($"O filme {Titulo} foi alugado com sucesso!");
      }else{
        Console.WriteLine($"O filme {Titulo} não esta disponivel no momento!");
      }
    }

    public void Devolucao(){
      if(!Disponivel){
        Disponivel = true;
        Console.WriteLine("Filme devolvido!");
      }else{
        Console.WriteLine("Filme devolvido com sucesso!");
      }
    }
    
    public void Estado()
    {
        Console.WriteLine("Este filme está " + Disponivel + " para locação.");
    }
}
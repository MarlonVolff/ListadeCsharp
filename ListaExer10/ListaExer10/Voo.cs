public class Voo : IReserva{

    public string origem {get; set;}

    public string destino {get; set;}

    public string data {get; set;}

    public Voo( string origem, string destino, string data){

        this.origem = origem;
        this.destino = destino;
        this.data = data;
        
    }
}

public class VooGrande : Voo {
    
        public VooGrande(string origem, string destino, string data) : base(origem, destino, data)
        {
        }

        public void reservar()
        {
            Console.WriteLine("Reserva de um grupo grande efetuada com sucesso!");
        }

        public void cancelar()
        {
            Console.WriteLine("Reserva de um grupo grande com sucesso!");
        }

        public  void status()
        {
            Console.WriteLine("Voo com grupo grande");
            Console.WriteLine("origem: {origem}");
            Console.WriteLine("destino: {destino}, ");
            Console.WriteLine("data: {data}, ");

        }

}

public class VooRegular : Voo, IReserva{

        public VooRegular(string origem, string destino, string data) : base(origem, destino, data)
        {
        }

        public void reservar()
        {
            Console.WriteLine("Reserva classe econômica efetuada com sucesso!");
        }

        public void cancelar()
        {
            Console.WriteLine("Reserva classe econômica cancelada com sucesso!");
        }

        public  void status()
        {
            Console.WriteLine("Voo Economico");
            Console.WriteLine("origem: {origem}");
            Console.WriteLine("destino: {destino}, ");
            Console.WriteLine("data: {data}, ");

        }

    
    
}

public class VooUpgrade : Voo , IReserva{
    
        public VooUpgrade(string origem, string destino, string data) : base(origem, destino, data)
        {
        }

        public void reservar()
        {
            Console.WriteLine("Reserva na primeira classe efetuada com sucesso!");
        }

        public void cancelar()
        {
            Console.WriteLine("Reserva na primeira classe com sucesso!");
        }

        public  void status()
        {
            Console.WriteLine("Voo primeira classe");
            Console.WriteLine("origem: {origem}");
            Console.WriteLine("destino: {destino}, ");
            Console.WriteLine("data: {data}, ");


        }

}

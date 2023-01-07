namespace PizzariaCSharp.Entities
{
    public class Pedido
    {        
        private readonly double TaxaEntrega = 10.0;
        public int Id { get; set; }
        public Cliente Cliente { get; private set; }
        public DateTime Data { get; private set; }
        public List<Pizza> Pizzas { get; private set; }
        public List<Bebida> Bebidas { get; private set; }        
        
        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Pizzas = new();
            Bebidas = new();
        }

        public Pedido AdicionarPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
            return this;
        }

        public Pedido AdicionarBebida(Bebida bebida)
        {
            Bebidas.Add(bebida);
            return this;
        }

        public double CalcularValorPedido()
        {
            return Pizzas.Sum(p => p.Valor) + TaxaEntrega;
        }

        public Pedido FinalizarPedido()
        {
            Data = DateTime.Now;
            return this;
        }
    }
}
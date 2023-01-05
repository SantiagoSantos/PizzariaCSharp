namespace PizzariaCSharp.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; private set; }
        public DateTime Data { get; private set; }
        public List<Pizza> Pizzas { get; private set; }
        public List<Bebida> Name { get; private set; }
        
    }
}
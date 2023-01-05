namespace PizzariaCSharp.Entities
{
    public class Bebida
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        
        public Bebida(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

    }
}
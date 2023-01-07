namespace PizzariaCSharp.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public List<Endereco> Enderecos { get; private set; }        
        
        public Cliente(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
            Enderecos = new();
        }
    }
}
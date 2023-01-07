namespace PizzariaCSharp.Entities
{
    public class Sabor
    {
        public int Id { get; set; }
        public string Descricao { get; private set; }
        
        public Sabor(string descricao, string observacao)
        {
            Descricao = descricao;
        }
    }
}
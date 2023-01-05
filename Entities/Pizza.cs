using PizzariaCSharp.Enums;

namespace PizzariaCSharp.Entities
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public ETamanho Tamanho { get; private set; }
        public EBorda Borda { get; private set; }
        public List<Item> Composicao { get; private set; }
        public double Valor { get; private set; }
        
    }
}
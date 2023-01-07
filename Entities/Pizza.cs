using PizzariaCSharp.Enums;

namespace PizzariaCSharp.Entities
{
    public class Pizza
    {
        public int Id { get; set; }
        public ETamanho Tamanho { get; private set; }
        public EBorda Borda { get; private set; }
        public List<Sabor> Sabores { get; private set; }
        public double Valor { get; private set; }

        public Pizza(ETamanho tamanho, EBorda borda, double valor, List<Sabor> sabores)
        {
            Tamanho = tamanho;
            Borda = borda;
            Valor = valor;
            Sabores = sabores;
        }
        
    }
}
using PizzariaCSharp.Entities;
using PizzariaCSharp.Exceptions;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PedidoRepository : IGenericRepository<Pedido>
    {
        private List<Pedido> _pedidos;
        private int _UltimoId = 0;

        public Pedido Adicionar(Pedido pedido)
        {
            _UltimoId++;
            pedido.Id = _UltimoId;

            _pedidos.Add(pedido);

            return pedido;
        }

        public Pedido Atualizar(Pedido pedido)
        {
            Remover(pedido.Id);
            _pedidos.Add(pedido);

            return pedido;
        }

        public Pedido ObterPorId(int id)
        {
            return _pedidos
                    .Where(b => b.Id == id)
                    .FirstOrDefault();
        }

        public List<Pedido> ObterTodos()
        {
            return _pedidos;
        }

        public void Remover(int id)
        {
            var obj = ObterPorId(id);

            if (obj == null) throw new DataNotFoundException();

            _pedidos.Remove(obj);
        }
    }
}
using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Entities;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class PedidoController : IGenericController<Pedido>
    {
        private IGenericRepository<Pedido> _repository;

        public PedidoController(IGenericRepository<Pedido> repository)
        {
            _repository = repository;
        }

        public Pedido Adicionar(Pedido pedido)
        {
            return _repository.Adicionar(pedido);
        }

        public Pedido Atualizar(int id, Pedido pedido)
        {
            pedido.Id = id;
            return _repository.Atualizar(pedido);
        }

        public Pedido ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public List<Pedido> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }
}
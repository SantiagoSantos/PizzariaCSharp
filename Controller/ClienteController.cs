using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Entities;
using PizzariaCSharp.Repository.Interfaces;
namespace PizzariaCSharp.Controller
{
    public class ClienteController : IGenericController<Cliente>
    {
        private IGenericRepository<Cliente> _repository;

        public ClienteController(IGenericRepository<Cliente> repository)
        {
            _repository = repository;
        }

        public Cliente Adicionar(Cliente Cliente)
        {
            return _repository.Adicionar(Cliente);
        }

        public Cliente Atualizar(int id, Cliente Cliente)
        {
            Cliente.Id = id;
            return _repository.Atualizar(Cliente);
        }

        public Cliente ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public List<Cliente> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }
}
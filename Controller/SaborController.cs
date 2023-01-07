using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Entities;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class SaborController : IGenericController<Sabor>
    {
        private IGenericRepository<Sabor> _repository;

        public SaborController(IGenericRepository<Sabor> repository)
        {
            _repository = repository;
        }

        public Sabor Adicionar(Sabor sabor)
        {
            return _repository.Adicionar(sabor);
        }

        public Sabor Atualizar(int id, Sabor sabor)
        {
            sabor.Id = id;
            return _repository.Atualizar(sabor);
        }

        public Sabor ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public List<Sabor> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }
}
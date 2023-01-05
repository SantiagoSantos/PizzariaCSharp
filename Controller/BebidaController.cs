using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Entities;
using PizzariaCSharp.Repository.Interfaces;
namespace PizzariaCSharp.Controller
{
    public class BebidaController : IGenericController<Bebida>
    {
        private IGenericRepository<Bebida> _repository;
        
        public BebidaController(IGenericRepository<Bebida> repository)
        {
            _repository = repository;
        }

        public List<Bebida> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public Bebida ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public Bebida Adicionar(Bebida bebida)
        {
            return _repository.Adicionar(bebida);
        }

        public Bebida Atualizar(int id, Bebida bebida)
        {
            bebida.Id = id;
            return _repository.Atualizar(bebida);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }

    
}
using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Repository.Interfaces;
using PizzariaCSharp.Entities;

namespace PizzariaCSharp.Controller
{
    public class PizzaController : IGenericController<Pizza>
    {
        private IGenericRepository<Pizza> _repository;

        public PizzaController(IGenericRepository<Pizza> repository)
        {
            _repository = repository;
        }

        public Pizza Adicionar(Pizza pizza)
        {
            return _repository.Adicionar(pizza);
        }

        public Pizza Atualizar(int id, Pizza pizza)
        {
            pizza.Id = id;
            return _repository.Atualizar(pizza);
        }

        public Pizza ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public List<Pizza> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }
}
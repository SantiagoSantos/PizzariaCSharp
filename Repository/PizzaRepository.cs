using PizzariaCSharp.Entities;
using PizzariaCSharp.Exceptions;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PizzaRepository : IGenericRepository<Pizza>
    {
        private List<Pizza> _pizzas;
        private int _UltimoId = 0;

        public Pizza Adicionar(Pizza pizza)
        {
            _UltimoId++;
            pizza.Id = _UltimoId;

            _pizzas.Add(pizza);

            return pizza;
        }

        public Pizza Atualizar(Pizza pizza)
        {
            Remover(pizza.Id);
            _pizzas.Add(pizza);

            return pizza;
        }

        public Pizza ObterPorId(int id)
        {
            return _pizzas
                    .Where(b => b.Id == id)
                    .FirstOrDefault();
        }

        public List<Pizza> ObterTodos()
        {
            return _pizzas;
        }

        public void Remover(int id)
        {
            var obj = ObterPorId(id);

            if (obj == null) throw new DataNotFoundException();

            _pizzas.Remove(obj);
        }
    }
}
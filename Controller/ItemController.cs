using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Entities;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Controller
{
    public class ItemController : IGenericController<Item>
    {
        private IGenericRepository<Item> _repository;

        public ItemController(IGenericRepository<Item> repository)
        {
            _repository = repository;
        }

        public Item Adicionar(Item item)
        {
            return _repository.Adicionar(item);
        }

        public Item Atualizar(int id, Item item)
        {
            item.Id = id;
            return _repository.Atualizar(item);
        }

        public Item ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public List<Item> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }
}
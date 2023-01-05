using PizzariaCSharp.Entities;
using PizzariaCSharp.Exceptions;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class ItemRepository : IGenericRepository<Item>
    {
        private List<Item> _items;
        private int _UltimoId = 0;
        
        public ItemRepository()
        {
            _items = new();
        }

        public Item Adicionar(Item item)
        {
            _UltimoId++;
            item.Id = _UltimoId;

            _items.Add(item);

            return item;
        }

        public Item Atualizar(Item item)
        {
            Remover(item.Id);
            _items.Add(item);

            return item;
        }

        public Item ObterPorId(int id)
        {
            return _items
                    .Where(b => b.Id == id)
                    .FirstOrDefault();
        }

        public List<Item> ObterTodos()
        {
            return _items;
        }

        public void Remover(int id)
        {
            var obj = ObterPorId(id);

            if (obj == null) throw new DataNotFoundException();

            _items.Remove(obj);
        }
    }
}
using PizzariaCSharp.Entities;
using PizzariaCSharp.Exceptions;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class SaborRepository : IGenericRepository<Sabor>
    {
        private List<Sabor> _sabores = new();
        private int _UltimoId = 0;
        
        public SaborRepository()
        {
            _sabores = new();
        }

        public Sabor Adicionar(Sabor sabor)
        {
            _UltimoId++;
            sabor.Id = _UltimoId;

            _sabores.Add(sabor);

            return sabor;
        }

        public Sabor Atualizar(Sabor sabor)
        {
            Remover(sabor.Id);
            _sabores.Add(sabor);

            return sabor;
        }

        public Sabor ObterPorId(int id)
        {
            return _sabores
                    .Where(b => b.Id == id)
                    .FirstOrDefault();
        }

        public List<Sabor> ObterTodos()
        {
            return _sabores;
        }

        public void Remover(int id)
        {
            var obj = ObterPorId(id);

            if (obj == null) throw new DataNotFoundException();

            _sabores.Remove(obj);
        }
    }
}
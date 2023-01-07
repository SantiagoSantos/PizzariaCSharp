using PizzariaCSharp.Entities;
using PizzariaCSharp.Exceptions;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class BebidaRepository : IGenericRepository<Bebida>
    {
        private List<Bebida> _Bebidas = new();
        private int _UltimoId = 0;
        
        public BebidaRepository()
        {
            _Bebidas = new();
        }

        public List<Bebida> ObterTodos()
        {
            return _Bebidas;
        }

        public Bebida ObterPorId(int id)
        {
            return _Bebidas
                    .Where(b => b.Id == id)
                    .FirstOrDefault();
        }

        public Bebida Adicionar(Bebida bebida)
        {
            _UltimoId++;
            bebida.Id = _UltimoId;

            _Bebidas.Add(bebida);

            return bebida;
        }

        public void Remover(int id)
        {
            var bebida = ObterPorId(id);

            if (bebida == null) throw new DataNotFoundException();

            _Bebidas.Remove(bebida);
        }

        public Bebida Atualizar(Bebida bebida)
        {
            Remover(bebida.Id);
            _Bebidas.Add(bebida);

            return bebida;
        }

        
    }
}
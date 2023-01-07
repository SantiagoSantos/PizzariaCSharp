using PizzariaCSharp.Entities;
using PizzariaCSharp.Exceptions;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class ClienteRepository : IGenericRepository<Cliente>
    {
        private List<Cliente> _clientes = new();
        private int _UltimoId = 0;
        
        public ClienteRepository()
        {
            _clientes = new();
        }

        public Cliente Adicionar(Cliente cliente)
        {
            _UltimoId++;
            cliente.Id = _UltimoId;

            _clientes.Add(cliente);

            return cliente;
        }

        public Cliente Atualizar(Cliente cliente)
        {
            Remover(cliente.Id);
            _clientes.Add(cliente);

            return cliente;
        }

        public Cliente ObterPorId(int id)
        {
            return _clientes
                    .Where(b => b.Id == id)
                    .FirstOrDefault();
        }

        public List<Cliente> ObterTodos()
        {
            return _clientes;
        }

        public void Remover(int id)
        {
            var obj = ObterPorId(id);

            if (obj == null) throw new DataNotFoundException();

            _clientes.Remove(obj);
        }
    }
}
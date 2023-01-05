using PizzariaCSharp.Entities;

namespace PizzariaCSharp.Repository.Interfaces
{
    public interface IGenericRepository<T>
    {
        List<T> ObterTodos();

        T ObterPorId(int id);

        T Adicionar(T objeto);

        void Remover(int id);

        T Atualizar(T objeto);
    }
}
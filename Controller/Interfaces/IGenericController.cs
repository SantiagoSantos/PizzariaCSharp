namespace PizzariaCSharp.Controller.Interfaces
{
    interface IGenericController<T>
    {
        List<T> ObterTodos();

        T ObterPorId(int id);

        T Adicionar(T objeto);

        T Atualizar(int id, T objeto);

        void Remover(int id);
    }
}
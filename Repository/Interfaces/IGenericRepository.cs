
namespace PizzariaCSharp.Repository.Interfaces
{
    /// <summary>
    /// Interface de um repositório genérico de um CRUD simples
    /// </summary>
    /// <typeparam name="T">Tipo da entidade a ser persistida</typeparam>
    public interface IGenericRepository<T>
    {
        /// <summary>
        /// Método que retorna a lista completa de uma entidade
        /// </summary>
        /// <returns>List<T></returns>
        List<T> ObterTodos();

        /// <summary>
        /// Método que obtém um objeto através do ID
        /// </summary>
        /// <param name="id">ID da entidade a ser encontrada</param>
        /// <returns>Retorna o objeto encontrado pelo ID</returns>
        T ObterPorId(int id);

        /// <summary>
        /// Método que adiciona uma entidade no banco de dados
        /// </summary>
        /// <param name="objeto">Objeto to tipo T</param>
        /// <returns>Retorna a entidade adicionada</returns>
        T Adicionar(T objeto);

        /// <summary>
        /// Remove a entidade do banco de dados
        /// </summary>
        /// <param name="id">ID do objeto a ser excluído</param>
        void Remover(int id);

        /// <summary>
        /// Método que atualiza os dados do objeto no banco de dados
        /// </summary>
        /// <param name="objeto">Entidade do tipo T</param>
        /// <returns>Retorna o objeto atualizado</returns>
        T Atualizar(T objeto);
    }
}
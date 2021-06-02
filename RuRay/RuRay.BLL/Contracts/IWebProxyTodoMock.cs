using System.Collections.Generic;
using System.Threading.Tasks;
using RuRay.BLL.Models;

namespace RuRay.BLL.Contracts
{
    /// <summary>
    /// Defines the <see cref="ITodosMockProxyService" />.
    /// </summary>
    public interface ITodosMockProxyService
    {
        /// <summary>
        /// The GetTodos.
        /// </summary>
        /// <returns>The <see cref="Task{IEnumerable{Todo}}"/>.</returns>
        Task<IEnumerable<Todo>> GetTodos();

        /// <summary>
        /// The GetTodoById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Todo}"/>.</returns>
        Task<Todo> GetTodoById(int id);
    }
}

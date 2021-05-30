using RuRay.BLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RuRay.BLL.Contracts
{
    public interface ITodosMockProxyService
    {
        Task<IEnumerable<Todo>> GetTodos();
        Task<Todo> GetTodoById(int id);
    }
}

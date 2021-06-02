using System.Collections.Generic;
using System.Threading.Tasks;
using RuRay.BLL.Models;

namespace RuRay.BLL.Contracts
{
    public interface ITodosMockProxyService
    {
        Task<IEnumerable<Todo>> GetTodos();
        Task<Todo> GetTodoById(int id);
    }
}

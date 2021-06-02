using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using RuRay.BLL.Contracts;
using RuRay.BLL.Models;

namespace RuRay.BLL
{
    /// <summary>
    /// Defines the <see cref="TodosMockProxyService" />.
    /// </summary>
    public class TodosMockProxyService : ITodosMockProxyService, IHealthCheck
    {
        /// <summary>
        /// Gets the _client.
        /// </summary>
        private HttpClient _client { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TodosMockProxyService"/> class.
        /// </summary>
        /// <param name="client">The client<see cref="HttpClient"/>.</param>
        public TodosMockProxyService(HttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// The GetTodos.
        /// </summary>
        /// <returns>The <see cref="Task{IEnumerable{Todo}}"/>.</returns>
        public async Task<IEnumerable<Todo>> GetTodos()
        {
            var response = await _client.GetAsync("");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var result = await response.Content.ReadAsAsync<IEnumerable<Todo>>();
            return result;
        }

        /// <summary>
        /// The GetTodoById.
        /// </summary>
        /// <param name="id">The id<see cref="int"/>.</param>
        /// <returns>The <see cref="Task{Todo}"/>.</returns>
        public async Task<Todo> GetTodoById(int id)
        {
            var response = await _client.GetAsync($"{id}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var result = await response.Content.ReadAsAsync<Todo>();
            return result;
        }

        /// <summary>
        /// The CheckHealthAsync.
        /// </summary>
        /// <param name="context">The context<see cref="HealthCheckContext"/>.</param>
        /// <param name="cancellationToken">The cancellationToken<see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{HealthCheckResult}"/>.</returns>
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            try
            {
                var response = await _client.SendAsync(new HttpRequestMessage(HttpMethod.Head, _client.BaseAddress));
                response.EnsureSuccessStatusCode();
                return HealthCheckResult.Healthy();
            }
            catch
            {
                return HealthCheckResult.Unhealthy();
            }
        }
    }
}

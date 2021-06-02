using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using RuRay.BLL.Contracts;
using RuRay.BLL.Models;

namespace RuRay.BLL
{
    public class TodosMockProxyService : ITodosMockProxyService, IHealthCheck
    {
        private HttpClient _client { get; }

        public TodosMockProxyService(HttpClient client)
        {
            _client = client;
        }

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

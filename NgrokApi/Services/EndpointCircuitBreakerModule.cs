
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointCircuitBreakerModule
    {
        private IApiHttpClient apiClient;

        internal EndpointCircuitBreakerModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointCircuitBreaker> Replace(EndpointCircuitBreakerReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointCircuitBreakerReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointCircuitBreaker>(
                  path: $"endpoint_configurations/{arg.Id}/circuit_breaker",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointCircuitBreaker> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointCircuitBreaker>(
                  path: $"endpoint_configurations/{arg.Id}/circuit_breaker",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"endpoint_configurations/{arg.Id}/circuit_breaker",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

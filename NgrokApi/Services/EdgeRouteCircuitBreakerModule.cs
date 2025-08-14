/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteCircuitBreakerModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteCircuitBreakerModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointCircuitBreaker> Replace(EdgeRouteCircuitBreakerReplace arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EndpointCircuitBreaker body = arg.Module;
            return await apiClient.Do<EndpointCircuitBreaker>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/circuit_breaker",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointCircuitBreaker> Get(EdgeRouteItem arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EdgeRouteItem body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<EndpointCircuitBreaker>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/circuit_breaker",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        public async Task Delete(EdgeRouteItem arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EdgeRouteItem body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/circuit_breaker",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

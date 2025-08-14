/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteBackendModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteBackendModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointBackend> Replace(EdgeRouteBackendReplace arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EndpointBackendMutate body = arg.Module;
            return await apiClient.Do<EndpointBackend>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/backend",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointBackend> Get(EdgeRouteItem arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EdgeRouteItem body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<EndpointBackend>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/backend",
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
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/backend",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

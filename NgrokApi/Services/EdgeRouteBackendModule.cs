
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
            Dictionary<string, string> query = null;
            EdgeRouteBackendReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointBackend>(
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/backend",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointBackend> Get(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointBackend>(
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/backend",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        public async Task Delete(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/backend",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

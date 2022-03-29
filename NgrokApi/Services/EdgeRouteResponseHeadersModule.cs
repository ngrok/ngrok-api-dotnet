
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteResponseHeadersModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteResponseHeadersModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointResponseHeaders> Replace(EdgeRouteResponseHeadersReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointResponseHeaders body = arg.Module;
            return await apiClient.Do<EndpointResponseHeaders>(
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/response_headers",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointResponseHeaders> Get(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointResponseHeaders>(
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/response_headers",
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
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/response_headers",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

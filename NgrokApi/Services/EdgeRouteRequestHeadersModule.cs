/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteRequestHeadersModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteRequestHeadersModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointRequestHeaders> Replace(EdgeRouteRequestHeadersReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointRequestHeaders body = arg.Module;
            return await apiClient.Do<EndpointRequestHeaders>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/request_headers",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointRequestHeaders> Get(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointRequestHeaders>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/request_headers",
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
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/request_headers",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

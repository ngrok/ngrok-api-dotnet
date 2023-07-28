/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteCompressionModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteCompressionModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointCompression> Replace(EdgeRouteCompressionReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointCompression body = arg.Module;
            return await apiClient.Do<EndpointCompression>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/compression",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointCompression> Get(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointCompression>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/compression",
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
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/compression",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

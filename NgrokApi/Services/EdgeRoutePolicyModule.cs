/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRoutePolicyModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRoutePolicyModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointPolicy> Replace(EdgeRoutePolicyReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointPolicy body = arg.Module;
            return await apiClient.Do<EndpointPolicy>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/policy",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointPolicy> Get(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointPolicy>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/policy",
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
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/policy",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

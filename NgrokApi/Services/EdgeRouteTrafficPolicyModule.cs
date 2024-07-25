/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteTrafficPolicyModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteTrafficPolicyModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointTrafficPolicy> Replace(EdgeRouteTrafficPolicyReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointTrafficPolicy body = arg.Module;
            return await apiClient.Do<EndpointTrafficPolicy>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/traffic_policy",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointTrafficPolicy> Get(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointTrafficPolicy>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/traffic_policy",
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
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/traffic_policy",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

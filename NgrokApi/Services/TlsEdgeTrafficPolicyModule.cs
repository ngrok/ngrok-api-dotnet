/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class TlsEdgeTrafficPolicyModule
    {
        private IApiHttpClient apiClient;

        internal TlsEdgeTrafficPolicyModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointTrafficPolicy> Replace(EdgeTrafficPolicyReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointTrafficPolicy body = arg.Module;
            return await apiClient.Do<EndpointTrafficPolicy>(
                path: $"/edges/tls/{arg.Id}/traffic_policy",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointTrafficPolicy> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointTrafficPolicy>(
                path: $"/edges/tls/{arg.Id}/traffic_policy",
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
                path: $"/edges/tls/{arg.Id}/traffic_policy",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

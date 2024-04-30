/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class TcpEdgePolicyModule
    {
        private IApiHttpClient apiClient;

        internal TcpEdgePolicyModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointPolicy> Replace(EdgePolicyReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointPolicy body = arg.Module;
            return await apiClient.Do<EndpointPolicy>(
                path: $"/edges/tcp/{arg.Id}/policy",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointPolicy> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointPolicy>(
                path: $"/edges/tcp/{arg.Id}/policy",
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
                path: $"/edges/tcp/{arg.Id}/policy",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

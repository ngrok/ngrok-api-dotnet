/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class TlsEdgeMutualTlsModule
    {
        private IApiHttpClient apiClient;

        internal TlsEdgeMutualTlsModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointMutualTls> Replace(EdgeMutualTlsReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointMutualTlsMutate body = arg.Module;
            return await apiClient.Do<EndpointMutualTls>(
                path: $"/edges/tls/{arg.Id}/mutual_tls",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointMutualTls> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointMutualTls>(
                path: $"/edges/tls/{arg.Id}/mutual_tls",
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
                path: $"/edges/tls/{arg.Id}/mutual_tls",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

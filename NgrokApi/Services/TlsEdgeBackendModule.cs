/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class TlsEdgeBackendModule
    {
        private IApiHttpClient apiClient;

        internal TlsEdgeBackendModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointBackend> Replace(EdgeBackendReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointBackendMutate body = arg.Module;
            return await apiClient.Do<EndpointBackend>(
                path: $"/edges/tls/{arg.Id}/backend",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointBackend> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointBackend>(
                path: $"/edges/tls/{arg.Id}/backend",
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
                path: $"/edges/tls/{arg.Id}/backend",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

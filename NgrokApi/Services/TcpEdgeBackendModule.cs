
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class TcpEdgeBackendModule
    {
        private IApiHttpClient apiClient;

        internal TcpEdgeBackendModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointBackend> Replace(EdgeBackendReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointBackendMutate body = arg.Module;
            return await apiClient.Do<EndpointBackend>(
                path: $"/edges/tcp/{arg.Id}/backend",
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
                path: $"/edges/tcp/{arg.Id}/backend",
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
                path: $"/edges/tcp/{arg.Id}/backend",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

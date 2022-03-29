
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class TlsEdgeTlsTerminationModule
    {
        private IApiHttpClient apiClient;

        internal TlsEdgeTlsTerminationModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointTlsTermination> Replace(EdgeTlsTerminationReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointTlsTermination body = arg.Module;
            return await apiClient.Do<EndpointTlsTermination>(
                  path: $"/edges/tls/{arg.Id}/tls_termination",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointTlsTermination> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointTlsTermination>(
                  path: $"/edges/tls/{arg.Id}/tls_termination",
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
                  path: $"/edges/tls/{arg.Id}/tls_termination",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

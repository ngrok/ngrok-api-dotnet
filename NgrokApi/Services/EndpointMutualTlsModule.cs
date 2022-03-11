
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointMutualTlsModule
    {
        private IApiHttpClient apiClient;

        internal EndpointMutualTlsModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointMutualTls> Replace(EndpointMutualTlsReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointMutualTlsReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointMutualTls>(
                  path: $"endpoint_configurations/{arg.Id}/mutual_tls",
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
                  path: $"endpoint_configurations/{arg.Id}/mutual_tls",
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
                  path: $"endpoint_configurations/{arg.Id}/mutual_tls",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

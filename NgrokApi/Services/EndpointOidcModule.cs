
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointOidcModule
    {
        private IApiHttpClient apiClient;

        internal EndpointOidcModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointOidc> Replace(EndpointOidcReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointOidcReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointOidc>(
                  path: $"endpoint_configurations/{arg.Id}/oidc",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointOidc> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointOidc>(
                  path: $"endpoint_configurations/{arg.Id}/oidc",
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
                  path: $"endpoint_configurations/{arg.Id}/oidc",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

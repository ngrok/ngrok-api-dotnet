
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointSamlModule
    {
        private IApiHttpClient apiClient;

        internal EndpointSamlModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointSaml> Replace(EndpointSamlReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointSamlReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointSaml>(
                  path: $"/endpoint_configurations/{arg.Id}/saml",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointSaml> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointSaml>(
                  path: $"/endpoint_configurations/{arg.Id}/saml",
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
                  path: $"/endpoint_configurations/{arg.Id}/saml",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

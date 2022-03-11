
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointOAuthModule
    {
        private IApiHttpClient apiClient;

        internal EndpointOAuthModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointOAuth> Replace(EndpointOAuthReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointOAuthReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointOAuth>(
                  path: $"endpoint_configurations/{arg.Id}/oauth",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointOAuth> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointOAuth>(
                  path: $"endpoint_configurations/{arg.Id}/oauth",
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
                  path: $"endpoint_configurations/{arg.Id}/oauth",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

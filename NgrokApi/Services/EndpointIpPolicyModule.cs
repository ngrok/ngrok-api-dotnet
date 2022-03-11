
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointIpPolicyModule
    {
        private IApiHttpClient apiClient;

        internal EndpointIpPolicyModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointIpPolicy> Replace(EndpointIpPolicyReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointIpPolicyReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointIpPolicy>(
                  path: $"endpoint_configurations/{arg.Id}/ip_policy",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointIpPolicy> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointIpPolicy>(
                  path: $"endpoint_configurations/{arg.Id}/ip_policy",
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
                  path: $"endpoint_configurations/{arg.Id}/ip_policy",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

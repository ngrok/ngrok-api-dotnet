
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointResponseHeadersModule
    {
        private IApiHttpClient apiClient;

        internal EndpointResponseHeadersModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointResponseHeaders> Replace(EndpointResponseHeadersReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointResponseHeadersReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointResponseHeaders>(
                  path: $"/endpoint_configurations/{arg.Id}/response_headers",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointResponseHeaders> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointResponseHeaders>(
                  path: $"/endpoint_configurations/{arg.Id}/response_headers",
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
                  path: $"/endpoint_configurations/{arg.Id}/response_headers",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

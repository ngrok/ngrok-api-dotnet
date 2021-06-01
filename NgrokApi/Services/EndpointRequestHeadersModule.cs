
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointRequestHeadersModule
    {
        private IApiHttpClient apiClient;

        internal EndpointRequestHeadersModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointRequestHeaders> Replace(EndpointRequestHeadersReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointRequestHeadersReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointRequestHeaders>(
                  path: $"/endpoint_configurations/{arg.Id}/request_headers",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointRequestHeaders> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointRequestHeaders>(
                  path: $"/endpoint_configurations/{arg.Id}/request_headers",
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
                  path: $"/endpoint_configurations/{arg.Id}/request_headers",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

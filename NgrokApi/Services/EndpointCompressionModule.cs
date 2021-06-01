
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointCompressionModule
    {
        private IApiHttpClient apiClient;

        internal EndpointCompressionModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointCompression> Replace(EndpointCompressionReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointCompressionReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointCompression>(
                  path: $"/endpoint_configurations/{arg.Id}/compression",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointCompression> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointCompression>(
                  path: $"/endpoint_configurations/{arg.Id}/compression",
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
                  path: $"/endpoint_configurations/{arg.Id}/compression",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointLoggingModule
    {
        private IApiHttpClient apiClient;

        internal EndpointLoggingModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointLogging> Replace(EndpointLoggingReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointLoggingReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointLogging>(
                  path: $"endpoint_configurations/{arg.Id}/logging",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointLogging> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointLogging>(
                  path: $"endpoint_configurations/{arg.Id}/logging",
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
                  path: $"endpoint_configurations/{arg.Id}/logging",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointTlsTerminationModule
    {
        private IApiHttpClient apiClient;

        internal EndpointTlsTerminationModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointTlsTermination> Replace(EndpointTlsTerminationReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointTlsTerminationReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointTlsTermination>(
                  path: $"/endpoint_configurations/{arg.Id}/tls_termination",
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
                  path: $"/endpoint_configurations/{arg.Id}/tls_termination",
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
                  path: $"/endpoint_configurations/{arg.Id}/tls_termination",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

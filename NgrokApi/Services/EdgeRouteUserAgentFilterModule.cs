/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteUserAgentFilterModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteUserAgentFilterModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointUserAgentFilter> Replace(EdgeRouteUserAgentFilterReplace arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EndpointUserAgentFilter body = arg.Module;
            return await apiClient.Do<EndpointUserAgentFilter>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/user_agent_filter",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointUserAgentFilter> Get(EdgeRouteItem arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EdgeRouteItem body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<EndpointUserAgentFilter>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/user_agent_filter",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        public async Task Delete(EdgeRouteItem arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EdgeRouteItem body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/user_agent_filter",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

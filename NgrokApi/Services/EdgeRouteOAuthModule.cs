/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteOAuthModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteOAuthModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointOAuth> Replace(EdgeRouteOAuthReplace arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EndpointOAuth body = arg.Module;
            return await apiClient.Do<EndpointOAuth>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/oauth",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointOAuth> Get(EdgeRouteItem arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EdgeRouteItem body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<EndpointOAuth>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/oauth",
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
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/oauth",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

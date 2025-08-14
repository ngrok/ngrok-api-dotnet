/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteOidcModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteOidcModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointOidc> Replace(EdgeRouteOidcReplace arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EndpointOidc body = arg.Module;
            return await apiClient.Do<EndpointOidc>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/oidc",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointOidc> Get(EdgeRouteItem arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EdgeRouteItem body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<EndpointOidc>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/oidc",
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
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/oidc",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

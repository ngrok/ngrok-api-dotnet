
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
            Dictionary<string, string> query = null;
            EdgeRouteOAuthReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointOAuth>(
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/oauth",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointOAuth> Get(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointOAuth>(
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/oauth",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        public async Task Delete(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/oauth",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

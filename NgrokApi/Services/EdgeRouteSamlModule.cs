/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteSamlModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteSamlModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointSaml> Replace(EdgeRouteSamlReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointSamlMutate body = arg.Module;
            return await apiClient.Do<EndpointSaml>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/saml",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointSaml> Get(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointSaml>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/saml",
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
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/saml",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

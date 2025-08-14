/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteIpRestrictionModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteIpRestrictionModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointIpPolicy> Replace(EdgeRouteIpRestrictionReplace arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EndpointIpPolicyMutate body = arg.Module;
            return await apiClient.Do<EndpointIpPolicy>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/ip_restriction",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointIpPolicy> Get(EdgeRouteItem arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EdgeRouteItem body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<EndpointIpPolicy>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/ip_restriction",
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
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/ip_restriction",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

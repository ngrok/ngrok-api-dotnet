/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class TlsEdgeIpRestrictionModule
    {
        private IApiHttpClient apiClient;

        internal TlsEdgeIpRestrictionModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointIpPolicy> Replace(EdgeIpRestrictionReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointIpPolicyMutate body = arg.Module;
            return await apiClient.Do<EndpointIpPolicy>(
                path: $"/edges/tls/{arg.Id}/ip_restriction",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointIpPolicy> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointIpPolicy>(
                path: $"/edges/tls/{arg.Id}/ip_restriction",
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
                path: $"/edges/tls/{arg.Id}/ip_restriction",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

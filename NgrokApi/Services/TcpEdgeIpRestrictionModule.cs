/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class TcpEdgeIpRestrictionModule
    {
        private IApiHttpClient apiClient;

        internal TcpEdgeIpRestrictionModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointIpPolicy> Replace(EdgeIpRestrictionReplace arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EndpointIpPolicyMutate body = arg.Module;
            return await apiClient.Do<EndpointIpPolicy>(
                path: $"/edges/tcp/{arg.Id}/ip_restriction",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointIpPolicy> Get(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<EndpointIpPolicy>(
                path: $"/edges/tcp/{arg.Id}/ip_restriction",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/edges/tcp/{arg.Id}/ip_restriction",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

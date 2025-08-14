/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgeRouteWebhookVerificationModule
    {
        private IApiHttpClient apiClient;

        internal EdgeRouteWebhookVerificationModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointWebhookValidation> Replace(EdgeRouteWebhookVerificationReplace arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EndpointWebhookValidation body = arg.Module;
            return await apiClient.Do<EndpointWebhookValidation>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/webhook_verification",
                method: new HttpMethod("put"),
                body: body,
                query: query
            );

        }

        public async Task<EndpointWebhookValidation> Get(EdgeRouteItem arg)
        {
            List<KeyValuePair<string, string>> query = null;
            EdgeRouteItem body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<EndpointWebhookValidation>(
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/webhook_verification",
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
                path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/webhook_verification",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

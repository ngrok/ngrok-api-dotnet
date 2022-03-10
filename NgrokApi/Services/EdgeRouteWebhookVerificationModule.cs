
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
            Dictionary<string, string> query = null;
            EdgeRouteWebhookVerificationReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointWebhookValidation>(
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/webhook_verification",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointWebhookValidation> Get(EdgeRouteItem arg)
        {
            Dictionary<string, string> query = null;
            EdgeRouteItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointWebhookValidation>(
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/webhook_verification",
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
                  path: $"/edges/https/{arg.EdgeId}/routes/{arg.Id}/webhook_verification",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EndpointWebhookValidationModule
    {
        private IApiHttpClient apiClient;

        internal EndpointWebhookValidationModule(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<EndpointWebhookValidation> Replace(EndpointWebhookValidationReplace arg)
        {
            Dictionary<string, string> query = null;
            EndpointWebhookValidationReplace body = null;
            body = arg;

            return await apiClient.Do<EndpointWebhookValidation>(
                  path: $"endpoint_configurations/{arg.Id}/webhook_validation",
                  method: new HttpMethod("put"),
                  body: body,
                  query: query
            );

        }

        public async Task<EndpointWebhookValidation> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointWebhookValidation>(
                  path: $"endpoint_configurations/{arg.Id}/webhook_validation",
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
                  path: $"endpoint_configurations/{arg.Id}/webhook_validation",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

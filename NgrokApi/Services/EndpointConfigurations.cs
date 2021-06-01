
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // Endpoint Configuration managementAn <see
    // href="https://ngrok.com/docs/ngrok-link#api-endpoint-configurations">Endpoint
    // Configuration</see> describes
    // a ngrok network endpoint instance.<em>Endpoints are your gateway to ngrok
    // features!</em>
    // </summary>

    public class EndpointConfigurations
    {
        private IApiHttpClient apiClient;

        internal EndpointConfigurations(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new endpoint configuration
        // </summary>
        //
        // https://ngrok.com/docs/api#api-endpoint-configurations-create
        public async Task<EndpointConfiguration> Create(EndpointConfigurationCreate arg)
        {
            Dictionary<string, string> query = null;
            EndpointConfigurationCreate body = null;
            body = arg;

            return await apiClient.Do<EndpointConfiguration>(
                  path: $"/endpoint_configurations",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete an endpoint configuration. This operation will fail if the endpoint
        // configuration is still referenced by any reserved domain or reserved address.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-endpoint-configurations-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/endpoint_configurations/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Returns detailed information about an endpoint configuration
        // </summary>
        //
        // https://ngrok.com/docs/api#api-endpoint-configurations-get
        public async Task<EndpointConfiguration> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EndpointConfiguration>(
                  path: $"/endpoint_configurations/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<EndpointConfigurationList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<EndpointConfigurationList>(
                  path: $"/endpoint_configurations",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // Returns a list of all endpoint configurations on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-endpoint-configurations-list
        public IEnumerable<EndpointConfiguration> List(string limit = null, string beforeId = null)
        {
            return new Iterator<EndpointConfiguration>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.EndpointConfigurations;
            });
        }

        // <summary>
        // Updates an endpoint configuration. If a module is not specified in the update,
        // it will not be modified. However, each module configuration that is specified
        // will completely replace the existing value. There is no way to delete an
        // existing module via this API, instead use the delete module API.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-endpoint-configurations-update
        public async Task<EndpointConfiguration> Update(EndpointConfigurationUpdate arg)
        {
            Dictionary<string, string> query = null;
            EndpointConfigurationUpdate body = null;
            body = arg;

            return await apiClient.Do<EndpointConfiguration>(
                  path: $"/endpoint_configurations/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}

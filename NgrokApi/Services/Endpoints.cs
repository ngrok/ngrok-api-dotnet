/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // Endpoints provides an API for querying the endpoint objects
    //  which define what tunnel or edge is used to serve a hostport.
    //  Only active endpoints associated with a tunnel or backend are returned.
    // </summary>

    public class Endpoints
    {
        private IApiHttpClient apiClient;

        internal Endpoints(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create an endpoint, currently available only for cloud endpoints
        // </summary>
        //
        // https://ngrok.com/docs/api#api-endpoints-create
        public async Task<Endpoint> Create(EndpointCreate arg)
        {
            Dictionary<string, string> query = null;
            EndpointCreate body = arg;
            return await apiClient.Do<Endpoint>(
                path: $"/endpoints",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        private async Task<EndpointList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<EndpointList>(
                path: $"/endpoints",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all active endpoints on the account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-endpoints-list
        public IAsyncEnumerable<Endpoint> List(string limit = null, string beforeId = null)
        {
            return new Iterator<Endpoint>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Endpoints;
            });
        }

        // <summary>
        // Get the status of an endpoint by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-endpoints-get
        public async Task<Endpoint> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<Endpoint>(
                path: $"/endpoints/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Update an Endpoint by ID, currently available only for cloud endpoints
        // </summary>
        //
        // https://ngrok.com/docs/api#api-endpoints-update
        public async Task<Endpoint> Update(EndpointUpdate arg)
        {
            Dictionary<string, string> query = null;
            EndpointUpdate body = arg;
            return await apiClient.Do<Endpoint>(
                path: $"/endpoints/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete an Endpoint by ID, currently available only for cloud endpoints
        // </summary>
        //
        // https://ngrok.com/docs/api#api-endpoints-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/endpoints/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

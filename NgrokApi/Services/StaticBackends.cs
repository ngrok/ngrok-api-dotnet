/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // A static backend sends traffic to a TCP address (hostname and port) that
    //  is reachable on the public internet.
    // </summary>

    public class StaticBackends
    {
        private IApiHttpClient apiClient;

        internal StaticBackends(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new static backend
        // </summary>
        //
        // https://ngrok.com/docs/api#api-static-backends-create
        public async Task<StaticBackend> Create(StaticBackendCreate arg)
        {
            Dictionary<string, string> query = null;
            StaticBackendCreate body = arg;
            return await apiClient.Do<StaticBackend>(
                path: $"/backends/static",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete a static backend by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-static-backends-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/backends/static/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get detailed information about a static backend by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-static-backends-get
        public async Task<StaticBackend> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<StaticBackend>(
                path: $"/backends/static/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<StaticBackendList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<StaticBackendList>(
                path: $"/backends/static",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all static backends on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-static-backends-list
        public IAsyncEnumerable<StaticBackend> List(string limit = null, string beforeId = null)
        {
            return new Iterator<StaticBackend>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Backends;
            });
        }

        // <summary>
        // Update static backend by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-static-backends-update
        public async Task<StaticBackend> Update(StaticBackendUpdate arg)
        {
            Dictionary<string, string> query = null;
            StaticBackendUpdate body = arg;
            return await apiClient.Do<StaticBackend>(
                path: $"/backends/static/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}

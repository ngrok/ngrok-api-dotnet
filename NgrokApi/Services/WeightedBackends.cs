/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // A Weighted Backend balances traffic among the referenced backends. Traffic
    //  is assigned proportionally to each based on its weight. The percentage of
    //  traffic is calculated by dividing a backend's weight by the sum of all
    //  weights.
    // </summary>

    public class WeightedBackends
    {
        private IApiHttpClient apiClient;

        internal WeightedBackends(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new Weighted backend
        // </summary>
        //
        // https://ngrok.com/docs/api#api-weighted-backends-create
        public async Task<WeightedBackend> Create(WeightedBackendCreate arg)
        {
            Dictionary<string, string> query = null;
            WeightedBackendCreate body = arg;
            return await apiClient.Do<WeightedBackend>(
                path: $"/backends/weighted",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete a Weighted backend by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-weighted-backends-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/backends/weighted/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get detailed information about a Weighted backend by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-weighted-backends-get
        public async Task<WeightedBackend> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<WeightedBackend>(
                path: $"/backends/weighted/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<WeightedBackendList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<WeightedBackendList>(
                path: $"/backends/weighted",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all Weighted backends on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-weighted-backends-list
        public IAsyncEnumerable<WeightedBackend> List(string limit = null, string beforeId = null)
        {
            return new Iterator<WeightedBackend>(beforeId, async lastId =>
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
        // Update Weighted backend by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-weighted-backends-update
        public async Task<WeightedBackend> Update(WeightedBackendUpdate arg)
        {
            Dictionary<string, string> query = null;
            WeightedBackendUpdate body = arg;
            return await apiClient.Do<WeightedBackend>(
                path: $"/backends/weighted/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}

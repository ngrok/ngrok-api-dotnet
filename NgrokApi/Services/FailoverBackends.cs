
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // A Failover backend defines failover behavior within a list of referenced
    //  backends. Traffic is sent to the first backend in the list. If that backend
    //  is offline or no connection can be established, ngrok attempts to connect to
    //  the next backend in the list until one is successful.
    // </summary>

    public class FailoverBackends
    {
        private IApiHttpClient apiClient;

        internal FailoverBackends(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new Failover backend
        // </summary>
        //
        // https://ngrok.com/docs/api#api-failover-backends-create
        public async Task<FailoverBackend> Create(FailoverBackendCreate arg)
        {
            Dictionary<string, string> query = null;
            FailoverBackendCreate body = arg;
            return await apiClient.Do<FailoverBackend>(
                  path: $"/backends/failover",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete a Failover backend by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-failover-backends-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/backends/failover/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get detailed information about a Failover backend by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-failover-backends-get
        public async Task<FailoverBackend> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<FailoverBackend>(
                  path: $"/backends/failover/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<FailoverBackendList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<FailoverBackendList>(
                  path: $"/backends/failover",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all Failover backends on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-failover-backends-list
        public IAsyncEnumerable<FailoverBackend> List(string limit = null, string beforeId = null)
        {
            return new Iterator<FailoverBackend>(beforeId, async lastId =>
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
        // Update Failover backend by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-failover-backends-update
        public async Task<FailoverBackend> Update(FailoverBackendUpdate arg)
        {
            Dictionary<string, string> query = null;
            FailoverBackendUpdate body = arg;
            return await apiClient.Do<FailoverBackend>(
                  path: $"/backends/failover/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}

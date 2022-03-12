
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // A Tunnel Group Backend balances traffic among all online tunnels that match
    //  a label selector.
    // </summary>

    public class TunnelGroupBackends
    {
        private IApiHttpClient apiClient;

        internal TunnelGroupBackends(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new TunnelGroup backend
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnel-group-backends-create
        public async Task<TunnelGroupBackend> Create(TunnelGroupBackendCreate arg)
        {
            Dictionary<string, string> query = null;
            TunnelGroupBackendCreate body = null;
            body = arg;

            return await apiClient.Do<TunnelGroupBackend>(
                  path: $"/backends/tunnel_group",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete a TunnelGroup backend by ID. TODO what if used?
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnel-group-backends-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/backends/tunnel_group/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get detailed information about a TunnelGroup backend by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnel-group-backends-get
        public async Task<TunnelGroupBackend> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<TunnelGroupBackend>(
                  path: $"/backends/tunnel_group/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<TunnelGroupBackendList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<TunnelGroupBackendList>(
                  path: $"/backends/tunnel_group",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all TunnelGroup backends on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnel-group-backends-list
        public IAsyncEnumerable<TunnelGroupBackend> List(string limit = null, string beforeId = null)
        {
            return new Iterator<TunnelGroupBackend>(beforeId, async lastId =>
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
        // Update TunnelGroup backend by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnel-group-backends-update
        public async Task<TunnelGroupBackend> Update(TunnelGroupBackendUpdate arg)
        {
            Dictionary<string, string> query = null;
            TunnelGroupBackendUpdate body = null;
            body = arg;

            return await apiClient.Do<TunnelGroupBackend>(
                  path: $"/backends/tunnel_group/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}

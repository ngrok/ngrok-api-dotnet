
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // Tunnels provide endpoints to access services exposed by a running ngrok
    //  agent tunnel session or an SSH reverse tunnel session.
    // </summary>

    public class Tunnels
    {
        private IApiHttpClient apiClient;

        internal Tunnels(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        private async Task<TunnelList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<TunnelList>(
                path: $"/tunnels",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all online tunnels currently running on the account.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnels-list
        public IAsyncEnumerable<Tunnel> List(string limit = null, string beforeId = null)
        {
            return new Iterator<Tunnel>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Tunnels;
            });
        }

        // <summary>
        // Get the status of a tunnel by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnels-get
        public async Task<Tunnel> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<Tunnel>(
                path: $"/tunnels/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
    }
}

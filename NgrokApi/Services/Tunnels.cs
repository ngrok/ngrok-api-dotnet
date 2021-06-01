
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

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
        public IEnumerable<Tunnel> List(string limit = null, string beforeId = null)
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
    }
}

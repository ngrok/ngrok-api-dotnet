
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgesTls
    {
        private IApiHttpClient apiClient;

        internal EdgesTls(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a TLS Edge
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-tls-create
        public async Task<TlsEdge> Create(TlsEdgeCreate arg)
        {
            Dictionary<string, string> query = null;
            TlsEdgeCreate body = arg;
            return await apiClient.Do<TlsEdge>(
                  path: $"/edges/tls",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Get a TLS Edge by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-tls-get
        public async Task<TlsEdge> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<TlsEdge>(
                  path: $"/edges/tls/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<TlsEdgeList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<TlsEdgeList>(
                  path: $"/edges/tls",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // Returns a list of all TLS Edges on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-tls-list
        public IAsyncEnumerable<TlsEdge> List(string limit = null, string beforeId = null)
        {
            return new Iterator<TlsEdge>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.TlsEdges;
            });
        }

        // <summary>
        // Updates a TLS Edge by ID. If a module is not specified in the update, it will
        // not be modified. However, each module configuration that is specified will
        // completely replace the existing value. There is no way to delete an existing
        // module via this API, instead use the delete module API.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-tls-update
        public async Task<TlsEdge> Update(TlsEdgeUpdate arg)
        {
            Dictionary<string, string> query = null;
            TlsEdgeUpdate body = arg;
            return await apiClient.Do<TlsEdge>(
                  path: $"/edges/tls/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete a TLS Edge by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-tls-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/edges/tls/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

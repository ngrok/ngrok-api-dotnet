
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgesTcp
    {
        private IApiHttpClient apiClient;

        internal EdgesTcp(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a TCP Edge
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-tcp-create
        public async Task<TcpEdge> Create(TcpEdgeCreate arg)
        {
            Dictionary<string, string> query = null;
            TcpEdgeCreate body = null;
            body = arg;

            return await apiClient.Do<TcpEdge>(
                  path: $"/edges/tcp",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Get a TCP Edge by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-tcp-get
        public async Task<TcpEdge> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<TcpEdge>(
                  path: $"/edges/tcp/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<TcpEdgeList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<TcpEdgeList>(
                  path: $"/edges/tcp",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // Returns a list of all TCP Edges on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-tcp-list
        public IAsyncEnumerable<TcpEdge> List(string limit = null, string beforeId = null)
        {
            return new Iterator<TcpEdge>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.TcpEdges;
            });
        }

        // <summary>
        // Updates a TCP Edge by ID. If a module is not specified in the update, it will
        // not be modified. However, each module configuration that is specified will
        // completely replace the existing value. There is no way to delete an existing
        // module via this API, instead use the delete module API.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-tcp-update
        public async Task<TcpEdge> Update(TcpEdgeUpdate arg)
        {
            Dictionary<string, string> query = null;
            TcpEdgeUpdate body = null;
            body = arg;

            return await apiClient.Do<TcpEdge>(
                  path: $"/edges/tcp/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete a TCP Edge by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-tcp-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/edges/tcp/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }
    }
}

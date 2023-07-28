/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EdgesHttps
    {
        private IApiHttpClient apiClient;

        internal EdgesHttps(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create an HTTPS Edge
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-https-create
        public async Task<HttpsEdge> Create(HttpsEdgeCreate arg)
        {
            Dictionary<string, string> query = null;
            HttpsEdgeCreate body = arg;
            return await apiClient.Do<HttpsEdge>(
                path: $"/edges/https",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Get an HTTPS Edge by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-https-get
        public async Task<HttpsEdge> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<HttpsEdge>(
                path: $"/edges/https/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<HttpsEdgeList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<HttpsEdgeList>(
                path: $"/edges/https",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // Returns a list of all HTTPS Edges on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-https-list
        public IAsyncEnumerable<HttpsEdge> List(string limit = null, string beforeId = null)
        {
            return new Iterator<HttpsEdge>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.HttpsEdges;
            });
        }

        // <summary>
        // Updates an HTTPS Edge by ID. If a module is not specified in the update, it will
        // not be modified. However, each module configuration that is specified will
        // completely replace the existing value. There is no way to delete an existing
        // module via this API, instead use the delete module API.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-https-update
        public async Task<HttpsEdge> Update(HttpsEdgeUpdate arg)
        {
            Dictionary<string, string> query = null;
            HttpsEdgeUpdate body = arg;
            return await apiClient.Do<HttpsEdge>(
                path: $"/edges/https/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete an HTTPS Edge by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-edges-https-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/edges/https/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }
    }
}

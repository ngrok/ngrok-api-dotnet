
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class HttpResponseBackends
    {
        private IApiHttpClient apiClient;

        internal HttpResponseBackends(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<HttpResponseBackend> Create(HttpResponseBackendCreate arg)
        {
            Dictionary<string, string> query = null;
            HttpResponseBackendCreate body = arg;
            return await apiClient.Do<HttpResponseBackend>(
                path: $"/backends/http_response",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/backends/http_response/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        public async Task<HttpResponseBackend> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<HttpResponseBackend>(
                path: $"/backends/http_response/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<HttpResponseBackendList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<HttpResponseBackendList>(
                path: $"/backends/http_response",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        public IAsyncEnumerable<HttpResponseBackend> List(string limit = null, string beforeId = null)
        {
            return new Iterator<HttpResponseBackend>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Backends;
            });
        }

        public async Task<HttpResponseBackend> Update(HttpResponseBackendUpdate arg)
        {
            Dictionary<string, string> query = null;
            HttpResponseBackendUpdate body = arg;
            return await apiClient.Do<HttpResponseBackend>(
                path: $"/backends/http_response/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}

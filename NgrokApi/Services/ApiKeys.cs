
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // API Keys are used to authenticate to the <see
    // href="https://ngrok.com/docs/api#authentication">ngrok
    //  API</see>. You may use the API itself
    //  to provision and manage API Keys but you'll need to provision your first API
    //  key from the <see href="https://dashboard.ngrok.com/api/keys">API Keys
    // page</see> on your
    //  ngrok.com dashboard.
    // </summary>

    public class ApiKeys
    {
        private IApiHttpClient apiClient;

        internal ApiKeys(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new API key. The generated API key can be used to authenticate to the
        // ngrok API.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-api-keys-create
        public async Task<ApiKey> Create(ApiKeyCreate arg)
        {
            Dictionary<string, string> query = null;
            ApiKeyCreate body = null;
            body = arg;

            return await apiClient.Do<ApiKey>(
                  path: $"/api_keys",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete an API key by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-api-keys-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/api_keys/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get the details of an API key by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-api-keys-get
        public async Task<ApiKey> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<ApiKey>(
                  path: $"/api_keys/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<ApiKeyList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<ApiKeyList>(
                  path: $"/api_keys",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all API keys owned by this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-api-keys-list
        public IAsyncEnumerable<ApiKey> List(string limit = null, string beforeId = null)
        {
            return new Iterator<ApiKey>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Keys;
            });
        }

        // <summary>
        // Update attributes of an API key by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-api-keys-update
        public async Task<ApiKey> Update(ApiKeyUpdate arg)
        {
            Dictionary<string, string> query = null;
            ApiKeyUpdate body = null;
            body = arg;

            return await apiClient.Do<ApiKey>(
                  path: $"/api_keys/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}

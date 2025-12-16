/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // Secrets is an api service for securely storing and managing sensitive data such
    // as secrets, credentials, and tokens.
    // </summary>

    public class Secrets
    {
        private IApiHttpClient apiClient;

        internal Secrets(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new Secret
        // </summary>
        //
        // https://ngrok.com/docs/api#api-secrets-create
        public async Task<Secret> Create(SecretCreate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            SecretCreate body = arg;
            return await apiClient.Do<Secret>(
                path: $"/vault_secrets",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Update an existing Secret by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-secrets-update
        public async Task<Secret> Update(SecretUpdate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            SecretUpdate body = arg;
            return await apiClient.Do<Secret>(
                path: $"/vault_secrets/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete a Secret
        // </summary>
        //
        // https://ngrok.com/docs/api#api-secrets-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/vault_secrets/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get a Secret by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-secrets-get
        public async Task<Secret> Get(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<Secret>(
                path: $"/vault_secrets/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<SecretList> ListPage(FilteredPaging arg)

        {
            List<KeyValuePair<string, string>> query = null;
            FilteredPaging body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            if (arg.BeforeId != null) queryParams.Add(new KeyValuePair<string, string>("before_id", arg.BeforeId));
            if (arg.Limit != null) queryParams.Add(new KeyValuePair<string, string>("limit", arg.Limit));
            if (arg.Filter != null) queryParams.Add(new KeyValuePair<string, string>("filter", arg.Filter));
            query = queryParams;
            return await apiClient.Do<SecretList>(
                path: $"/vault_secrets",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all Secrets owned by account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-secrets-list
        public IAsyncEnumerable<Secret> List(string limit = null, string beforeId = null)
        {
            return new Iterator<Secret>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new FilteredPaging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Secrets;
            });
        }
    }
}

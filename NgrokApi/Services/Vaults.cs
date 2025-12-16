/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // Vaults is an api service for securely storing and managing sensitive data such
    // as secrets, credentials, and tokens.
    // </summary>

    public class Vaults
    {
        private IApiHttpClient apiClient;

        internal Vaults(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new Vault
        // </summary>
        //
        // https://ngrok.com/docs/api#api-vaults-create
        public async Task<Vault> Create(VaultCreate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            VaultCreate body = arg;
            return await apiClient.Do<Vault>(
                path: $"/vaults",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Update an existing Vault by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-vaults-update
        public async Task<Vault> Update(VaultUpdate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            VaultUpdate body = arg;
            return await apiClient.Do<Vault>(
                path: $"/vaults/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete a Vault
        // </summary>
        //
        // https://ngrok.com/docs/api#api-vaults-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/vaults/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get a Vault by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-vaults-get
        public async Task<Vault> Get(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<Vault>(
                path: $"/vaults/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<SecretList> GetSecretsByVaultPage(ItemPaging arg)

        {
            List<KeyValuePair<string, string>> query = null;
            ItemPaging body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            if (arg.BeforeId != null) queryParams.Add(new KeyValuePair<string, string>("before_id", arg.BeforeId));
            if (arg.Limit != null) queryParams.Add(new KeyValuePair<string, string>("limit", arg.Limit));
            query = queryParams;
            return await apiClient.Do<SecretList>(
                path: $"/vaults/{arg.Id}/secrets",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // Get Secrets by Vault ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-vaults-get-secrets-by-vault
        public IAsyncEnumerable<Secret> GetSecretsByVault(string id, string limit = null, string beforeId = null)
        {
            return new Iterator<Secret>(beforeId, async lastId =>
            {
                var result = await this.GetSecretsByVaultPage(new ItemPaging()
                {
                    Id = id,
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Secrets;
            });
        }

        private async Task<VaultList> ListPage(FilteredPaging arg)

        {
            List<KeyValuePair<string, string>> query = null;
            FilteredPaging body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            if (arg.BeforeId != null) queryParams.Add(new KeyValuePair<string, string>("before_id", arg.BeforeId));
            if (arg.Limit != null) queryParams.Add(new KeyValuePair<string, string>("limit", arg.Limit));
            if (arg.Filter != null) queryParams.Add(new KeyValuePair<string, string>("filter", arg.Filter));
            query = queryParams;
            return await apiClient.Do<VaultList>(
                path: $"/vaults",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all Vaults owned by account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-vaults-list
        public IAsyncEnumerable<Vault> List(string limit = null, string beforeId = null)
        {
            return new Iterator<Vault>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new FilteredPaging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Vaults;
            });
        }
    }
}

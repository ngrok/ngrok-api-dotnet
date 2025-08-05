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
            Dictionary<string, string> query = null;
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
            Dictionary<string, string> query = null;
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

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
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

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<Vault>(
                path: $"/vaults/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<VaultList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
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
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Vaults;
            });
        }
    }
}

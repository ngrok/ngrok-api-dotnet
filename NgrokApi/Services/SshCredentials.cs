/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // SSH Credentials are SSH public keys that can be used to start SSH tunnels
    //  via the ngrok SSH tunnel gateway.
    // </summary>

    public class SshCredentials
    {
        private IApiHttpClient apiClient;

        internal SshCredentials(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new ssh_credential from an uploaded public SSH key. This ssh credential
        // can be used to start new tunnels via ngrok's SSH gateway.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-credentials-create
        public async Task<SshCredential> Create(SshCredentialCreate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            SshCredentialCreate body = arg;
            return await apiClient.Do<SshCredential>(
                path: $"/ssh_credentials",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete an ssh_credential by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-credentials-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/ssh_credentials/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get detailed information about an ssh_credential
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-credentials-get
        public async Task<SshCredential> Get(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<SshCredential>(
                path: $"/ssh_credentials/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<SshCredentialList> ListPage(Paging arg)

        {
            List<KeyValuePair<string, string>> query = null;
            Paging body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            if (arg.BeforeId != null) queryParams.Add(new KeyValuePair<string, string>("before_id", arg.BeforeId));
            if (arg.Limit != null) queryParams.Add(new KeyValuePair<string, string>("limit", arg.Limit));
            query = queryParams;
            return await apiClient.Do<SshCredentialList>(
                path: $"/ssh_credentials",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all ssh credentials on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-credentials-list
        public IAsyncEnumerable<SshCredential> List(string limit = null, string beforeId = null)
        {
            return new Iterator<SshCredential>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.SshCredentials;
            });
        }

        // <summary>
        // Update attributes of an ssh_credential by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ssh-credentials-update
        public async Task<SshCredential> Update(SshCredentialUpdate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            SshCredentialUpdate body = arg;
            return await apiClient.Do<SshCredential>(
                path: $"/ssh_credentials/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}

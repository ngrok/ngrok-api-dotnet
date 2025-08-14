/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // Tunnel Credentials are ngrok agent authtokens. They authorize the ngrok
    //  agent to connect the ngrok service as your account. They are installed with
    //  the <c>ngrok config add-authtoken</c> command or by specifying it in the
    // <c>ngrok.yml</c>
    //  configuration file with the <c>authtoken</c> property.
    // </summary>

    public class Credentials
    {
        private IApiHttpClient apiClient;

        internal Credentials(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new tunnel authtoken credential. This authtoken credential can be used
        // to start a new tunnel session. The response to this API call is the only time
        // the generated token is available. If you need it for future use, you must save
        // it securely yourself.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-credentials-create
        public async Task<Credential> Create(CredentialCreate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            CredentialCreate body = arg;
            return await apiClient.Do<Credential>(
                path: $"/credentials",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete a tunnel authtoken credential by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-credentials-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/credentials/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get detailed information about a tunnel authtoken credential
        // </summary>
        //
        // https://ngrok.com/docs/api#api-credentials-get
        public async Task<Credential> Get(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<Credential>(
                path: $"/credentials/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<CredentialList> ListPage(Paging arg)

        {
            List<KeyValuePair<string, string>> query = null;
            Paging body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            if (arg.BeforeId != null) queryParams.Add(new KeyValuePair<string, string>("before_id", arg.BeforeId));
            if (arg.Limit != null) queryParams.Add(new KeyValuePair<string, string>("limit", arg.Limit));
            query = queryParams;
            return await apiClient.Do<CredentialList>(
                path: $"/credentials",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all tunnel authtoken credentials on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-credentials-list
        public IAsyncEnumerable<Credential> List(string limit = null, string beforeId = null)
        {
            return new Iterator<Credential>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Credentials;
            });
        }

        // <summary>
        // Update attributes of an tunnel authtoken credential by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-credentials-update
        public async Task<Credential> Update(CredentialUpdate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            CredentialUpdate body = arg;
            return await apiClient.Do<Credential>(
                path: $"/credentials/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}

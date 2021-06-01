
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class IpWhitelist
    {
        private IApiHttpClient apiClient;

        internal IpWhitelist(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new IP whitelist entry that will restrict traffic to all tunnel
        // endpoints on the account.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-whitelist-create
        public async Task<IpWhitelistEntry> Create(IpWhitelistEntryCreate arg)
        {
            Dictionary<string, string> query = null;
            IpWhitelistEntryCreate body = null;
            body = arg;

            return await apiClient.Do<IpWhitelistEntry>(
                  path: $"/ip_whitelist",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete an IP whitelist entry.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-whitelist-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/ip_whitelist/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get detailed information about an IP whitelist entry by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-whitelist-get
        public async Task<IpWhitelistEntry> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<IpWhitelistEntry>(
                  path: $"/ip_whitelist/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<IpWhitelistEntryList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<IpWhitelistEntryList>(
                  path: $"/ip_whitelist",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all IP whitelist entries on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-whitelist-list
        public IEnumerable<IpWhitelistEntry> List(string limit = null, string beforeId = null)
        {
            return new Iterator<IpWhitelistEntry>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Whitelist;
            });
        }

        // <summary>
        // Update attributes of an IP whitelist entry by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-whitelist-update
        public async Task<IpWhitelistEntry> Update(IpWhitelistEntryUpdate arg)
        {
            Dictionary<string, string> query = null;
            IpWhitelistEntryUpdate body = null;
            body = arg;

            return await apiClient.Do<IpWhitelistEntry>(
                  path: $"/ip_whitelist/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}

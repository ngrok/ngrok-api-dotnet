
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class IpRestrictions
    {
        private IApiHttpClient apiClient;

        internal IpRestrictions(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new IP restriction
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-restrictions-create
        public async Task<IpRestriction> Create(IpRestrictionCreate arg)
        {
            Dictionary<string, string> query = null;
            IpRestrictionCreate body = null;
            body = arg;

            return await apiClient.Do<IpRestriction>(
                  path: $"/ip_restrictions",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete an IP restriction
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-restrictions-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/ip_restrictions/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get detailed information about an IP restriction
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-restrictions-get
        public async Task<IpRestriction> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<IpRestriction>(
                  path: $"/ip_restrictions/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<IpRestrictionList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<IpRestrictionList>(
                  path: $"/ip_restrictions",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all IP restrictions on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-restrictions-list
        public IEnumerable<IpRestriction> List(string limit = null, string beforeId = null)
        {
            return new Iterator<IpRestriction>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.IpRestrictions;
            });
        }

        // <summary>
        // Update attributes of an IP restriction by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-restrictions-update
        public async Task<IpRestriction> Update(IpRestrictionUpdate arg)
        {
            Dictionary<string, string> query = null;
            IpRestrictionUpdate body = null;
            body = arg;

            return await apiClient.Do<IpRestriction>(
                  path: $"/ip_restrictions/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}

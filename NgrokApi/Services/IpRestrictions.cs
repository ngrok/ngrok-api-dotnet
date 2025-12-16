/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // An IP restriction is a restriction placed on the CIDRs that are allowed to
    //  initiate traffic to a specific aspect of your ngrok account. An IP
    //  restriction has a type which defines the ingress it applies to. IP
    //  restrictions can be used to enforce the source IPs that can make API
    //  requests, log in to the dashboard, start ngrok agents, and connect to your
    //  public-facing endpoints.
    // </summary>

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
            List<KeyValuePair<string, string>> query = null;
            IpRestrictionCreate body = arg;
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

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
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

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<IpRestriction>(
                path: $"/ip_restrictions/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<IpRestrictionList> ListPage(FilteredPaging arg)

        {
            List<KeyValuePair<string, string>> query = null;
            FilteredPaging body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            if (arg.BeforeId != null) queryParams.Add(new KeyValuePair<string, string>("before_id", arg.BeforeId));
            if (arg.Limit != null) queryParams.Add(new KeyValuePair<string, string>("limit", arg.Limit));
            if (arg.Filter != null) queryParams.Add(new KeyValuePair<string, string>("filter", arg.Filter));
            query = queryParams;
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
        public IAsyncEnumerable<IpRestriction> List(string limit = null, string beforeId = null)
        {
            return new Iterator<IpRestriction>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new FilteredPaging()
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
            List<KeyValuePair<string, string>> query = null;
            IpRestrictionUpdate body = arg;
            return await apiClient.Do<IpRestriction>(
                path: $"/ip_restrictions/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}

/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // IP Policies are reusable groups of CIDR ranges with an <c>allow</c> or
    // <c>deny</c>
    //  action. They can be attached to endpoints via the Endpoint Configuration IP
    //  Policy module. They can also be used with IP Restrictions to control source
    //  IP ranges that can start tunnel sessions and connect to the API and dashboard.
    // </summary>

    public class IpPolicies
    {
        private IApiHttpClient apiClient;

        internal IpPolicies(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new IP policy. It will not apply to any traffic until you associate to
        // a traffic source via an endpoint configuration or IP restriction.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-policies-create
        public async Task<IpPolicy> Create(IpPolicyCreate arg)
        {
            Dictionary<string, string> query = null;
            IpPolicyCreate body = arg;
            return await apiClient.Do<IpPolicy>(
                path: $"/ip_policies",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete an IP policy. If the IP policy is referenced by another object for the
        // purposes of traffic restriction it will be treated as if the IP policy remains
        // but has zero rules.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-policies-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/ip_policies/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get detailed information about an IP policy by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-policies-get
        public async Task<IpPolicy> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<IpPolicy>(
                path: $"/ip_policies/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<IpPolicyList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<IpPolicyList>(
                path: $"/ip_policies",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all IP policies on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-policies-list
        public IAsyncEnumerable<IpPolicy> List(string limit = null, string beforeId = null)
        {
            return new Iterator<IpPolicy>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.IpPolicies;
            });
        }

        // <summary>
        // Update attributes of an IP policy by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-policies-update
        public async Task<IpPolicy> Update(IpPolicyUpdate arg)
        {
            Dictionary<string, string> query = null;
            IpPolicyUpdate body = arg;
            return await apiClient.Do<IpPolicy>(
                path: $"/ip_policies/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}

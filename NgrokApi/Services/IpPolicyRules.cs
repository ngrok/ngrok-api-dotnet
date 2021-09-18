
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // IP Policy Rules are the IPv4 or IPv6 CIDRs entries that
    //  make up an IP Policy.
    // </summary>

    public class IpPolicyRules
    {
        private IApiHttpClient apiClient;

        internal IpPolicyRules(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new IP policy rule attached to an IP Policy.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-policy-rules-create
        public async Task<IpPolicyRule> Create(IpPolicyRuleCreate arg)
        {
            Dictionary<string, string> query = null;
            IpPolicyRuleCreate body = null;
            body = arg;

            return await apiClient.Do<IpPolicyRule>(
                  path: $"/ip_policy_rules",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete an IP policy rule.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-policy-rules-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/ip_policy_rules/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get detailed information about an IP policy rule by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-policy-rules-get
        public async Task<IpPolicyRule> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<IpPolicyRule>(
                  path: $"/ip_policy_rules/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<IpPolicyRuleList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<IpPolicyRuleList>(
                  path: $"/ip_policy_rules",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all IP policy rules on this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-policy-rules-list
        public IAsyncEnumerable<IpPolicyRule> List(string limit = null, string beforeId = null)
        {
            return new Iterator<IpPolicyRule>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.IpPolicyRules;
            });
        }

        // <summary>
        // Update attributes of an IP policy rule by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-ip-policy-rules-update
        public async Task<IpPolicyRule> Update(IpPolicyRuleUpdate arg)
        {
            Dictionary<string, string> query = null;
            IpPolicyRuleUpdate body = null;
            body = arg;

            return await apiClient.Do<IpPolicyRule>(
                  path: $"/ip_policy_rules/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}

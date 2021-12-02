
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class AgentIngresses
    {
        private IApiHttpClient apiClient;

        internal AgentIngresses(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new Agent Ingress. The ngrok agent can be configured to connect to
        // ngrok via the new set of addresses on the returned Agent Ingress.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-agent-ingresses-create
        public async Task<AgentIngress> Create(AgentIngressCreate arg)
        {
            Dictionary<string, string> query = null;
            AgentIngressCreate body = null;
            body = arg;

            return await apiClient.Do<AgentIngress>(
                  path: $"/agent_ingresses",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete an Agent Ingress by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-agent-ingresses-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/agent_ingresses/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get the details of an Agent Ingress by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-agent-ingresses-get
        public async Task<AgentIngress> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<AgentIngress>(
                  path: $"/agent_ingresses/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<AgentIngressList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<AgentIngressList>(
                  path: $"/agent_ingresses",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all Agent Ingresses owned by this account
        // </summary>
        //
        // https://ngrok.com/docs/api#api-agent-ingresses-list
        public IAsyncEnumerable<AgentIngress> List(string limit = null, string beforeId = null)
        {
            return new Iterator<AgentIngress>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.Ingresses;
            });
        }

        // <summary>
        // Update attributes of an Agent Ingress by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-agent-ingresses-update
        public async Task<AgentIngress> Update(AgentIngressUpdate arg)
        {
            Dictionary<string, string> query = null;
            AgentIngressUpdate body = null;
            body = arg;

            return await apiClient.Do<AgentIngress>(
                  path: $"/agent_ingresses/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class TunnelSessions
    {
        private IApiHttpClient apiClient;

        internal TunnelSessions(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        private async Task<TunnelSessionList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<TunnelSessionList>(
                  path: $"/tunnel_sessions",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all online tunnel sessions running on this account.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnel-sessions-list
        public IEnumerable<TunnelSession> List(string limit = null, string beforeId = null)
        {
            return new Iterator<TunnelSession>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.TunnelSessions;
            });
        }

        // <summary>
        // Get the detailed status of a tunnel session by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnel-sessions-get
        public async Task<TunnelSession> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<TunnelSession>(
                  path: $"/tunnel_sessions/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Issues a command instructing the ngrok agent to restart. The agent restarts
        // itself by calling exec() on platforms that support it. This operation is notably
        // not supported on Windows. When an agent restarts, it reconnects with a new
        // tunnel session ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnel-sessions-restart
        public async Task Restart(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            body = arg;

            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/tunnel_sessions/{arg.Id}/restart",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Issues a command instructing the ngrok agent that started this tunnel session to
        // exit.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnel-sessions-stop
        public async Task Stop(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            body = arg;

            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/tunnel_sessions/{arg.Id}/stop",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Issues a command instructing the ngrok agent to update itself to the latest
        // version. After this call completes successfully, the ngrok agent will be in the
        // update process. A caller should wait some amount of time to allow the update to
        // complete (at least 10 seconds) before making a call to the Restart endpoint to
        // request that the agent restart itself to start using the new code. This call
        // will never update an ngrok agent to a new major version which could cause
        // breaking compatibility issues. If you wish to update to a new major version,
        // that must be done manually. Still, please be aware that updating your ngrok
        // agent could break your integration. This call will fail in any of the following
        // circumstances: there is no update available the ngrok agent's configuration
        // disabled update checks the agent is currently in process of updating the agent
        // has already successfully updated but has not yet been restarted
        // </summary>
        //
        // https://ngrok.com/docs/api#api-tunnel-sessions-update
        public async Task Update(string id)
        {
            var arg = new TunnelSessionsUpdate() { Id = id };

            Dictionary<string, string> query = null;
            TunnelSessionsUpdate body = null;
            body = arg;

            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/tunnel_sessions/{arg.Id}/update",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );
        }
    }
}

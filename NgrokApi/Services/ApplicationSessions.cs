/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class ApplicationSessions
    {
        private IApiHttpClient apiClient;

        internal ApplicationSessions(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Get an application session by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-application-sessions-get
        public async Task<ApplicationSession> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<ApplicationSession>(
                path: $"/app/sessions/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete an application session by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-application-sessions-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/app/sessions/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        private async Task<ApplicationSessionList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<ApplicationSessionList>(
                path: $"/app/sessions",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all application sessions for this account.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-application-sessions-list
        public IAsyncEnumerable<ApplicationSession> List(string limit = null, string beforeId = null)
        {
            return new Iterator<ApplicationSession>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.ApplicationSessions;
            });
        }
    }
}

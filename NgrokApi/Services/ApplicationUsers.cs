/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class ApplicationUsers
    {
        private IApiHttpClient apiClient;

        internal ApplicationUsers(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Get an application user by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-application-users-get
        public async Task<ApplicationUser> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<ApplicationUser>(
                path: $"/app/users/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete an application user by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-application-users-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/app/users/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        private async Task<ApplicationUserList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<ApplicationUserList>(
                path: $"/app/users",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all application users for this account.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-application-users-list
        public IAsyncEnumerable<ApplicationUser> List(string limit = null, string beforeId = null)
        {
            return new Iterator<ApplicationUser>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.ApplicationUsers;
            });
        }
    }
}

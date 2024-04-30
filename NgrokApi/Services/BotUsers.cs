/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class BotUsers
    {
        private IApiHttpClient apiClient;

        internal BotUsers(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new bot user
        // </summary>
        //
        // https://ngrok.com/docs/api#api-bot-users-create
        public async Task<BotUser> Create(BotUserCreate arg)
        {
            Dictionary<string, string> query = null;
            BotUserCreate body = arg;
            return await apiClient.Do<BotUser>(
                path: $"/bot_users",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete a bot user by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-bot-users-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/bot_users/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get the details of a Bot User by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-bot-users-get
        public async Task<BotUser> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<BotUser>(
                path: $"/bot_users/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<BotUserList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<BotUserList>(
                path: $"/bot_users",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all bot users in this account.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-bot-users-list
        public IAsyncEnumerable<BotUser> List(string limit = null, string beforeId = null)
        {
            return new Iterator<BotUser>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.BotUsers;
            });
        }

        // <summary>
        // Update attributes of a bot user by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-bot-users-update
        public async Task<BotUser> Update(BotUserUpdate arg)
        {
            Dictionary<string, string> query = null;
            BotUserUpdate body = arg;
            return await apiClient.Do<BotUser>(
                path: $"/bot_users/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}

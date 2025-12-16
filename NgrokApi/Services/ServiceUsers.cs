/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class ServiceUsers
    {
        private IApiHttpClient apiClient;

        internal ServiceUsers(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new service user
        // </summary>
        //
        // https://ngrok.com/docs/api#api-service-users-create
        public async Task<ServiceUser> Create(ServiceUserCreate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            ServiceUserCreate body = arg;
            return await apiClient.Do<ServiceUser>(
                path: $"/service_users",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete a service user by ID
        // </summary>
        //
        // https://ngrok.com/docs/api#api-service-users-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/service_users/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get the details of a Bot User by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-service-users-get
        public async Task<ServiceUser> Get(string id)
        {
            var arg = new Item() { Id = id };

            List<KeyValuePair<string, string>> query = null;
            Item body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            query = queryParams;
            return await apiClient.Do<ServiceUser>(
                path: $"/service_users/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<ServiceUserList> ListPage(FilteredPaging arg)

        {
            List<KeyValuePair<string, string>> query = null;
            FilteredPaging body = null;
            var queryParams = new List<KeyValuePair<string, string>>();
            if (arg.BeforeId != null) queryParams.Add(new KeyValuePair<string, string>("before_id", arg.BeforeId));
            if (arg.Limit != null) queryParams.Add(new KeyValuePair<string, string>("limit", arg.Limit));
            if (arg.Filter != null) queryParams.Add(new KeyValuePair<string, string>("filter", arg.Filter));
            query = queryParams;
            return await apiClient.Do<ServiceUserList>(
                path: $"/service_users",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all service users in this account.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-service-users-list
        public IAsyncEnumerable<ServiceUser> List(string limit = null, string beforeId = null)
        {
            return new Iterator<ServiceUser>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new FilteredPaging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.ServiceUsers;
            });
        }

        // <summary>
        // Update attributes of a service user by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-service-users-update
        public async Task<ServiceUser> Update(ServiceUserUpdate arg)
        {
            List<KeyValuePair<string, string>> query = null;
            ServiceUserUpdate body = arg;
            return await apiClient.Do<ServiceUser>(
                path: $"/service_users/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    // <summary>
    // Reserved Addresses are TCP addresses that can be used to listen for traffic.
    //  TCP address hostnames and ports are assigned by ngrok, they cannot be
    //  chosen.
    // </summary>

    public class ReservedAddrs
    {
        private IApiHttpClient apiClient;

        internal ReservedAddrs(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new reserved address.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-addrs-create
        public async Task<ReservedAddr> Create(ReservedAddrCreate arg)
        {
            Dictionary<string, string> query = null;
            ReservedAddrCreate body = arg;
            return await apiClient.Do<ReservedAddr>(
                  path: $"/reserved_addrs",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete a reserved address.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-addrs-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"/reserved_addrs/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get the details of a reserved address.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-addrs-get
        public async Task<ReservedAddr> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<ReservedAddr>(
                  path: $"/reserved_addrs/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<ReservedAddrList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<ReservedAddrList>(
                  path: $"/reserved_addrs",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all reserved addresses on this account.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-addrs-list
        public IAsyncEnumerable<ReservedAddr> List(string limit = null, string beforeId = null)
        {
            return new Iterator<ReservedAddr>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.ReservedAddrs;
            });
        }

        // <summary>
        // Update the attributes of a reserved address.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-reserved-addrs-update
        public async Task<ReservedAddr> Update(ReservedAddrUpdate arg)
        {
            Dictionary<string, string> query = null;
            ReservedAddrUpdate body = arg;
            return await apiClient.Do<ReservedAddr>(
                  path: $"/reserved_addrs/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}

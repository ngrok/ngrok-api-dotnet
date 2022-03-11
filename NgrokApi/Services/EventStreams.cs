
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EventStreams
    {
        private IApiHttpClient apiClient;

        internal EventStreams(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new Event Stream. It will not apply to anything until you associate it
        // with one or more Endpoint Configs.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-streams-create
        public async Task<EventStream> Create(EventStreamCreate arg)
        {
            Dictionary<string, string> query = null;
            EventStreamCreate body = null;
            body = arg;

            return await apiClient.Do<EventStream>(
                  path: $"event_streams",
                  method: new HttpMethod("post"),
                  body: body,
                  query: query
            );

        }

        // <summary>
        // Delete an Event Stream. Associated Event Destinations will be preserved.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-streams-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                  path: $"event_streams/{arg.Id}",
                  method: new HttpMethod("delete"),
                  body: body,
                  query: query
            );
        }

        // <summary>
        // Get detailed information about an Event Stream by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-streams-get
        public async Task<EventStream> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EventStream>(
                  path: $"event_streams/{arg.Id}",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }

        private async Task<EventStreamList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<EventStreamList>(
                  path: $"event_streams",
                  method: new HttpMethod("get"),
                  body: body,
                  query: query
            );

        }
        // <summary>
        // List all Event Streams available on this account.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-streams-list
        public IAsyncEnumerable<EventStream> List(string limit = null, string beforeId = null)
        {
            return new Iterator<EventStream>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.EventStreams;
            });
        }

        // <summary>
        // Update attributes of an Event Stream by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-streams-update
        public async Task<EventStream> Update(EventStreamUpdate arg)
        {
            Dictionary<string, string> query = null;
            EventStreamUpdate body = null;
            body = arg;

            return await apiClient.Do<EventStream>(
                  path: $"event_streams/{arg.Id}",
                  method: new HttpMethod("patch"),
                  body: body,
                  query: query
            );

        }
    }
}

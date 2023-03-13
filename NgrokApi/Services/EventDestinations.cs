
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EventDestinations
    {
        private IApiHttpClient apiClient;

        internal EventDestinations(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create a new Event Destination. It will not apply to anything until it is
        // associated with an Event Subscription.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-destinations-create
        public async Task<EventDestination> Create(EventDestinationCreate arg)
        {
            Dictionary<string, string> query = null;
            EventDestinationCreate body = arg;
            return await apiClient.Do<EventDestination>(
                path: $"/event_destinations",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete an Event Destination. If the Event Destination is still referenced by an
        // Event Subscription.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-destinations-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/event_destinations/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get detailed information about an Event Destination by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-destinations-get
        public async Task<EventDestination> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EventDestination>(
                path: $"/event_destinations/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<EventDestinationList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<EventDestinationList>(
                path: $"/event_destinations",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List all Event Destinations on this account.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-destinations-list
        public IAsyncEnumerable<EventDestination> List(string limit = null, string beforeId = null)
        {
            return new Iterator<EventDestination>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.EventDestinations;
            });
        }

        // <summary>
        // Update attributes of an Event Destination.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-destinations-update
        public async Task<EventDestination> Update(EventDestinationUpdate arg)
        {
            Dictionary<string, string> query = null;
            EventDestinationUpdate body = arg;
            return await apiClient.Do<EventDestination>(
                path: $"/event_destinations/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}

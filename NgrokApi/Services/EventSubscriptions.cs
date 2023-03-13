
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EventSubscriptions
    {
        private IApiHttpClient apiClient;

        internal EventSubscriptions(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Create an Event Subscription.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-subscriptions-create
        public async Task<EventSubscription> Create(EventSubscriptionCreate arg)
        {
            Dictionary<string, string> query = null;
            EventSubscriptionCreate body = arg;
            return await apiClient.Do<EventSubscription>(
                path: $"/event_subscriptions",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Delete an Event Subscription.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-subscriptions-delete
        public async Task Delete(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/event_subscriptions/{arg.Id}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get an Event Subscription by ID.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-subscriptions-get
        public async Task<EventSubscription> Get(string id)
        {
            var arg = new Item() { Id = id };

            Dictionary<string, string> query = null;
            Item body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EventSubscription>(
                path: $"/event_subscriptions/{arg.Id}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        private async Task<EventSubscriptionList> ListPage(Paging arg)

        {
            Dictionary<string, string> query = null;
            Paging body = null;
            query = new Dictionary<string, string>()
            {
                ["before_id"] = arg.BeforeId,
                ["limit"] = arg.Limit,
            };
            return await apiClient.Do<EventSubscriptionList>(
                path: $"/event_subscriptions",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }
        // <summary>
        // List this Account's Event Subscriptions.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-subscriptions-list
        public IAsyncEnumerable<EventSubscription> List(string limit = null, string beforeId = null)
        {
            return new Iterator<EventSubscription>(beforeId, async lastId =>
            {
                var result = await this.ListPage(new Paging()
                {
                    BeforeId = lastId,
                    Limit = limit,
                });
                return result.EventSubscriptions;
            });
        }

        // <summary>
        // Update an Event Subscription.
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-subscriptions-update
        public async Task<EventSubscription> Update(EventSubscriptionUpdate arg)
        {
            Dictionary<string, string> query = null;
            EventSubscriptionUpdate body = arg;
            return await apiClient.Do<EventSubscription>(
                path: $"/event_subscriptions/{arg.Id}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}

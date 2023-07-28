/* Code generated for API Clients. DO NOT EDIT. */


using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NgrokApi
{

    public class EventSources
    {
        private IApiHttpClient apiClient;

        internal EventSources(IApiHttpClient apiClient)
        {
            this.apiClient = apiClient;
        }

        // <summary>
        // Add an additional type for which this event subscription will trigger
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-sources-create
        public async Task<EventSource> Create(EventSourceCreate arg)
        {
            Dictionary<string, string> query = null;
            EventSourceCreate body = arg;
            return await apiClient.Do<EventSource>(
                path: $"/event_subscriptions/{arg.SubscriptionId}/sources",
                method: new HttpMethod("post"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Remove a type for which this event subscription will trigger
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-sources-delete
        public async Task Delete(EventSourceItem arg)
        {
            Dictionary<string, string> query = null;
            EventSourceItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            await apiClient.DoNoReturnBody<Empty>(
                path: $"/event_subscriptions/{arg.SubscriptionId}/sources/{arg.Type}",
                method: new HttpMethod("delete"),
                body: body,
                query: query
            );
        }

        // <summary>
        // Get the details for a given type that triggers for the given event subscription
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-sources-get
        public async Task<EventSource> Get(EventSourceItem arg)
        {
            Dictionary<string, string> query = null;
            EventSourceItem body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EventSource>(
                path: $"/event_subscriptions/{arg.SubscriptionId}/sources/{arg.Type}",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        // <summary>
        // List the types for which this event subscription will trigger
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-sources-list
        public async Task<EventSourceList> List(string subscriptionId)
        {
            var arg = new EventSourcePaging() { SubscriptionId = subscriptionId };

            Dictionary<string, string> query = null;
            EventSourcePaging body = null;
            query = new Dictionary<string, string>()
            {
            };
            return await apiClient.Do<EventSourceList>(
                path: $"/event_subscriptions/{arg.SubscriptionId}/sources",
                method: new HttpMethod("get"),
                body: body,
                query: query
            );

        }

        // <summary>
        // Update the type for which this event subscription will trigger
        // </summary>
        //
        // https://ngrok.com/docs/api#api-event-sources-update
        public async Task<EventSource> Update(EventSourceUpdate arg)
        {
            Dictionary<string, string> query = null;
            EventSourceUpdate body = arg;
            return await apiClient.Do<EventSource>(
                path: $"/event_subscriptions/{arg.SubscriptionId}/sources/{arg.Type}",
                method: new HttpMethod("patch"),
                body: body,
                query: query
            );

        }
    }
}

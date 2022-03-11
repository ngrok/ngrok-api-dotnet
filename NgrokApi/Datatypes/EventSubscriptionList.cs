using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EventSubscriptionList
    {
        // <summary>
        // The list of all Event Subscriptions on this account.
        // </summary>
        [JsonPropertyName("event_subscriptions")]
        public List<EventSubscription> EventSubscriptions { get; set; }
        // <summary>
        // URI of the Event Subscriptions list API resource.
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        // <summary>
        // URI of next page, or null if there is no next page.
        // </summary>
        [JsonPropertyName("next_page_uri")]
        public string NextPageUri { get; set; }

        public override string ToString()
        {
            return $"EventSubscriptionList EventSubscriptions={ EventSubscriptions }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (EventSubscriptions?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventSubscriptionList)obj;
            return (
                 this.EventSubscriptions == other.EventSubscriptions
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}

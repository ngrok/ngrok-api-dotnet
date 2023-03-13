
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventSubscriptionList
    {
        // <summary>
        // The list of all Event Subscriptions on this account.
        // </summary>
        [JsonProperty("event_subscriptions")]
        public List<EventSubscription> EventSubscriptions { get; set; }
        // <summary>
        // URI of the Event Subscriptions list API resource.
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // URI of next page, or null if there is no next page.
        // </summary>
        [JsonProperty("next_page_uri")]
        public Uri NextPageUri { get; set; }

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
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EventSubscriptionList)obj;
            return (
                 this.EventSubscriptions == other.EventSubscriptions
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventSubscription : HasId
    {
        // <summary>
        // Unique identifier for this Event Subscription.
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the Event Subscription API resource.
        // </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
        // <summary>
        // When the Event Subscription was created (RFC 3339 format).
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // Arbitrary customer supplied information intended to be machine readable.
        // Optional, max 4096 chars.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // Arbitrary customer supplied information intended to be human readable. Optional,
        // max 255 chars.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // Sources containing the types for which this event subscription will trigger
        // </summary>
        [JsonProperty("sources")]
        public List<EventSource> Sources { get; set; }
        // <summary>
        // Destinations to which these events will be sent
        // </summary>
        [JsonProperty("destinations")]
        public List<Ref> Destinations { get; set; }

        public override string ToString()
        {
            return $"EventSubscription Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Metadata={ Metadata }  Description={ Description }  Sources={ Sources }  Destinations={ Destinations } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Sources?.GetHashCode() ?? 0);

                hash = hash * 23 + (Destinations?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventSubscription)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Metadata == other.Metadata
                && this.Description == other.Description
                && this.Sources == other.Sources
                && this.Destinations == other.Destinations
            );
        }

    }
}

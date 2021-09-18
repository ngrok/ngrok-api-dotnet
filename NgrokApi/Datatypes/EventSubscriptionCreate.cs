
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventSubscriptionCreate
    {
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
        public List<EventSourceReplace> Sources { get; set; }
        // <summary>
        // A list of Event Destination IDs which should be used for this Event Stream.
        // Event Streams are required to have at least one Event Destination.
        // </summary>
        [JsonProperty("destination_ids")]
        public List<string> DestinationIds { get; set; }

        public override string ToString()
        {
            return $"EventSubscriptionCreate Metadata={ Metadata }  Description={ Description }  Sources={ Sources }  DestinationIds={ DestinationIds } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Sources?.GetHashCode() ?? 0);

                hash = hash * 23 + (DestinationIds?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventSubscriptionCreate)obj;
            return (
                 this.Metadata == other.Metadata
                && this.Description == other.Description
                && this.Sources == other.Sources
                && this.DestinationIds == other.DestinationIds
            );
        }

    }
}

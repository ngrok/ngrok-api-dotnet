
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventStreamUpdate : HasId
    {
        // <summary>
        // Unique identifier for this Event Stream.
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // Arbitrary user-defined machine-readable data of this Event Stream. Optional, max
        // 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // Human-readable description of the Event Stream. Optional, max 255 bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // A list of protocol-specific fields you want to collect on each event.
        // </summary>
        [JsonProperty("fields")]
        public List<string> Fields { get; set; }
        // <summary>
        // A list of Event Destination IDs which should be used for this Event Stream.
        // Event Streams are required to have at least one Event Destination.
        // </summary>
        [JsonProperty("destination_ids")]
        public List<string> DestinationIds { get; set; }
        // <summary>
        // The percentage of all events you would like to capture. Valid values range from
        // 0.01, representing 1% of all events to 1.00, representing 100% of all events.
        // </summary>
        [JsonProperty("sampling_rate")]
        public double? SamplingRate { get; set; }

        public override string ToString()
        {
            return $"EventStreamUpdate Id={ Id }  Metadata={ Metadata }  Description={ Description }  Fields={ Fields }  DestinationIds={ DestinationIds }  SamplingRate={ SamplingRate } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Fields?.GetHashCode() ?? 0);

                hash = hash * 23 + (DestinationIds?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(SamplingRate);
                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventStreamUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Metadata == other.Metadata
                && this.Description == other.Description
                && this.Fields == other.Fields
                && this.DestinationIds == other.DestinationIds
                && this.SamplingRate == other.SamplingRate
            );
        }

    }
}

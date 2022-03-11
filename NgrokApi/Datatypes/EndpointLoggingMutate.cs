
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EndpointLoggingMutate
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // list of all EventStreams that will be used to configure and export this
        // endpoint's logs
        // </summary>
        [JsonPropertyName("event_stream_ids")]
        public List<string> EventStreamIds { get; set; }

        public override string ToString()
        {
            return $"EndpointLoggingMutate Enabled={ Enabled }  EventStreamIds={ EventStreamIds } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (EventStreamIds?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointLoggingMutate)obj;
            return (
                 this.Enabled == other.Enabled
                && this.EventStreamIds == other.EventStreamIds
            );
        }

    }
}

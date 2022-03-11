using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EventSourceList
    {
        // <summary>
        // The list of all Event Sources for an Event Subscription
        // </summary>
        [JsonPropertyName("sources")]
        public List<EventSource> Sources { get; set; }
        // <summary>
        // URI of the next page, or null if there is no next page.
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        public override string ToString()
        {
            return $"EventSourceList Sources={ Sources }  Uri={ Uri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Sources?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventSourceList)obj;
            return (
                 this.Sources == other.Sources
                && this.Uri == other.Uri
            );
        }

    }
}

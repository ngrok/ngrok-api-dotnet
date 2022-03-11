using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EventDestinationList
    {
        // <summary>
        // The list of all Event Destinations on this account.
        // </summary>
        [JsonPropertyName("event_destinations")]
        public List<EventDestination> EventDestinations { get; set; }
        // <summary>
        // URI of the Event Destinations list API resource.
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        // <summary>
        // URI of the next page, or null if there is no next page.
        // </summary>
        [JsonPropertyName("next_page_uri")]
        public string NextPageUri { get; set; }

        public override string ToString()
        {
            return $"EventDestinationList EventDestinations={ EventDestinations }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (EventDestinations?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventDestinationList)obj;
            return (
                 this.EventDestinations == other.EventDestinations
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}

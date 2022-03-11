using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EventSource
    {
        // <summary>
        // Type of event for which an event subscription will trigger
        // </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        // <summary>
        // URI of the Event Source API resource.
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        public override string ToString()
        {
            return $"EventSource Type={ Type }  Uri={ Uri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Type?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventSource)obj;
            return (
                 this.Type == other.Type
                && this.Uri == other.Uri
            );
        }

    }
}

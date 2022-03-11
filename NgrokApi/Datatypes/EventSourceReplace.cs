using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EventSourceReplace
    {
        // <summary>
        // Type of event for which an event subscription will trigger
        // </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        public override string ToString()
        {
            return $"EventSourceReplace Type={ Type } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Type?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventSourceReplace)obj;
            return (
                 this.Type == other.Type
            );
        }

    }
}

using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EventSourceUpdate
    {
        // <summary>
        // The unique identifier for the Event Subscription that this Event Source is
        // attached to.
        // </summary>
        [JsonPropertyName("subscription_id")]
        public string SubscriptionId { get; set; }
        // <summary>
        // Type of event for which an event subscription will trigger
        // </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        public override string ToString()
        {
            return $"EventSourceUpdate SubscriptionId={ SubscriptionId }  Type={ Type } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (SubscriptionId?.GetHashCode() ?? 0);

                hash = hash * 23 + (Type?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventSourceUpdate)obj;
            return (
                 this.SubscriptionId == other.SubscriptionId
                && this.Type == other.Type
            );
        }

    }
}

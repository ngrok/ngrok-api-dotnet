
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventSourceCreate
    {
        // <summary>
        // The unique identifier for the Event Subscription that this Event Source is
        // attached to.
        // </summary>
        [JsonProperty("subscription_id")]
        public string SubscriptionId { get; set; }
        // <summary>
        // Type of event for which an event subscription will trigger
        // </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        public override string ToString()
        {
            return $"EventSourceCreate SubscriptionId={ SubscriptionId }  Type={ Type } ";
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
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EventSourceCreate)obj;
            return (
                 this.SubscriptionId == other.SubscriptionId
                && this.Type == other.Type
            );
        }

    }
}

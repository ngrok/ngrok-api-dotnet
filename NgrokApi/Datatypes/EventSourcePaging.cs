
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    // This is needed instead of Paging because the parameters are different. We also don't need the typical pagination params because pagination of this isn't necessary or supported.
    public class EventSourcePaging
    {
        // <summary>
        // The unique identifier for the Event Subscription that this Event Source is
        // attached to.
        // </summary>
        [JsonProperty("subscription_id")]
        public string SubscriptionId { get; set; }

        public override string ToString()
        {
            return $"EventSourcePaging SubscriptionId={ SubscriptionId } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (SubscriptionId?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EventSourcePaging)obj;
            return (
                 this.SubscriptionId == other.SubscriptionId
            );
        }

    }
}


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventSourceReplace
    {
        // <summary>
        // Type of event for which an event subscription will trigger
        // </summary>
        [JsonProperty("type")]
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
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EventSourceReplace)obj;
            return (
                 this.Type == other.Type
            );
        }

    }
}

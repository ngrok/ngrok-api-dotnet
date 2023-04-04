
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventSource
    {
        // <summary>
        // Type of event for which an event subscription will trigger
        // </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        // <summary>
        // URI of the Event Source API resource.
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }

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
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EventSource)obj;
            return (
                 this.Type == other.Type
                && this.Uri == other.Uri
            );
        }

    }
}

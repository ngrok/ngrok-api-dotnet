/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EventTargetDatadog
    {
        // <summary>
        // Datadog API key to use.
        // </summary>
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }
        // <summary>
        // Tags to send with the event.
        // </summary>
        [JsonProperty("ddtags")]
        public string Ddtags { get; set; }
        // <summary>
        // Service name to send with the event.
        // </summary>
        [JsonProperty("service")]
        public string Service { get; set; }
        // <summary>
        // Datadog site to send event to.
        // </summary>
        [JsonProperty("ddsite")]
        public string Ddsite { get; set; }

        public override string ToString()
        {
            return $"EventTargetDatadog ApiKey={ ApiKey }  Ddtags={ Ddtags }  Service={ Service }  Ddsite={ Ddsite } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ApiKey?.GetHashCode() ?? 0);

                hash = hash * 23 + (Ddtags?.GetHashCode() ?? 0);

                hash = hash * 23 + (Service?.GetHashCode() ?? 0);

                hash = hash * 23 + (Ddsite?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EventTargetDatadog)obj;
            return (
                 this.ApiKey == other.ApiKey
                && this.Ddtags == other.Ddtags
                && this.Service == other.Service
                && this.Ddsite == other.Ddsite
            );
        }

    }
}

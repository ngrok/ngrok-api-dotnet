/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointUserAgentFilter
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        [JsonProperty("allow")]
        public List<string> Allow { get; set; }
        [JsonProperty("deny")]
        public List<string> Deny { get; set; }

        public override string ToString()
        {
            return $"EndpointUserAgentFilter Enabled={ Enabled }  Allow={ Allow }  Deny={ Deny } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (Allow?.GetHashCode() ?? 0);

                hash = hash * 23 + (Deny?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointUserAgentFilter)obj;
            return (
                 this.Enabled == other.Enabled
                && this.Allow == other.Allow
                && this.Deny == other.Deny
            );
        }

    }
}

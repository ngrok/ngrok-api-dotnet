/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointPolicy
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // the inbound rules of the traffic policy.
        // </summary>
        [JsonProperty("inbound")]
        public List<EndpointRule> Inbound { get; set; }
        // <summary>
        // the outbound rules on the traffic policy.
        // </summary>
        [JsonProperty("outbound")]
        public List<EndpointRule> Outbound { get; set; }

        public override string ToString()
        {
            return $"EndpointPolicy Enabled={ Enabled }  Inbound={ Inbound }  Outbound={ Outbound } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (Inbound?.GetHashCode() ?? 0);

                hash = hash * 23 + (Outbound?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointPolicy)obj;
            return (
                 this.Enabled == other.Enabled
                && this.Inbound == other.Inbound
                && this.Outbound == other.Outbound
            );
        }

    }
}

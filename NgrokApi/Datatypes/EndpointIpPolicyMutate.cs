
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointIpPolicyMutate
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // list of all IP policies that will be used to check if a source IP is allowed
        // access to the endpoint
        // </summary>
        [JsonProperty("ip_policy_ids")]
        public List<string> IpPolicyIds { get; set; }

        public override string ToString()
        {
            return $"EndpointIpPolicyMutate Enabled={ Enabled }  IpPolicyIds={ IpPolicyIds } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (IpPolicyIds?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointIpPolicyMutate)obj;
            return (
                 this.Enabled == other.Enabled
                && this.IpPolicyIds == other.IpPolicyIds
            );
        }

    }
}


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ReservedDomainCertNsTarget
    {
        // <summary>
        // the zone that the nameservers need to be applied to
        // </summary>
        [JsonProperty("zone")]
        public string Zone { get; set; }
        // <summary>
        // the nameservers the user must add
        // </summary>
        [JsonProperty("nameservers")]
        public List<string> Nameservers { get; set; }

        public override string ToString()
        {
            return $"ReservedDomainCertNsTarget Zone={ Zone }  Nameservers={ Nameservers } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Zone?.GetHashCode() ?? 0);

                hash = hash * 23 + (Nameservers?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ReservedDomainCertNsTarget)obj;
            return (
                 this.Zone == other.Zone
                && this.Nameservers == other.Nameservers
            );
        }

    }
}

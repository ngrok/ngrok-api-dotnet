
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class IpWhitelistEntryCreate
    {
        // <summary>
        // human-readable description of the source IPs for this IP whitelist entry.
        // optional, max 255 bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this IP whitelist entry.
        // optional, max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // an IP address or IP network range in CIDR notation (e.g. 10.1.1.1 or
        // 10.1.0.0/16) of addresses that will be whitelisted to communicate with your
        // tunnel endpoints
        // </summary>
        [JsonProperty("ip_net")]
        public string IpNet { get; set; }

        public override string ToString()
        {
            return $"IpWhitelistEntryCreate Description={ Description }  Metadata={ Metadata }  IpNet={ IpNet } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (IpNet?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (IpWhitelistEntryCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.IpNet == other.IpNet
            );
        }

    }
}

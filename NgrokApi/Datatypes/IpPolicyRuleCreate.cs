using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class IpPolicyRuleCreate
    {
        // <summary>
        // human-readable description of the source IPs of this IP rule. optional, max 255
        // bytes.
        // </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this IP policy rule. optional,
        // max 4096 bytes.
        // </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        // </summary>
        [JsonPropertyName("cidr")]
        public string Cidr { get; set; }
        // <summary>
        // ID of the IP policy this IP policy rule will be attached to
        // </summary>
        [JsonPropertyName("ip_policy_id")]
        public string IpPolicyId { get; set; }

        public override string ToString()
        {
            return $"IpPolicyRuleCreate Description={ Description }  Metadata={ Metadata }  Cidr={ Cidr }  IpPolicyId={ IpPolicyId } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Cidr?.GetHashCode() ?? 0);

                hash = hash * 23 + (IpPolicyId?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (IpPolicyRuleCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Cidr == other.Cidr
                && this.IpPolicyId == other.IpPolicyId
            );
        }

    }
}


using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class IpRestrictionCreate
    {
        // <summary>
        // human-readable description of this IP restriction. optional, max 255 bytes.
        // </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this IP restriction. optional,
        // max 4096 bytes.
        // </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // true if the IP restriction will be enforced. if false, only warnings will be
        // issued
        // </summary>
        [JsonPropertyName("enforced")]
        public bool Enforced { get; set; }
        // <summary>
        // the type of IP restriction. this defines what traffic will be restricted with
        // the attached policies. four values are currently supported: <c>dashboard</c>,
        // <c>api</c>, <c>agent</c>, and <c>endpoints</c>
        // </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        // <summary>
        // the set of IP policy identifiers that are used to enforce the restriction
        // </summary>
        [JsonPropertyName("ip_policy_ids")]
        public List<string> IpPolicyIds { get; set; }

        public override string ToString()
        {
            return $"IpRestrictionCreate Description={ Description }  Metadata={ Metadata }  Enforced={ Enforced }  Type={ Type }  IpPolicyIds={ IpPolicyIds } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(Enforced);
                hash = hash * 23 + (Type?.GetHashCode() ?? 0);

                hash = hash * 23 + (IpPolicyIds?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (IpRestrictionCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Enforced == other.Enforced
                && this.Type == other.Type
                && this.IpPolicyIds == other.IpPolicyIds
            );
        }

    }
}

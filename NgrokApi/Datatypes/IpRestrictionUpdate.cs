
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class IpRestrictionUpdate : HasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // human-readable description of this IP restriction. optional, max 255 bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this IP restriction. optional,
        // max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // true if the IP restriction will be enforced. if false, only warnings will be
        // issued
        // </summary>
        [JsonProperty("enforced")]
        public bool? Enforced { get; set; }
        // <summary>
        // the set of IP policy identifiers that are used to enforce the restriction
        // </summary>
        [JsonProperty("ip_policy_ids")]
        public List<string> IpPolicyIds { get; set; }

        public override string ToString()
        {
            return $"IpRestrictionUpdate Id={ Id }  Description={ Description }  Metadata={ Metadata }  Enforced={ Enforced }  IpPolicyIds={ IpPolicyIds } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(Enforced);
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
            var other = (IpRestrictionUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Enforced == other.Enforced
                && this.IpPolicyIds == other.IpPolicyIds
            );
        }

    }
}

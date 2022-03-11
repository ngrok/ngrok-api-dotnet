
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class IpRestriction : HasId
    {
        // <summary>
        // unique identifier for this IP restriction
        // </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the IP restriction API resource
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        // <summary>
        // timestamp when the IP restriction was created, RFC 3339 format
        // </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }
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
        // the set of IP policies that are used to enforce the restriction
        // </summary>
        [JsonPropertyName("ip_policies")]
        public List<Ref> IpPolicies { get; set; }

        public override string ToString()
        {
            return $"IpRestriction Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  Enforced={ Enforced }  Type={ Type }  IpPolicies={ IpPolicies } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(Enforced);
                hash = hash * 23 + (Type?.GetHashCode() ?? 0);

                hash = hash * 23 + (IpPolicies?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (IpRestriction)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Enforced == other.Enforced
                && this.Type == other.Type
                && this.IpPolicies == other.IpPolicies
            );
        }

    }
}

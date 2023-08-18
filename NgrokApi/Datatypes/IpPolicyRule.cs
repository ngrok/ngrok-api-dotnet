/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class IpPolicyRule : HasId
    {
        // <summary>
        // unique identifier for this IP policy rule
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the IP policy rule API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // timestamp when the IP policy rule was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // human-readable description of the source IPs of this IP rule. optional, max 255
        // bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this IP policy rule. optional,
        // max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        // </summary>
        [JsonProperty("cidr")]
        public string Cidr { get; set; }
        // <summary>
        // object describing the IP policy this IP Policy Rule belongs to
        // </summary>
        [JsonProperty("ip_policy")]
        public Ref IpPolicy { get; set; }
        // <summary>
        // the action to apply to the policy rule, either <c>allow</c> or <c>deny</c>
        // </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        public override string ToString()
        {
            return $"IpPolicyRule Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  Cidr={ Cidr }  IpPolicy={ IpPolicy }  Action={ Action } ";
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

                hash = hash * 23 + (Cidr?.GetHashCode() ?? 0);

                hash = hash * 23 + (IpPolicy?.GetHashCode() ?? 0);

                hash = hash * 23 + (Action?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (IpPolicyRule)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Cidr == other.Cidr
                && this.IpPolicy == other.IpPolicy
                && this.Action == other.Action
            );
        }

    }
}

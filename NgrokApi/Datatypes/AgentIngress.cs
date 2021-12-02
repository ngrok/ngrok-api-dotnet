
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class AgentIngress : HasId
    {
        // <summary>
        // unique Agent Ingress resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI to the API resource of this Agent ingress
        // </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
        // <summary>
        // human-readable description of the use of this Agent Ingress. optional, max 255
        // bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this Agent Ingress. optional,
        // max 4096 bytes
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // the domain that you own to be used as the base domain name to generate regional
        // agent ingress domains.
        // </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }
        // <summary>
        // a list of target values to use as the values of NS records for the domain
        // property these values will delegate control over the domain to ngrok
        // </summary>
        [JsonProperty("ns_targets")]
        public List<string> NsTargets { get; set; }
        // <summary>
        // a list of regional agent ingress domains that are subdomains of the value of
        // domain this value may increase over time as ngrok adds more regions
        // </summary>
        [JsonProperty("region_domains")]
        public List<string> RegionDomains { get; set; }
        // <summary>
        // timestamp when the Agent Ingress was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        public override string ToString()
        {
            return $"AgentIngress Id={ Id }  Uri={ Uri }  Description={ Description }  Metadata={ Metadata }  Domain={ Domain }  NsTargets={ NsTargets }  RegionDomains={ RegionDomains }  CreatedAt={ CreatedAt } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Domain?.GetHashCode() ?? 0);

                hash = hash * 23 + (NsTargets?.GetHashCode() ?? 0);

                hash = hash * 23 + (RegionDomains?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (AgentIngress)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Domain == other.Domain
                && this.NsTargets == other.NsTargets
                && this.RegionDomains == other.RegionDomains
                && this.CreatedAt == other.CreatedAt
            );
        }

    }
}

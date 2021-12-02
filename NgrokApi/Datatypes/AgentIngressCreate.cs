
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class AgentIngressCreate
    {
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

        public override string ToString()
        {
            return $"AgentIngressCreate Description={ Description }  Metadata={ Metadata }  Domain={ Domain } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Domain?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (AgentIngressCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Domain == other.Domain
            );
        }

    }
}

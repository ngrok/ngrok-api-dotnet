/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class AgentIngressUpdate : HasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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
        // configuration for automatic management of TLS certificates for this domain, or
        // null if automatic management is disabled. Optional.
        // </summary>
        [JsonProperty("certificate_management_policy")]
        public AgentIngressCertPolicy CertificateManagementPolicy { get; set; }

        public override string ToString()
        {
            return $"AgentIngressUpdate Id={ Id }  Description={ Description }  Metadata={ Metadata }  CertificateManagementPolicy={ CertificateManagementPolicy } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (CertificateManagementPolicy?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (AgentIngressUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.CertificateManagementPolicy == other.CertificateManagementPolicy
            );
        }

    }
}

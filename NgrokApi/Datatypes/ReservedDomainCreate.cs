/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ReservedDomainCreate
    {
        // <summary>
        // hostname of the reserved domain
        // </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }
        // <summary>
        // deprecated: With the launch of the ngrok Global Network domains traffic is now
        // handled globally. This field applied only to endpoints. Note that agents may
        // still connect to specific regions. Optional, null by default. (au, eu, ap, us,
        // jp, in, sa)
        // </summary>
        [JsonProperty("region")]
        public string Region { get; set; }
        // <summary>
        // human-readable description of what this reserved domain will be used for
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this reserved domain. Optional,
        // max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // ID of a user-uploaded TLS certificate to use for connections to targeting this
        // domain. Optional, mutually exclusive with <c>certificate_management_policy</c>.
        // </summary>
        [JsonProperty("certificate_id")]
        public string CertificateId { get; set; }
        // <summary>
        // configuration for automatic management of TLS certificates for this domain, or
        // null if automatic management is disabled. Optional, mutually exclusive with
        // <c>certificate_id</c>.
        // </summary>
        [JsonProperty("certificate_management_policy")]
        public ReservedDomainCertPolicy CertificateManagementPolicy { get; set; }

        public override string ToString()
        {
            return $"ReservedDomainCreate Domain={ Domain }  Region={ Region }  Description={ Description }  Metadata={ Metadata }  CertificateId={ CertificateId }  CertificateManagementPolicy={ CertificateManagementPolicy } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Domain?.GetHashCode() ?? 0);

                hash = hash * 23 + (Region?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (CertificateId?.GetHashCode() ?? 0);

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
            var other = (ReservedDomainCreate)obj;
            return (
                 this.Domain == other.Domain
                && this.Region == other.Region
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.CertificateId == other.CertificateId
                && this.CertificateManagementPolicy == other.CertificateManagementPolicy
            );
        }

    }
}

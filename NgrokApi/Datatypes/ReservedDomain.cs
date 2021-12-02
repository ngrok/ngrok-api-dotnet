
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ReservedDomain : HasId
    {
        // <summary>
        // unique reserved domain resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the reserved domain API resource
        // </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
        // <summary>
        // timestamp when the reserved domain was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
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
        // hostname of the reserved domain
        // </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }
        // <summary>
        // reserve the domain in this geographic ngrok datacenter. Optional, default is us.
        // (au, eu, ap, us, jp, in, sa)
        // </summary>
        [JsonProperty("region")]
        public string Region { get; set; }
        // <summary>
        // DNS CNAME target for a custom hostname, or null if the reserved domain is a
        // subdomain of *.ngrok.io
        // </summary>
        [JsonProperty("cname_target")]
        public string CnameTarget { get; set; }
        // <summary>
        // object referencing the endpoint configuration applied to http traffic on this
        // domain
        // </summary>
        [JsonProperty("http_endpoint_configuration")]
        public Ref HttpEndpointConfiguration { get; set; }
        // <summary>
        // object referencing the endpoint configuration applied to https traffic on this
        // domain
        // </summary>
        [JsonProperty("https_endpoint_configuration")]
        public Ref HttpsEndpointConfiguration { get; set; }
        // <summary>
        // object referencing the TLS certificate used for connections to this domain. This
        // can be either a user-uploaded certificate, the most recently issued automatic
        // one, or null otherwise.
        // </summary>
        [JsonProperty("certificate")]
        public Ref Certificate { get; set; }
        // <summary>
        // configuration for automatic management of TLS certificates for this domain, or
        // null if automatic management is disabled
        // </summary>
        [JsonProperty("certificate_management_policy")]
        public ReservedDomainCertPolicy CertificateManagementPolicy { get; set; }
        // <summary>
        // status of the automatic certificate management for this domain, or null if
        // automatic management is disabled
        // </summary>
        [JsonProperty("certificate_management_status")]
        public ReservedDomainCertStatus CertificateManagementStatus { get; set; }
        // <summary>
        // DNS CNAME target for the host _acme-challenge.example.com, where example.com is
        // your reserved domain name. This is required to issue certificates for wildcard,
        // non-ngrok reserved domains. Must be null for non-wildcard domains and ngrok
        // subdomains.
        // </summary>
        [JsonProperty("acme_challenge_cname_target")]
        public string AcmeChallengeCnameTarget { get; set; }

        public override string ToString()
        {
            return $"ReservedDomain Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  Domain={ Domain }  Region={ Region }  CnameTarget={ CnameTarget }  HttpEndpointConfiguration={ HttpEndpointConfiguration }  HttpsEndpointConfiguration={ HttpsEndpointConfiguration }  Certificate={ Certificate }  CertificateManagementPolicy={ CertificateManagementPolicy }  CertificateManagementStatus={ CertificateManagementStatus }  AcmeChallengeCnameTarget={ AcmeChallengeCnameTarget } ";
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

                hash = hash * 23 + (Domain?.GetHashCode() ?? 0);

                hash = hash * 23 + (Region?.GetHashCode() ?? 0);

                hash = hash * 23 + (CnameTarget?.GetHashCode() ?? 0);

                hash = hash * 23 + (HttpEndpointConfiguration?.GetHashCode() ?? 0);

                hash = hash * 23 + (HttpsEndpointConfiguration?.GetHashCode() ?? 0);

                hash = hash * 23 + (Certificate?.GetHashCode() ?? 0);

                hash = hash * 23 + (CertificateManagementPolicy?.GetHashCode() ?? 0);

                hash = hash * 23 + (CertificateManagementStatus?.GetHashCode() ?? 0);

                hash = hash * 23 + (AcmeChallengeCnameTarget?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ReservedDomain)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Domain == other.Domain
                && this.Region == other.Region
                && this.CnameTarget == other.CnameTarget
                && this.HttpEndpointConfiguration == other.HttpEndpointConfiguration
                && this.HttpsEndpointConfiguration == other.HttpsEndpointConfiguration
                && this.Certificate == other.Certificate
                && this.CertificateManagementPolicy == other.CertificateManagementPolicy
                && this.CertificateManagementStatus == other.CertificateManagementStatus
                && this.AcmeChallengeCnameTarget == other.AcmeChallengeCnameTarget
            );
        }

    }
}

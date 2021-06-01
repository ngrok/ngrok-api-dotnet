
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointConfiguration : HasId
    {
        // <summary>
        // unique identifier of this endpoint configuration
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // they type of traffic this endpoint configuration can be applied to. one of:
        // <c>http</c>, <c>https</c>, <c>tcp</c>
        // </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        // <summary>
        // human-readable description of what this endpoint configuration will be do when
        // applied or what traffic it will be applied to. Optional, max 255 bytes
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this endpoint configuration.
        // Optional, max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // timestamp when the endpoint configuration was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // URI of the endpoint configuration API resource
        // </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
        // <summary>
        // circuit breaker module configuration or <c>null</c>
        // </summary>
        [JsonProperty("circuit_breaker")]
        public EndpointCircuitBreaker CircuitBreaker { get; set; }
        // <summary>
        // compression module configuration or <c>null</c>
        // </summary>
        [JsonProperty("compression")]
        public EndpointCompression Compression { get; set; }
        // <summary>
        // request headers module configuration or <c>null</c>
        // </summary>
        [JsonProperty("request_headers")]
        public EndpointRequestHeaders RequestHeaders { get; set; }
        // <summary>
        // response headers module configuration or <c>null</c>
        // </summary>
        [JsonProperty("response_headers")]
        public EndpointResponseHeaders ResponseHeaders { get; set; }
        // <summary>
        // ip policy module configuration or <c>null</c>
        // </summary>
        [JsonProperty("ip_policy")]
        public EndpointIpPolicy IpPolicy { get; set; }
        // <summary>
        // mutual TLS module configuration or <c>null</c>
        // </summary>
        [JsonProperty("mutual_tls")]
        public EndpointMutualTls MutualTls { get; set; }
        // <summary>
        // TLS termination module configuration or <c>null</c>
        // </summary>
        [JsonProperty("tls_termination")]
        public EndpointTlsTermination TlsTermination { get; set; }
        // <summary>
        // webhook validation module configuration or <c>null</c>
        // </summary>
        [JsonProperty("webhook_validation")]
        public EndpointWebhookValidation WebhookValidation { get; set; }
        // <summary>
        // oauth module configuration or <c>null</c>
        // </summary>
        [JsonProperty("oauth")]
        public EndpointOAuth Oauth { get; set; }
        // <summary>
        // logging module configuration or <c>null</c>
        // </summary>
        [JsonProperty("logging")]
        public EndpointLogging Logging { get; set; }
        // <summary>
        // saml module configuration or <c>null</c>
        // </summary>
        [JsonProperty("saml")]
        public EndpointSaml Saml { get; set; }
        // <summary>
        // oidc module configuration or <c>null</c>
        // </summary>
        [JsonProperty("oidc")]
        public EndpointOidc Oidc { get; set; }

        public override string ToString()
        {
            return $"EndpointConfiguration Id={ Id }  Type={ Type }  Description={ Description }  Metadata={ Metadata }  CreatedAt={ CreatedAt }  Uri={ Uri }  CircuitBreaker={ CircuitBreaker }  Compression={ Compression }  RequestHeaders={ RequestHeaders }  ResponseHeaders={ ResponseHeaders }  IpPolicy={ IpPolicy }  MutualTls={ MutualTls }  TlsTermination={ TlsTermination }  WebhookValidation={ WebhookValidation }  Oauth={ Oauth }  Logging={ Logging }  Saml={ Saml }  Oidc={ Oidc } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Type?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (CircuitBreaker?.GetHashCode() ?? 0);

                hash = hash * 23 + (Compression?.GetHashCode() ?? 0);

                hash = hash * 23 + (RequestHeaders?.GetHashCode() ?? 0);

                hash = hash * 23 + (ResponseHeaders?.GetHashCode() ?? 0);

                hash = hash * 23 + (IpPolicy?.GetHashCode() ?? 0);

                hash = hash * 23 + (MutualTls?.GetHashCode() ?? 0);

                hash = hash * 23 + (TlsTermination?.GetHashCode() ?? 0);

                hash = hash * 23 + (WebhookValidation?.GetHashCode() ?? 0);

                hash = hash * 23 + (Oauth?.GetHashCode() ?? 0);

                hash = hash * 23 + (Logging?.GetHashCode() ?? 0);

                hash = hash * 23 + (Saml?.GetHashCode() ?? 0);

                hash = hash * 23 + (Oidc?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EndpointConfiguration)obj;
            return (
                 this.Id == other.Id
                && this.Type == other.Type
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.CreatedAt == other.CreatedAt
                && this.Uri == other.Uri
                && this.CircuitBreaker == other.CircuitBreaker
                && this.Compression == other.Compression
                && this.RequestHeaders == other.RequestHeaders
                && this.ResponseHeaders == other.ResponseHeaders
                && this.IpPolicy == other.IpPolicy
                && this.MutualTls == other.MutualTls
                && this.TlsTermination == other.TlsTermination
                && this.WebhookValidation == other.WebhookValidation
                && this.Oauth == other.Oauth
                && this.Logging == other.Logging
                && this.Saml == other.Saml
                && this.Oidc == other.Oidc
            );
        }

    }
}

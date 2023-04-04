
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class HttpsEdgeRoute : HasId
    {
        // <summary>
        // unique identifier of this edge
        // </summary>
        [JsonProperty("edge_id")]
        public string EdgeId { get; set; }
        // <summary>
        // unique identifier of this edge route
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // timestamp when the edge configuration was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // Type of match to use for this route. Valid values are "exact_path" and
        // "path_prefix".
        // </summary>
        [JsonProperty("match_type")]
        public string MatchType { get; set; }
        // <summary>
        // Route selector: "/blog" or "example.com" or "example.com/blog"
        // </summary>
        [JsonProperty("match")]
        public string Match { get; set; }
        // <summary>
        // URI of the edge API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // human-readable description of what this edge will be used for; optional, max 255
        // bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this edge. Optional, max 4096
        // bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // backend module configuration or <c>null</c>
        // </summary>
        [JsonProperty("backend")]
        public EndpointBackend Backend { get; set; }
        // <summary>
        // ip restriction module configuration or <c>null</c>
        // </summary>
        [JsonProperty("ip_restriction")]
        public EndpointIpPolicy IpRestriction { get; set; }
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
        // webhook verification module configuration or <c>null</c>
        // </summary>
        [JsonProperty("webhook_verification")]
        public EndpointWebhookValidation WebhookVerification { get; set; }
        // <summary>
        // oauth module configuration or <c>null</c>
        // </summary>
        [JsonProperty("oauth")]
        public EndpointOAuth Oauth { get; set; }
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
        // <summary>
        // websocket to tcp adapter configuration or <c>null</c>
        // </summary>
        [JsonProperty("websocket_tcp_converter")]
        public EndpointWebsocketTcpConverter WebsocketTcpConverter { get; set; }

        public override string ToString()
        {
            return $"HttpsEdgeRoute EdgeId={ EdgeId }  Id={ Id }  CreatedAt={ CreatedAt }  MatchType={ MatchType }  Match={ Match }  Uri={ Uri }  Description={ Description }  Metadata={ Metadata }  Backend={ Backend }  IpRestriction={ IpRestriction }  CircuitBreaker={ CircuitBreaker }  Compression={ Compression }  RequestHeaders={ RequestHeaders }  ResponseHeaders={ ResponseHeaders }  WebhookVerification={ WebhookVerification }  Oauth={ Oauth }  Saml={ Saml }  Oidc={ Oidc }  WebsocketTcpConverter={ WebsocketTcpConverter } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (EdgeId?.GetHashCode() ?? 0);

                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (MatchType?.GetHashCode() ?? 0);

                hash = hash * 23 + (Match?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Backend?.GetHashCode() ?? 0);

                hash = hash * 23 + (IpRestriction?.GetHashCode() ?? 0);

                hash = hash * 23 + (CircuitBreaker?.GetHashCode() ?? 0);

                hash = hash * 23 + (Compression?.GetHashCode() ?? 0);

                hash = hash * 23 + (RequestHeaders?.GetHashCode() ?? 0);

                hash = hash * 23 + (ResponseHeaders?.GetHashCode() ?? 0);

                hash = hash * 23 + (WebhookVerification?.GetHashCode() ?? 0);

                hash = hash * 23 + (Oauth?.GetHashCode() ?? 0);

                hash = hash * 23 + (Saml?.GetHashCode() ?? 0);

                hash = hash * 23 + (Oidc?.GetHashCode() ?? 0);

                hash = hash * 23 + (WebsocketTcpConverter?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (HttpsEdgeRoute)obj;
            return (
                 this.EdgeId == other.EdgeId
                && this.Id == other.Id
                && this.CreatedAt == other.CreatedAt
                && this.MatchType == other.MatchType
                && this.Match == other.Match
                && this.Uri == other.Uri
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Backend == other.Backend
                && this.IpRestriction == other.IpRestriction
                && this.CircuitBreaker == other.CircuitBreaker
                && this.Compression == other.Compression
                && this.RequestHeaders == other.RequestHeaders
                && this.ResponseHeaders == other.ResponseHeaders
                && this.WebhookVerification == other.WebhookVerification
                && this.Oauth == other.Oauth
                && this.Saml == other.Saml
                && this.Oidc == other.Oidc
                && this.WebsocketTcpConverter == other.WebsocketTcpConverter
            );
        }

    }
}

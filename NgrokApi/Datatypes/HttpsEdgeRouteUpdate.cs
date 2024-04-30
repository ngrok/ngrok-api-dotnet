/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class HttpsEdgeRouteUpdate : HasId
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
        public EndpointBackendMutate Backend { get; set; }
        // <summary>
        // ip restriction module configuration or <c>null</c>
        // </summary>
        [JsonProperty("ip_restriction")]
        public EndpointIpPolicyMutate IpRestriction { get; set; }
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
        public EndpointSamlMutate Saml { get; set; }
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
        [JsonProperty("user_agent_filter")]
        public EndpointUserAgentFilter UserAgentFilter { get; set; }
        // <summary>
        // the traffic policy associated with this edge or null
        // </summary>
        [JsonProperty("policy")]
        public EndpointPolicy Policy { get; set; }

        public override string ToString()
        {
            return $"HttpsEdgeRouteUpdate EdgeId={ EdgeId }  Id={ Id }  MatchType={ MatchType }  Match={ Match }  Description={ Description }  Metadata={ Metadata }  Backend={ Backend }  IpRestriction={ IpRestriction }  CircuitBreaker={ CircuitBreaker }  Compression={ Compression }  RequestHeaders={ RequestHeaders }  ResponseHeaders={ ResponseHeaders }  WebhookVerification={ WebhookVerification }  Oauth={ Oauth }  Saml={ Saml }  Oidc={ Oidc }  WebsocketTcpConverter={ WebsocketTcpConverter }  UserAgentFilter={ UserAgentFilter }  Policy={ Policy } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (EdgeId?.GetHashCode() ?? 0);

                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (MatchType?.GetHashCode() ?? 0);

                hash = hash * 23 + (Match?.GetHashCode() ?? 0);

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

                hash = hash * 23 + (UserAgentFilter?.GetHashCode() ?? 0);

                hash = hash * 23 + (Policy?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (HttpsEdgeRouteUpdate)obj;
            return (
                 this.EdgeId == other.EdgeId
                && this.Id == other.Id
                && this.MatchType == other.MatchType
                && this.Match == other.Match
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
                && this.UserAgentFilter == other.UserAgentFilter
                && this.Policy == other.Policy
            );
        }

    }
}

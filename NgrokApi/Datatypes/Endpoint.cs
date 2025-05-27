/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class Endpoint : HasId
    {
        // <summary>
        // unique endpoint resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // identifier of the region this endpoint belongs to
        // </summary>
        [JsonProperty("region")]
        public string Region { get; set; }
        // <summary>
        // timestamp when the endpoint was created in RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // timestamp when the endpoint was updated in RFC 3339 format
        // </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
        // <summary>
        // URL of the hostport served by this endpoint
        // </summary>
        [JsonProperty("public_url")]
        public Uri PublicUrl { get; set; }
        // <summary>
        // protocol served by this endpoint. one of <c>http</c>, <c>https</c>, <c>tcp</c>,
        // or <c>tls</c>
        // </summary>
        [JsonProperty("proto")]
        public string Proto { get; set; }
        [JsonProperty("scheme")]
        public string Scheme { get; set; }
        // <summary>
        // hostport served by this endpoint (hostname:port) -> soon to be deprecated
        // </summary>
        [JsonProperty("hostport")]
        public string Hostport { get; set; }
        [JsonProperty("host")]
        public string Host { get; set; }
        [JsonProperty("port")]
        public int Port { get; set; }
        // <summary>
        // whether the endpoint is <c>ephemeral</c> (served directly by an agent-initiated
        // tunnel) or <c>edge</c> (served by an edge) or <c>cloud (represents a cloud
        // endpoint)</c>
        // </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        // <summary>
        // user-supplied metadata of the associated tunnel or edge object
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // user-supplied description of the associated tunnel
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // the domain reserved for this endpoint
        // </summary>
        [JsonProperty("domain")]
        public Ref Domain { get; set; }
        // <summary>
        // the address reserved for this endpoint
        // </summary>
        [JsonProperty("tcp_addr")]
        public Ref TcpAddr { get; set; }
        // <summary>
        // the tunnel serving requests to this endpoint, if this is an ephemeral endpoint
        // </summary>
        [JsonProperty("tunnel")]
        public Ref Tunnel { get; set; }
        // <summary>
        // the edge serving requests to this endpoint, if this is an edge endpoint
        // </summary>
        [JsonProperty("edge")]
        public Ref Edge { get; set; }
        // <summary>
        // the local address the tunnel forwards to
        // </summary>
        [JsonProperty("upstream_url")]
        public string UpstreamUrl { get; set; }
        // <summary>
        // the protocol the agent uses to forward with
        // </summary>
        [JsonProperty("upstream_protocol")]
        public string UpstreamProtocol { get; set; }
        // <summary>
        // the url of the endpoint
        // </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        // <summary>
        // The ID of the owner (bot or user) that owns this endpoint
        // </summary>
        [JsonProperty("principal")]
        public Ref Principal { get; set; }
        // <summary>
        // The traffic policy attached to this endpoint
        // </summary>
        [JsonProperty("traffic_policy")]
        public string TrafficPolicy { get; set; }
        // <summary>
        // the bindings associated with this endpoint
        // </summary>
        [JsonProperty("bindings")]
        public List<string> Bindings { get; set; }
        // <summary>
        // The tunnel session of the agent for this endpoint
        // </summary>
        [JsonProperty("tunnel_session")]
        public Ref TunnelSession { get; set; }
        // <summary>
        // URI of the clep API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // user supplied name for the endpoint
        // </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        // <summary>
        // whether the endpoint allows pooling
        // </summary>
        [JsonProperty("pooling_enabled")]
        public bool PoolingEnabled { get; set; }

        public override string ToString()
        {
            return $"Endpoint Id={ Id }  Region={ Region }  CreatedAt={ CreatedAt }  UpdatedAt={ UpdatedAt }  PublicUrl={ PublicUrl }  Proto={ Proto }  Scheme={ Scheme }  Hostport={ Hostport }  Host={ Host }  Port={ Port }  Type={ Type }  Metadata={ Metadata }  Description={ Description }  Domain={ Domain }  TcpAddr={ TcpAddr }  Tunnel={ Tunnel }  Edge={ Edge }  UpstreamUrl={ UpstreamUrl }  UpstreamProtocol={ UpstreamProtocol }  Url={ Url }  Principal={ Principal }  TrafficPolicy={ TrafficPolicy }  Bindings={ Bindings }  TunnelSession={ TunnelSession }  Uri={ Uri }  Name={ Name }  PoolingEnabled={ PoolingEnabled } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Region?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (UpdatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (PublicUrl?.GetHashCode() ?? 0);

                hash = hash * 23 + (Proto?.GetHashCode() ?? 0);

                hash = hash * 23 + (Scheme?.GetHashCode() ?? 0);

                hash = hash * 23 + (Hostport?.GetHashCode() ?? 0);

                hash = hash * 23 + (Host?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(Port);
                hash = hash * 23 + (Type?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Domain?.GetHashCode() ?? 0);

                hash = hash * 23 + (TcpAddr?.GetHashCode() ?? 0);

                hash = hash * 23 + (Tunnel?.GetHashCode() ?? 0);

                hash = hash * 23 + (Edge?.GetHashCode() ?? 0);

                hash = hash * 23 + (UpstreamUrl?.GetHashCode() ?? 0);

                hash = hash * 23 + (UpstreamProtocol?.GetHashCode() ?? 0);

                hash = hash * 23 + (Url?.GetHashCode() ?? 0);

                hash = hash * 23 + (Principal?.GetHashCode() ?? 0);

                hash = hash * 23 + (TrafficPolicy?.GetHashCode() ?? 0);

                hash = hash * 23 + (Bindings?.GetHashCode() ?? 0);

                hash = hash * 23 + (TunnelSession?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (Name?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(PoolingEnabled);
                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (Endpoint)obj;
            return (
                 this.Id == other.Id
                && this.Region == other.Region
                && this.CreatedAt == other.CreatedAt
                && this.UpdatedAt == other.UpdatedAt
                && this.PublicUrl == other.PublicUrl
                && this.Proto == other.Proto
                && this.Scheme == other.Scheme
                && this.Hostport == other.Hostport
                && this.Host == other.Host
                && this.Port == other.Port
                && this.Type == other.Type
                && this.Metadata == other.Metadata
                && this.Description == other.Description
                && this.Domain == other.Domain
                && this.TcpAddr == other.TcpAddr
                && this.Tunnel == other.Tunnel
                && this.Edge == other.Edge
                && this.UpstreamUrl == other.UpstreamUrl
                && this.UpstreamProtocol == other.UpstreamProtocol
                && this.Url == other.Url
                && this.Principal == other.Principal
                && this.TrafficPolicy == other.TrafficPolicy
                && this.Bindings == other.Bindings
                && this.TunnelSession == other.TunnelSession
                && this.Uri == other.Uri
                && this.Name == other.Name
                && this.PoolingEnabled == other.PoolingEnabled
            );
        }

    }
}

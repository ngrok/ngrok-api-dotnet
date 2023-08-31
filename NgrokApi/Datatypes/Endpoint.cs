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
        // <summary>
        // hostport served by this endpoint (hostname:port)
        // </summary>
        [JsonProperty("hostport")]
        public string Hostport { get; set; }
        // <summary>
        // whether the endpoint is <c>ephemeral</c> (served directly by an agent-initiated
        // tunnel) or <c>edge</c> (served by an edge)
        // </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        // <summary>
        // user-supplied metadata of the associated tunnel or edge object
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
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

        public override string ToString()
        {
            return $"Endpoint Id={ Id }  Region={ Region }  CreatedAt={ CreatedAt }  UpdatedAt={ UpdatedAt }  PublicUrl={ PublicUrl }  Proto={ Proto }  Hostport={ Hostport }  Type={ Type }  Metadata={ Metadata }  Domain={ Domain }  TcpAddr={ TcpAddr }  Tunnel={ Tunnel }  Edge={ Edge } ";
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

                hash = hash * 23 + (Hostport?.GetHashCode() ?? 0);

                hash = hash * 23 + (Type?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Domain?.GetHashCode() ?? 0);

                hash = hash * 23 + (TcpAddr?.GetHashCode() ?? 0);

                hash = hash * 23 + (Tunnel?.GetHashCode() ?? 0);

                hash = hash * 23 + (Edge?.GetHashCode() ?? 0);

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
                && this.Hostport == other.Hostport
                && this.Type == other.Type
                && this.Metadata == other.Metadata
                && this.Domain == other.Domain
                && this.TcpAddr == other.TcpAddr
                && this.Tunnel == other.Tunnel
                && this.Edge == other.Edge
            );
        }

    }
}

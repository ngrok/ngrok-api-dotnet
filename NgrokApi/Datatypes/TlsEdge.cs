
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class TlsEdge : HasId
    {
        // <summary>
        // unique identifier of this edge
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
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
        // timestamp when the edge configuration was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // URI of the edge API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // hostports served by this edge
        // </summary>
        [JsonProperty("hostports")]
        public List<string> Hostports { get; set; }
        // <summary>
        // edge modules
        // </summary>
        [JsonProperty("backend")]
        public EndpointBackend Backend { get; set; }
        [JsonProperty("ip_restriction")]
        public EndpointIpPolicy IpRestriction { get; set; }
        [JsonProperty("mutual_tls")]
        public EndpointMutualTls MutualTls { get; set; }
        [JsonProperty("tls_termination")]
        public EndpointTlsTermination TlsTermination { get; set; }

        public override string ToString()
        {
            return $"TlsEdge Id={ Id }  Description={ Description }  Metadata={ Metadata }  CreatedAt={ CreatedAt }  Uri={ Uri }  Hostports={ Hostports }  Backend={ Backend }  IpRestriction={ IpRestriction }  MutualTls={ MutualTls }  TlsTermination={ TlsTermination } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (Hostports?.GetHashCode() ?? 0);

                hash = hash * 23 + (Backend?.GetHashCode() ?? 0);

                hash = hash * 23 + (IpRestriction?.GetHashCode() ?? 0);

                hash = hash * 23 + (MutualTls?.GetHashCode() ?? 0);

                hash = hash * 23 + (TlsTermination?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (TlsEdge)obj;
            return (
                 this.Id == other.Id
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.CreatedAt == other.CreatedAt
                && this.Uri == other.Uri
                && this.Hostports == other.Hostports
                && this.Backend == other.Backend
                && this.IpRestriction == other.IpRestriction
                && this.MutualTls == other.MutualTls
                && this.TlsTermination == other.TlsTermination
            );
        }

    }
}

/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class TunnelGroupBackend : HasId
    {
        // <summary>
        // unique identifier for this TunnelGroup backend
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the TunnelGroupBackend API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // timestamp when the backend was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // human-readable description of this backend. Optional
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this backend. Optional
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // labels to watch for tunnels on, e.g. app->foo, dc->bar
        // </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }
        // <summary>
        // tunnels matching this backend
        // </summary>
        [JsonProperty("tunnels")]
        public List<Ref> Tunnels { get; set; }

        public override string ToString()
        {
            return $"TunnelGroupBackend Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  Labels={ Labels }  Tunnels={ Tunnels } ";
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

                hash = hash * 23 + (Labels?.GetHashCode() ?? 0);

                hash = hash * 23 + (Tunnels?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (TunnelGroupBackend)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Labels == other.Labels
                && this.Tunnels == other.Tunnels
            );
        }

    }
}


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class Tunnel : HasId
    {
        // <summary>
        // unique tunnel resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URL of the ephemeral tunnel's public endpoint
        // </summary>
        [JsonProperty("public_url")]
        public string PublicUrl { get; set; }
        // <summary>
        // timestamp when the tunnel was initiated in RFC 3339 format
        // </summary>
        [JsonProperty("started_at")]
        public string StartedAt { get; set; }
        // <summary>
        // user-supplied metadata for the tunnel defined in the ngrok configuration file.
        // See the tunnel <see
        // href="https://ngrok.com/docs#tunnel-definitions-metadata">metadata configuration
        // option</see> In API version 0, this value was instead pulled from the top-level
        // <see href="https://ngrok.com/docs#config_metadata">metadata configuration
        // option</see>.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // tunnel protocol for ephemeral tunnels. one of <c>http</c>, <c>https</c>,
        // <c>tcp</c> or <c>tls</c>
        // </summary>
        [JsonProperty("proto")]
        public string Proto { get; set; }
        // <summary>
        // identifier of tune region where the tunnel is running
        // </summary>
        [JsonProperty("region")]
        public string Region { get; set; }
        // <summary>
        // reference object pointing to the tunnel session on which this tunnel was started
        // </summary>
        [JsonProperty("tunnel_session")]
        public Ref TunnelSession { get; set; }
        // <summary>
        // the ephemeral endpoint this tunnel is associated with, if this is an
        // agent-initiated tunnel
        // </summary>
        [JsonProperty("endpoint")]
        public Ref Endpoint { get; set; }
        // <summary>
        // the labels the tunnel group backends will match against, if this is a backend
        // tunnel
        // </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }
        // <summary>
        // tunnel group backends served by this backend tunnel
        // </summary>
        [JsonProperty("backends")]
        public List<Ref> Backends { get; set; }
        // <summary>
        // upstream address the ngrok agent forwards traffic over this tunnel to. this may
        // be expressed as a URL or a network address.
        // </summary>
        [JsonProperty("forwards_to")]
        public string ForwardsTo { get; set; }

        public override string ToString()
        {
            return $"Tunnel Id={ Id }  PublicUrl={ PublicUrl }  StartedAt={ StartedAt }  Metadata={ Metadata }  Proto={ Proto }  Region={ Region }  TunnelSession={ TunnelSession }  Endpoint={ Endpoint }  Labels={ Labels }  Backends={ Backends }  ForwardsTo={ ForwardsTo } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (PublicUrl?.GetHashCode() ?? 0);

                hash = hash * 23 + (StartedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Proto?.GetHashCode() ?? 0);

                hash = hash * 23 + (Region?.GetHashCode() ?? 0);

                hash = hash * 23 + (TunnelSession?.GetHashCode() ?? 0);

                hash = hash * 23 + (Endpoint?.GetHashCode() ?? 0);

                hash = hash * 23 + (Labels?.GetHashCode() ?? 0);

                hash = hash * 23 + (Backends?.GetHashCode() ?? 0);

                hash = hash * 23 + (ForwardsTo?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (Tunnel)obj;
            return (
                 this.Id == other.Id
                && this.PublicUrl == other.PublicUrl
                && this.StartedAt == other.StartedAt
                && this.Metadata == other.Metadata
                && this.Proto == other.Proto
                && this.Region == other.Region
                && this.TunnelSession == other.TunnelSession
                && this.Endpoint == other.Endpoint
                && this.Labels == other.Labels
                && this.Backends == other.Backends
                && this.ForwardsTo == other.ForwardsTo
            );
        }

    }
}

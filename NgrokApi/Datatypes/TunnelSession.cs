
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class TunnelSession : HasId
    {
        // <summary>
        // version of the ngrok agent that started this ngrok tunnel session
        // </summary>
        [JsonProperty("agent_version")]
        public string AgentVersion { get; set; }
        // <summary>
        // reference to the tunnel credential or ssh credential used by the ngrok agent to
        // start this tunnel session
        // </summary>
        [JsonProperty("credential")]
        public Ref Credential { get; set; }
        // <summary>
        // unique tunnel session resource identifier
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // source ip address of the tunnel session
        // </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }
        // <summary>
        // arbitrary user-defined data specified in the metadata property in the ngrok
        // configuration file. See the metadata configuration option
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // operating system of the host the ngrok agent is running on
        // </summary>
        [JsonProperty("os")]
        public string Os { get; set; }
        // <summary>
        // the ngrok region identifier in which this tunnel session was started
        // </summary>
        [JsonProperty("region")]
        public string Region { get; set; }
        // <summary>
        // time when the tunnel session first connected to the ngrok servers
        // </summary>
        [JsonProperty("started_at")]
        public string StartedAt { get; set; }
        // <summary>
        // the transport protocol used to start the tunnel session. Either <c>ngrok/v2</c>
        // or <c>ssh</c>
        // </summary>
        [JsonProperty("transport")]
        public string Transport { get; set; }
        // <summary>
        // URI to the API resource of the tunnel session
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        public override string ToString()
        {
            return $"TunnelSession AgentVersion={ AgentVersion }  Credential={ Credential }  Id={ Id }  Ip={ Ip }  Metadata={ Metadata }  Os={ Os }  Region={ Region }  StartedAt={ StartedAt }  Transport={ Transport }  Uri={ Uri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (AgentVersion?.GetHashCode() ?? 0);

                hash = hash * 23 + (Credential?.GetHashCode() ?? 0);

                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Ip?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Os?.GetHashCode() ?? 0);

                hash = hash * 23 + (Region?.GetHashCode() ?? 0);

                hash = hash * 23 + (StartedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Transport?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (TunnelSession)obj;
            return (
                 this.AgentVersion == other.AgentVersion
                && this.Credential == other.Credential
                && this.Id == other.Id
                && this.Ip == other.Ip
                && this.Metadata == other.Metadata
                && this.Os == other.Os
                && this.Region == other.Region
                && this.StartedAt == other.StartedAt
                && this.Transport == other.Transport
                && this.Uri == other.Uri
            );
        }

    }
}

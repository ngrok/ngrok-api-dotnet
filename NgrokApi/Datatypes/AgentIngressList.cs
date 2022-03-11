using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class AgentIngressList
    {
        // <summary>
        // the list of Agent Ingresses owned by this account
        // </summary>
        [JsonPropertyName("ingresses")]
        public List<AgentIngress> Ingresses { get; set; }
        // <summary>
        // URI of the Agent Ingress list API resource
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        // <summary>
        // URI of the next page, or null if there is no next page
        // </summary>
        [JsonPropertyName("next_page_uri")]
        public string NextPageUri { get; set; }

        public override string ToString()
        {
            return $"AgentIngressList Ingresses={ Ingresses }  Uri={ Uri }  NextPageUri={ NextPageUri } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Ingresses?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (NextPageUri?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (AgentIngressList)obj;
            return (
                 this.Ingresses == other.Ingresses
                && this.Uri == other.Uri
                && this.NextPageUri == other.NextPageUri
            );
        }

    }
}

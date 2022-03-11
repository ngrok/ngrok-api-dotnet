using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class ReservedAddr : HasId
    {
        // <summary>
        // unique reserved address resource identifier
        // </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the reserved address API resource
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        // <summary>
        // timestamp when the reserved address was created, RFC 3339 format
        // </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // human-readable description of what this reserved address will be used for
        // </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this reserved address. Optional,
        // max 4096 bytes.
        // </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // hostname:port of the reserved address that was assigned at creation time
        // </summary>
        [JsonPropertyName("addr")]
        public string Addr { get; set; }
        // <summary>
        // reserve the address in this geographic ngrok datacenter. Optional, default is
        // us. (au, eu, ap, us, jp, in, sa)
        // </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }
        // <summary>
        // object reference to the endpoint configuration that will be applied to traffic
        // to this address
        // </summary>
        [JsonPropertyName("endpoint_configuration")]
        public Ref EndpointConfiguration { get; set; }

        public override string ToString()
        {
            return $"ReservedAddr Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  Addr={ Addr }  Region={ Region }  EndpointConfiguration={ EndpointConfiguration } ";
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

                hash = hash * 23 + (Addr?.GetHashCode() ?? 0);

                hash = hash * 23 + (Region?.GetHashCode() ?? 0);

                hash = hash * 23 + (EndpointConfiguration?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ReservedAddr)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Addr == other.Addr
                && this.Region == other.Region
                && this.EndpointConfiguration == other.EndpointConfiguration
            );
        }

    }
}

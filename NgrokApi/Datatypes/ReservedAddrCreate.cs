using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class ReservedAddrCreate
    {
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
        // reserve the address in this geographic ngrok datacenter. Optional, default is
        // us. (au, eu, ap, us, jp, in, sa)
        // </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }
        // <summary>
        // ID of an endpoint configuration of type tcp that will be used to handle inbound
        // traffic to this address
        // </summary>
        [JsonPropertyName("endpoint_configuration_id")]
        public string EndpointConfigurationId { get; set; }

        public override string ToString()
        {
            return $"ReservedAddrCreate Description={ Description }  Metadata={ Metadata }  Region={ Region }  EndpointConfigurationId={ EndpointConfigurationId } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Region?.GetHashCode() ?? 0);

                hash = hash * 23 + (EndpointConfigurationId?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ReservedAddrCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Region == other.Region
                && this.EndpointConfigurationId == other.EndpointConfigurationId
            );
        }

    }
}

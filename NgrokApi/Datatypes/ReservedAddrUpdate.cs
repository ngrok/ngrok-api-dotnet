
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ReservedAddrUpdate : HasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // human-readable description of what this reserved address will be used for
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this reserved address. Optional,
        // max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // ID of an endpoint configuration of type tcp that will be used to handle inbound
        // traffic to this address
        // </summary>
        [JsonProperty("endpoint_configuration_id")]
        public string EndpointConfigurationId { get; set; }

        public override string ToString()
        {
            return $"ReservedAddrUpdate Id={ Id }  Description={ Description }  Metadata={ Metadata }  EndpointConfigurationId={ EndpointConfigurationId } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (EndpointConfigurationId?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (ReservedAddrUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.EndpointConfigurationId == other.EndpointConfigurationId
            );
        }

    }
}

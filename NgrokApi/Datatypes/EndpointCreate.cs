/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointCreate
    {
        // <summary>
        // the url of the endpoint
        // </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        // <summary>
        // Type of endpoint. Only 'cloud' is currently supported (represents a cloud
        // endpoint). Defaults to 'cloud' if not specified.
        // </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        // <summary>
        // The traffic policy attached to this endpoint
        // </summary>
        [JsonProperty("traffic_policy")]
        public string TrafficPolicy { get; set; }
        // <summary>
        // user-supplied description of the associated tunnel
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // user-supplied metadata of the associated tunnel or edge object
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // the bindings associated with this endpoint
        // </summary>
        [JsonProperty("bindings")]
        public List<string> Bindings { get; set; }
        [JsonProperty("pooling_enabled")]
        public bool PoolingEnabled { get; set; }

        public override string ToString()
        {
            return $"EndpointCreate Url={ Url }  Type={ Type }  TrafficPolicy={ TrafficPolicy }  Description={ Description }  Metadata={ Metadata }  Bindings={ Bindings }  PoolingEnabled={ PoolingEnabled } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Url?.GetHashCode() ?? 0);

                hash = hash * 23 + (Type?.GetHashCode() ?? 0);

                hash = hash * 23 + (TrafficPolicy?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Bindings?.GetHashCode() ?? 0);

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
            var other = (EndpointCreate)obj;
            return (
                 this.Url == other.Url
                && this.Type == other.Type
                && this.TrafficPolicy == other.TrafficPolicy
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Bindings == other.Bindings
                && this.PoolingEnabled == other.PoolingEnabled
            );
        }

    }
}

/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class TlsEdgeCreate
    {
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
        // hostports served by this edge
        // </summary>
        [JsonProperty("hostports")]
        public List<string> Hostports { get; set; }
        // <summary>
        // edge modules
        // </summary>
        [JsonProperty("backend")]
        public EndpointBackendMutate Backend { get; set; }
        [JsonProperty("ip_restriction")]
        public EndpointIpPolicyMutate IpRestriction { get; set; }
        [JsonProperty("mutual_tls")]
        public EndpointMutualTlsMutate MutualTls { get; set; }
        [JsonProperty("tls_termination")]
        public EndpointTlsTermination TlsTermination { get; set; }
        // <summary>
        // the traffic policy associated with this edge or null
        // </summary>
        [JsonProperty("traffic_policy")]
        public EndpointTrafficPolicy TrafficPolicy { get; set; }

        public override string ToString()
        {
            return $"TlsEdgeCreate Description={ Description }  Metadata={ Metadata }  Hostports={ Hostports }  Backend={ Backend }  IpRestriction={ IpRestriction }  MutualTls={ MutualTls }  TlsTermination={ TlsTermination }  TrafficPolicy={ TrafficPolicy } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Hostports?.GetHashCode() ?? 0);

                hash = hash * 23 + (Backend?.GetHashCode() ?? 0);

                hash = hash * 23 + (IpRestriction?.GetHashCode() ?? 0);

                hash = hash * 23 + (MutualTls?.GetHashCode() ?? 0);

                hash = hash * 23 + (TlsTermination?.GetHashCode() ?? 0);

                hash = hash * 23 + (TrafficPolicy?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (TlsEdgeCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Hostports == other.Hostports
                && this.Backend == other.Backend
                && this.IpRestriction == other.IpRestriction
                && this.MutualTls == other.MutualTls
                && this.TlsTermination == other.TlsTermination
                && this.TrafficPolicy == other.TrafficPolicy
            );
        }

    }
}

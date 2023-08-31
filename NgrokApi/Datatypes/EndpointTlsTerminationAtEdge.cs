/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class EndpointTlsTerminationAtEdge
    {
        // <summary>
        // <c>true</c> if the module will be applied to traffic, <c>false</c> to disable.
        // default <c>true</c> if unspecified
        // </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
        // <summary>
        // The minimum TLS version used for termination and advertised to the client during
        // the TLS handshake. if unspecified, ngrok will choose an industry-safe default.
        // This value must be null if <c>terminate_at</c> is set to <c>upstream</c>.
        // </summary>
        [JsonProperty("min_version")]
        public string MinVersion { get; set; }

        public override string ToString()
        {
            return $"EndpointTlsTerminationAtEdge Enabled={ Enabled }  MinVersion={ MinVersion } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Convert.ToInt32(Enabled);
                hash = hash * 23 + (MinVersion?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (EndpointTlsTerminationAtEdge)obj;
            return (
                 this.Enabled == other.Enabled
                && this.MinVersion == other.MinVersion
            );
        }

    }
}

/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class StaticBackendCreate
    {
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
        // the address to forward to
        // </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
        // <summary>
        // tls configuration to use
        // </summary>
        [JsonProperty("tls")]
        public StaticBackendTls Tls { get; set; }

        public override string ToString()
        {
            return $"StaticBackendCreate Description={ Description }  Metadata={ Metadata }  Address={ Address }  Tls={ Tls } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Address?.GetHashCode() ?? 0);

                hash = hash * 23 + (Tls?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (StaticBackendCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Address == other.Address
                && this.Tls == other.Tls
            );
        }

    }
}

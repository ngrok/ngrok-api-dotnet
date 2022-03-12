
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class WeightedBackendCreate
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
        // the ids of the child backends to their weights (0-10000)
        // </summary>
        [JsonProperty("backends")]
        public Dictionary<string, int> Backends { get; set; }

        public override string ToString()
        {
            return $"WeightedBackendCreate Description={ Description }  Metadata={ Metadata }  Backends={ Backends } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Backends?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (WeightedBackendCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Backends == other.Backends
            );
        }

    }
}

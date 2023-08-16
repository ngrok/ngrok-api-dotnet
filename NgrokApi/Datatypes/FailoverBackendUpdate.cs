/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class FailoverBackendUpdate : HasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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
        // the ids of the child backends in order
        // </summary>
        [JsonProperty("backends")]
        public List<string> Backends { get; set; }

        public override string ToString()
        {
            return $"FailoverBackendUpdate Id={ Id }  Description={ Description }  Metadata={ Metadata }  Backends={ Backends } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Backends?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (FailoverBackendUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.Backends == other.Backends
            );
        }

    }
}

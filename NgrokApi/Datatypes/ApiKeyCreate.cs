
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class ApiKeyCreate
    {
        // <summary>
        // human-readable description of what uses the API key to authenticate. optional,
        // max 255 bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined data of this API key. optional, max 4096 bytes
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        public override string ToString()
        {
            return $"ApiKeyCreate Description={ Description }  Metadata={ Metadata } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (ApiKeyCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
            );
        }

    }
}

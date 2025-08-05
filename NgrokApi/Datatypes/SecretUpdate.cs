/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class SecretUpdate : HasId
    {
        // <summary>
        // identifier for Secret
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // Name of secret
        // </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        // <summary>
        // Value of secret
        // </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
        // <summary>
        // Arbitrary user-defined metadata for this Secret
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // description of Secret
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        public override string ToString()
        {
            return $"SecretUpdate Id={ Id }  Name={ Name }  Value={ Value }  Metadata={ Metadata }  Description={ Description } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Name?.GetHashCode() ?? 0);

                hash = hash * 23 + (Value?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (SecretUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Name == other.Name
                && this.Value == other.Value
                && this.Metadata == other.Metadata
                && this.Description == other.Description
            );
        }

    }
}

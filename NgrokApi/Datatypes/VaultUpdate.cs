/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class VaultUpdate : HasId
    {
        // <summary>
        // identifier for Vault
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // Name of vault
        // </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        // <summary>
        // Arbitrary user-defined metadata for this Vault
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // description of Vault
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        public override string ToString()
        {
            return $"VaultUpdate Id={ Id }  Name={ Name }  Metadata={ Metadata }  Description={ Description } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Name?.GetHashCode() ?? 0);

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
            var other = (VaultUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Name == other.Name
                && this.Metadata == other.Metadata
                && this.Description == other.Description
            );
        }

    }
}

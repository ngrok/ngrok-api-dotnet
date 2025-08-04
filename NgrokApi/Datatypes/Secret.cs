/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class Secret : HasId
    {
        // <summary>
        // identifier for Secret
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of this Secret API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // Timestamp when the Secret was created (RFC 3339 format)
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // Timestamp when the Secret was last updated (RFC 3339 format)
        // </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
        // <summary>
        // Name of secret
        // </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        // <summary>
        // description of Secret
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // Arbitrary user-defined metadata for this Secret
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // Reference to who created this Secret
        // </summary>
        [JsonProperty("created_by")]
        public Ref CreatedBy { get; set; }
        // <summary>
        // Reference to who created this Secret
        // </summary>
        [JsonProperty("last_updated_by")]
        public Ref LastUpdatedBy { get; set; }
        // <summary>
        // Reference to the vault the secret is stored in
        // </summary>
        [JsonProperty("vault")]
        public Ref Vault { get; set; }

        public override string ToString()
        {
            return $"Secret Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  UpdatedAt={ UpdatedAt }  Name={ Name }  Description={ Description }  Metadata={ Metadata }  CreatedBy={ CreatedBy }  LastUpdatedBy={ LastUpdatedBy }  Vault={ Vault } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (UpdatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Name?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedBy?.GetHashCode() ?? 0);

                hash = hash * 23 + (LastUpdatedBy?.GetHashCode() ?? 0);

                hash = hash * 23 + (Vault?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (Secret)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.UpdatedAt == other.UpdatedAt
                && this.Name == other.Name
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.CreatedBy == other.CreatedBy
                && this.LastUpdatedBy == other.LastUpdatedBy
                && this.Vault == other.Vault
            );
        }

    }
}

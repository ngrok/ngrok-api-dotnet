/* Code generated for API Clients. DO NOT EDIT. */


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class SshCertificateAuthority : HasId
    {
        // <summary>
        // unique identifier for this SSH Certificate Authority
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the SSH Certificate Authority API resource
        // </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }
        // <summary>
        // timestamp when the SSH Certificate Authority API resource was created, RFC 3339
        // format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // human-readable description of this SSH Certificate Authority. optional, max 255
        // bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this SSH Certificate Authority.
        // optional, max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // raw public key for this SSH Certificate Authority
        // </summary>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
        // <summary>
        // the type of private key for this SSH Certificate Authority
        // </summary>
        [JsonProperty("key_type")]
        public string KeyType { get; set; }

        public override string ToString()
        {
            return $"SshCertificateAuthority Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  PublicKey={ PublicKey }  KeyType={ KeyType } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Uri?.GetHashCode() ?? 0);

                hash = hash * 23 + (CreatedAt?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (PublicKey?.GetHashCode() ?? 0);

                hash = hash * 23 + (KeyType?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (SshCertificateAuthority)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.PublicKey == other.PublicKey
                && this.KeyType == other.KeyType
            );
        }

    }
}

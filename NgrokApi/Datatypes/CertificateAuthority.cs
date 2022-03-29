
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class CertificateAuthority : HasId
    {
        // <summary>
        // unique identifier for this Certificate Authority
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the Certificate Authority API resource
        // </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
        // <summary>
        // timestamp when the Certificate Authority was created, RFC 3339 format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // human-readable description of this Certificate Authority. optional, max 255
        // bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this Certificate Authority.
        // optional, max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // raw PEM of the Certificate Authority
        // </summary>
        [JsonProperty("ca_pem")]
        public string CaPem { get; set; }
        // <summary>
        // subject common name of the Certificate Authority
        // </summary>
        [JsonProperty("subject_common_name")]
        public string SubjectCommonName { get; set; }
        // <summary>
        // timestamp when this Certificate Authority becomes valid, RFC 3339 format
        // </summary>
        [JsonProperty("not_before")]
        public string NotBefore { get; set; }
        // <summary>
        // timestamp when this Certificate Authority becomes invalid, RFC 3339 format
        // </summary>
        [JsonProperty("not_after")]
        public string NotAfter { get; set; }
        // <summary>
        // set of actions the private key of this Certificate Authority can be used for
        // </summary>
        [JsonProperty("key_usages")]
        public List<string> KeyUsages { get; set; }
        // <summary>
        // extended set of actions the private key of this Certificate Authority can be
        // used for
        // </summary>
        [JsonProperty("extended_key_usages")]
        public List<string> ExtendedKeyUsages { get; set; }

        public override string ToString()
        {
            return $"CertificateAuthority Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  CaPem={ CaPem }  SubjectCommonName={ SubjectCommonName }  NotBefore={ NotBefore }  NotAfter={ NotAfter }  KeyUsages={ KeyUsages }  ExtendedKeyUsages={ ExtendedKeyUsages } ";
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

                hash = hash * 23 + (CaPem?.GetHashCode() ?? 0);

                hash = hash * 23 + (SubjectCommonName?.GetHashCode() ?? 0);

                hash = hash * 23 + (NotBefore?.GetHashCode() ?? 0);

                hash = hash * 23 + (NotAfter?.GetHashCode() ?? 0);

                hash = hash * 23 + (KeyUsages?.GetHashCode() ?? 0);

                hash = hash * 23 + (ExtendedKeyUsages?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (CertificateAuthority)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.CaPem == other.CaPem
                && this.SubjectCommonName == other.SubjectCommonName
                && this.NotBefore == other.NotBefore
                && this.NotAfter == other.NotAfter
                && this.KeyUsages == other.KeyUsages
                && this.ExtendedKeyUsages == other.ExtendedKeyUsages
            );
        }

    }
}


using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class CertificateAuthorityCreate
    {
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

        public override string ToString()
        {
            return $"CertificateAuthorityCreate Description={ Description }  Metadata={ Metadata }  CaPem={ CaPem } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (CaPem?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (CertificateAuthorityCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.CaPem == other.CaPem
            );
        }

    }
}

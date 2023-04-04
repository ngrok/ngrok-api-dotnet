
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class TlsCertificateCreate
    {
        // <summary>
        // human-readable description of this TLS certificate. optional, max 255 bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this TLS certificate. optional,
        // max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // chain of PEM-encoded certificates, leaf first. See <see
        // href="/cloud-edge/endpoints#certificate-chains">Certificate Bundles</see>.
        // </summary>
        [JsonProperty("certificate_pem")]
        public string CertificatePem { get; set; }
        // <summary>
        // private key for the TLS certificate, PEM-encoded. See <see
        // href="/cloud-edge/endpoints#private-keys">Private Keys</see>.
        // </summary>
        [JsonProperty("private_key_pem")]
        public string PrivateKeyPem { get; set; }

        public override string ToString()
        {
            return $"TlsCertificateCreate Description={ Description }  Metadata={ Metadata }  CertificatePem={ CertificatePem }  PrivateKeyPem={ PrivateKeyPem } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (CertificatePem?.GetHashCode() ?? 0);

                hash = hash * 23 + (PrivateKeyPem?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (TlsCertificateCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.CertificatePem == other.CertificatePem
                && this.PrivateKeyPem == other.PrivateKeyPem
            );
        }

    }
}

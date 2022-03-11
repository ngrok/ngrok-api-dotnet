using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class TlsCertificateCreate
    {
        // <summary>
        // human-readable description of this TLS certificate. optional, max 255 bytes.
        // </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this TLS certificate. optional,
        // max 4096 bytes.
        // </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // chain of PEM-encoded certificates, leaf first. See <see
        // href="https://ngrok.com/docs/api#tls-certificates-pem">Certificate
        // Bundles</see>.
        // </summary>
        [JsonPropertyName("certificate_pem")]
        public string CertificatePem { get; set; }
        // <summary>
        // private key for the TLS certificate, PEM-encoded. See <see
        // href="https://ngrok.com/docs/ngrok-link#tls-certificates-key">Private
        // Keys</see>.
        // </summary>
        [JsonPropertyName("private_key_pem")]
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

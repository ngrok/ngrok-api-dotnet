
using System;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class SshCertificateAuthorityCreate
    {
        // <summary>
        // human-readable description of this SSH Certificate Authority. optional, max 255
        // bytes.
        // </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this SSH Certificate Authority.
        // optional, max 4096 bytes.
        // </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // the type of private key to generate. one of <c>rsa</c>, <c>ecdsa</c>,
        // <c>ed25519</c>
        // </summary>
        [JsonPropertyName("private_key_type")]
        public string PrivateKeyType { get; set; }
        // <summary>
        // the type of elliptic curve to use when creating an ECDSA key
        // </summary>
        [JsonPropertyName("elliptic_curve")]
        public string EllipticCurve { get; set; }
        // <summary>
        // the key size to use when creating an RSA key. one of <c>2048</c> or <c>4096</c>
        // </summary>
        [JsonPropertyName("key_size")]
        public int KeySize { get; set; }

        public override string ToString()
        {
            return $"SshCertificateAuthorityCreate Description={ Description }  Metadata={ Metadata }  PrivateKeyType={ PrivateKeyType }  EllipticCurve={ EllipticCurve }  KeySize={ KeySize } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (PrivateKeyType?.GetHashCode() ?? 0);

                hash = hash * 23 + (EllipticCurve?.GetHashCode() ?? 0);

                hash = hash * 23 + Convert.ToInt32(KeySize);
                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (SshCertificateAuthorityCreate)obj;
            return (
                 this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.PrivateKeyType == other.PrivateKeyType
                && this.EllipticCurve == other.EllipticCurve
                && this.KeySize == other.KeySize
            );
        }

    }
}

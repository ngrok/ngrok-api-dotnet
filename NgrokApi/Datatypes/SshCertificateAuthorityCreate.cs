
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class SshCertificateAuthorityCreate
    {
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
        // the type of private key to generate. one of <c>rsa</c>, <c>ecdsa</c>,
        // <c>ed25519</c>
        // </summary>
        [JsonProperty("private_key_type")]
        public string PrivateKeyType { get; set; }
        // <summary>
        // the type of elliptic curve to use when creating an ECDSA key
        // </summary>
        [JsonProperty("elliptic_curve")]
        public string EllipticCurve { get; set; }
        // <summary>
        // the key size to use when creating an RSA key. one of <c>2048</c> or <c>4096</c>
        // </summary>
        [JsonProperty("key_size")]
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
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
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

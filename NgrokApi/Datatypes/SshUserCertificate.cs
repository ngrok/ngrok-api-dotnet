using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class SshUserCertificate : HasId
    {
        // <summary>
        // unique identifier for this SSH User Certificate
        // </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the SSH User Certificate API resource
        // </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        // <summary>
        // timestamp when the SSH User Certificate API resource was created, RFC 3339
        // format
        // </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // human-readable description of this SSH User Certificate. optional, max 255
        // bytes.
        // </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this SSH User Certificate.
        // optional, max 4096 bytes.
        // </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // a public key in OpenSSH Authorized Keys format that this certificate signs
        // </summary>
        [JsonPropertyName("public_key")]
        public string PublicKey { get; set; }
        // <summary>
        // the key type of the <c>public_key</c>, one of <c>rsa</c>, <c>ecdsa</c> or
        // <c>ed25519</c>
        // </summary>
        [JsonPropertyName("key_type")]
        public string KeyType { get; set; }
        // <summary>
        // the ssh certificate authority that is used to sign this ssh user certificate
        // </summary>
        [JsonPropertyName("ssh_certificate_authority_id")]
        public string SshCertificateAuthorityId { get; set; }
        // <summary>
        // the list of principals included in the ssh user certificate. This is the list of
        // usernames that the certificate holder may sign in as on a machine authorizinig
        // the signing certificate authority. Dangerously, if no principals are specified,
        // this certificate may be used to log in as any user.
        // </summary>
        [JsonPropertyName("principals")]
        public List<string> Principals { get; set; }
        // <summary>
        // A map of critical options included in the certificate. Only two critical options
        // are currently defined by OpenSSH: <c>force-command</c> and
        // <c>source-address</c>. See <see
        // href="https://github.com/openssh/openssh-portable/blob/master/PROTOCOL.certkeys">the
        // OpenSSH certificate protocol spec</see> for additional details.
        // </summary>
        [JsonPropertyName("critical_options")]
        public Dictionary<string, string> CriticalOptions { get; set; }
        // <summary>
        // A map of extensions included in the certificate. Extensions are additional
        // metadata that can be interpreted by the SSH server for any purpose. These can be
        // used to permit or deny the ability to open a terminal, do port forwarding, x11
        // forwarding, and more. If unspecified, the certificate will include limited
        // permissions with the following extension map: <c>{"permit-pty": "",
        // "permit-user-rc": ""}</c> OpenSSH understands a number of predefined extensions.
        // See <see
        // href="https://github.com/openssh/openssh-portable/blob/master/PROTOCOL.certkeys">the
        // OpenSSH certificate protocol spec</see> for additional details.
        // </summary>
        [JsonPropertyName("extensions")]
        public Dictionary<string, string> Extensions { get; set; }
        // <summary>
        // the time when the ssh host certificate becomes valid, in RFC 3339 format.
        // </summary>
        [JsonPropertyName("valid_after")]
        public string ValidAfter { get; set; }
        // <summary>
        // the time after which the ssh host certificate becomes invalid, in RFC 3339
        // format. the OpenSSH certificates RFC calls this <c>valid_before</c>.
        // </summary>
        [JsonPropertyName("valid_until")]
        public string ValidUntil { get; set; }
        // <summary>
        // the signed SSH certificate in OpenSSH Authorized Keys Format. this value should
        // be placed in a <c>-cert.pub</c> certificate file on disk that should be
        // referenced in your <c>sshd_config</c> configuration file with a
        // <c>HostCertificate</c> directive
        // </summary>
        [JsonPropertyName("certificate")]
        public string Certificate { get; set; }

        public override string ToString()
        {
            return $"SshUserCertificate Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  PublicKey={ PublicKey }  KeyType={ KeyType }  SshCertificateAuthorityId={ SshCertificateAuthorityId }  Principals={ Principals }  CriticalOptions={ CriticalOptions }  Extensions={ Extensions }  ValidAfter={ ValidAfter }  ValidUntil={ ValidUntil }  Certificate={ Certificate } ";
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

                hash = hash * 23 + (SshCertificateAuthorityId?.GetHashCode() ?? 0);

                hash = hash * 23 + (Principals?.GetHashCode() ?? 0);

                hash = hash * 23 + (CriticalOptions?.GetHashCode() ?? 0);

                hash = hash * 23 + (Extensions?.GetHashCode() ?? 0);

                hash = hash * 23 + (ValidAfter?.GetHashCode() ?? 0);

                hash = hash * 23 + (ValidUntil?.GetHashCode() ?? 0);

                hash = hash * 23 + (Certificate?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (SshUserCertificate)obj;
            return (
                 this.Id == other.Id
                && this.Uri == other.Uri
                && this.CreatedAt == other.CreatedAt
                && this.Description == other.Description
                && this.Metadata == other.Metadata
                && this.PublicKey == other.PublicKey
                && this.KeyType == other.KeyType
                && this.SshCertificateAuthorityId == other.SshCertificateAuthorityId
                && this.Principals == other.Principals
                && this.CriticalOptions == other.CriticalOptions
                && this.Extensions == other.Extensions
                && this.ValidAfter == other.ValidAfter
                && this.ValidUntil == other.ValidUntil
                && this.Certificate == other.Certificate
            );
        }

    }
}

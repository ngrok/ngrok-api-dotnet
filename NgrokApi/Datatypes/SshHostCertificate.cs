
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class SshHostCertificate : HasId
    {
        // <summary>
        // unique identifier for this SSH Host Certificate
        // </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        // <summary>
        // URI of the SSH Host Certificate API resource
        // </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
        // <summary>
        // timestamp when the SSH Host Certificate API resource was created, RFC 3339
        // format
        // </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        // <summary>
        // human-readable description of this SSH Host Certificate. optional, max 255
        // bytes.
        // </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        // <summary>
        // arbitrary user-defined machine-readable data of this SSH Host Certificate.
        // optional, max 4096 bytes.
        // </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // a public key in OpenSSH Authorized Keys format that this certificate signs
        // </summary>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
        // <summary>
        // the key type of the <c>public_key</c>, one of <c>rsa</c>, <c>ecdsa</c> or
        // <c>ed25519</c>
        // </summary>
        [JsonProperty("key_type")]
        public string KeyType { get; set; }
        // <summary>
        // the ssh certificate authority that is used to sign this ssh host certificate
        // </summary>
        [JsonProperty("ssh_certificate_authority_id")]
        public string SshCertificateAuthorityId { get; set; }
        // <summary>
        // the list of principals included in the ssh host certificate. This is the list of
        // hostnames and/or IP addresses that are authorized to serve SSH traffic with this
        // certificate. Dangerously, if no principals are specified, this certificate is
        // considered valid for all hosts.
        // </summary>
        [JsonProperty("principals")]
        public List<string> Principals { get; set; }
        // <summary>
        // the time when the ssh host certificate becomes valid, in RFC 3339 format.
        // </summary>
        [JsonProperty("valid_after")]
        public string ValidAfter { get; set; }
        // <summary>
        // the time after which the ssh host certificate becomes invalid, in RFC 3339
        // format. the OpenSSH certificates RFC calls this <c>valid_before</c>.
        // </summary>
        [JsonProperty("valid_until")]
        public string ValidUntil { get; set; }
        // <summary>
        // the signed SSH certificate in OpenSSH Authorized Keys format. this value should
        // be placed in a <c>-cert.pub</c> certificate file on disk that should be
        // referenced in your <c>sshd_config</c> configuration file with a
        // <c>HostCertificate</c> directive
        // </summary>
        [JsonProperty("certificate")]
        public string Certificate { get; set; }

        public override string ToString()
        {
            return $"SshHostCertificate Id={ Id }  Uri={ Uri }  CreatedAt={ CreatedAt }  Description={ Description }  Metadata={ Metadata }  PublicKey={ PublicKey }  KeyType={ KeyType }  SshCertificateAuthorityId={ SshCertificateAuthorityId }  Principals={ Principals }  ValidAfter={ ValidAfter }  ValidUntil={ ValidUntil }  Certificate={ Certificate } ";
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

                hash = hash * 23 + (ValidAfter?.GetHashCode() ?? 0);

                hash = hash * 23 + (ValidUntil?.GetHashCode() ?? 0);

                hash = hash * 23 + (Certificate?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (SshHostCertificate)obj;
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
                && this.ValidAfter == other.ValidAfter
                && this.ValidUntil == other.ValidUntil
                && this.Certificate == other.Certificate
            );
        }

    }
}

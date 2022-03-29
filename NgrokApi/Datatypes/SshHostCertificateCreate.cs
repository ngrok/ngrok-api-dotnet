
using System;
using System.Runtime;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NgrokApi
{
    public class SshHostCertificateCreate
    {
        // <summary>
        // the ssh certificate authority that is used to sign this ssh host certificate
        // </summary>
        [JsonProperty("ssh_certificate_authority_id")]
        public string SshCertificateAuthorityId { get; set; }
        // <summary>
        // a public key in OpenSSH Authorized Keys format that this certificate signs
        // </summary>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
        // <summary>
        // the list of principals included in the ssh host certificate. This is the list of
        // hostnames and/or IP addresses that are authorized to serve SSH traffic with this
        // certificate. Dangerously, if no principals are specified, this certificate is
        // considered valid for all hosts.
        // </summary>
        [JsonProperty("principals")]
        public List<string> Principals { get; set; }
        // <summary>
        // The time when the host certificate becomes valid, in RFC 3339 format. Defaults
        // to the current time if unspecified.
        // </summary>
        [JsonProperty("valid_after")]
        public string ValidAfter { get; set; }
        // <summary>
        // The time when this host certificate becomes invalid, in RFC 3339 format. If
        // unspecified, a default value of one year in the future will be used. The OpenSSH
        // certificates RFC calls this <c>valid_before</c>.
        // </summary>
        [JsonProperty("valid_until")]
        public string ValidUntil { get; set; }
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

        public override string ToString()
        {
            return $"SshHostCertificateCreate SshCertificateAuthorityId={ SshCertificateAuthorityId }  PublicKey={ PublicKey }  Principals={ Principals }  ValidAfter={ ValidAfter }  ValidUntil={ ValidUntil }  Description={ Description }  Metadata={ Metadata } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (SshCertificateAuthorityId?.GetHashCode() ?? 0);

                hash = hash * 23 + (PublicKey?.GetHashCode() ?? 0);

                hash = hash * 23 + (Principals?.GetHashCode() ?? 0);

                hash = hash * 23 + (ValidAfter?.GetHashCode() ?? 0);

                hash = hash * 23 + (ValidUntil?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            var other = (SshHostCertificateCreate)obj;
            return (
                 this.SshCertificateAuthorityId == other.SshCertificateAuthorityId
                && this.PublicKey == other.PublicKey
                && this.Principals == other.Principals
                && this.ValidAfter == other.ValidAfter
                && this.ValidUntil == other.ValidUntil
                && this.Description == other.Description
                && this.Metadata == other.Metadata
            );
        }

    }
}
